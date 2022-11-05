using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECount.Store
{
    class InMemoryStore<T>: IStore<T>
    {
        //메모리에 저장할 리스트 store 객체 생성
        List<T> store = new List<T>();

        //리스트에 저장
        public void Save(T data)
        {
            store.Add(data);
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
