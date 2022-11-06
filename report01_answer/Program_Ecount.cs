using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_app
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}



////가급적이면 구조를 형태를 나누는거를 고려해랑.
////나중에 계속..가져갈거임 ㅋㅋ
////SDK
////Service
////저장소 구조로 나누기

////UI 윈폼으로 만들기..하하하하하하하핳



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ECount;

//namespace sample_app
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var sdk = new ECount.SDK();             //이거 구현하면 된다.
//            sdk.Product.Create("밀가루", ProductType.RawMaterial);
//            var product = sdk.Product.Get("밀가루");
//            var product2 = sdk.Product.Get("밀가루111");


//            Console.WriteLine(product);
//            Console.WriteLine(product2);

//            sdk.Purchase.Create("밀가루", 100, new DateTime(2022, 10, 1));
//            sdk.Purchase.Create("밀가루", 200, new DateTime(2022, 10, 2));

//            //sdk.Purchase.Create("밀가루", 100, new DateTime(2022.10.1));    //<-- 날짜 추가


//            //sdk.Purchase.Create("초코파이", 10);
//            //sdk.Purchase.Create("나초", 10);

//            var purchases = sdk.Purchase.GetHistory();      //스타트 데이트 이런거도 넣을 수 있음..
//            foreach(var item in purchases) {
//                Console.WriteLine(item);
//            }

//            var status = sdk.Invenrory.GetStatus();
//            foreach(var item in status) {
//                Console.WriteLine(item);
//            }

//            var status2 = sdk.Invenrory.GetStatus(new DateTime(2022, 10, 1));
//            foreach (var item in status2) {
//                Console.WriteLine(item);
//            }

//            //추가사항
//            //var status = sdk.Invenrory.GetStatus(new DateTime(2022.10.1)); //이 날짜 시점에서재고현황
//            //sdk.Sale.create("밀가루", 100, 2022 / 01 / 22);




//            //sdk.Product.create("품목명", "구문(원재료, 제품, 상품)");   //이름만 있음 -> 이런 품목이 있다 등록

//            //sdk.Product.get();                     //모든 품목의 배열이 나옴
//            //sdk.Product.get("품목명");             //특정 품목 조회
//            //sdk.Product.getByType("원재료");       //구분에 따른 품목 조회

//            ////수정, 삭제는 x

//            //sdk.Purchase.purchase("품목명", 10/*수량*/);            //구매
//            //sdk.Purchase.getHistory();              //구매 내역 전체 조회

//            //sdk.inventory.getStatus();              //전체 재고 조회
//            //sdk.inventory.getStatusByProduct("품목명");

//            //sdk.Sale.sale("품목명", 10 /*수량*/);    //판매
//            //sdk.Sale.getHistory();                  //판매 내역 조회
//        }
//    }
//}



////가급적이면 구조를 형태를 나누는거를 고려해랑.
////나중에 계속..가져갈거임 ㅋㅋ
////SDK
////Service
////저장소 구조로 나누기

////UI 윈폼으로 만들기..하하하하하하하핳
