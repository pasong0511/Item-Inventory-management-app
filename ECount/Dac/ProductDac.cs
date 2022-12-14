using ECount.Enum;
using ECount.Model;
using ECount.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECount.Dac
{
    public class ProductDac
    {
        //Name, ProductType 저장
        //static IStore<ProductModel> store = new InMemoryStore<ProductModel>();                //메모리 저장
        static IStore<ProductModel> store = InFileStore<ProductModel>.Get("product.dat");       //파일 저장

        //프로덕트 모델 메모리 저장
        static public void Create(string name, ProductType type)
        {
            //이름과 타입을 넘겨줘서 생성된 ProductModel를 리스트에 담는다.
            store.Save(new ProductModel(name, type));
        }

        //프로덕트 모델 겟
        static public List<ProductModel> Get()
        {
            return store.GetAll();
        }

        //이름으로 프로덕트 모델겟
        static public ProductModel Get(string name)
        {
            //람다식 사용
            return store.Get(x => x.Name == name);
        }
    }
}
