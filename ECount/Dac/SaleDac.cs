using ECount.Model;
using ECount.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECount.Dac
{
    class SaleDac
    {
        //ProductModel Produc, Quantity, DateTime을 리스트에 넣어서 메모리에 저장하는 store 객체 하나 생성
        static IStore<SaleHistoryModel> store = new InMemoryStore<SaleHistoryModel>();

        //스토어에 저장
        static public void Create(ProductModel product, int quantity, DateTime date)
        {
            store.Save(new SaleHistoryModel(product, quantity, date));
        }

        //날짜로 구분해서 날짜에 매칭되는 스토어에 있는 전체 PurchaseHistoryModel가져오기
        static public List<SaleHistoryModel> GetHistory(DateTime date)
        {
            return store.GetAll(x => x.Date.Date <= date.Date);
        }
    }
}
