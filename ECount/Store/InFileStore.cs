using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ECount.Store
{

    public class InFileStore<T>: IStore<T>
    {
        static Dictionary<string, InFileStore<T>> Files = new Dictionary<string, InFileStore<T>>();
        
        private static void Add(string filename, InFileStore<T> file)
        {
            Files.Add(filename, file);
        }

        public static InFileStore<T> Get(string filename)
        {
            return Files[filename];
        }

        string filename;
        List<T> store;      //파일에 저장할 리스트 store 객체 생성

        BinaryFormatter binaryFormatter = new BinaryFormatter();

        public InFileStore(string filename)
        {
            this.filename = filename;
            if (!File.Exists(filename))
            {
                FileStream fs = File.Create(filename);
                fs.Close();
            }
            Stream readStream = new FileStream(this.filename, FileMode.Open);
            try
            {
                this.store = (List<T>)binaryFormatter.Deserialize(readStream);

                readStream.Close();
            }
            catch
            {
                this.store = new List<T>();
            }
            Add(filename, this);
        }

        //리스트에 저장
        public void Save(T data)
        {
            Stream writeStream = new FileStream(this.filename, FileMode.Open);
            store.Add(data);

            binaryFormatter.Serialize(writeStream, store);
            writeStream.Close();
        }

        //리스트 전체 목록 가져오기
        public List<T> GetAll()
        {
            return store;
        }

        //?? 매칭되는 한개 찾기
        public List<T> GetAll(Predicate<T> match)
        {
            return store.FindAll(match);
        }

        //?? 매칭되는 타입 한개 찾기
        public T Get(Predicate<T> match)
        {
            return store.Find(match);
        }

    }
}
