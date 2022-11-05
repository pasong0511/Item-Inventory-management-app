using ECount;
using ECount.Dac;
using ECount.Enum;
using ECount.Model;
using ECount.SDK;
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
            Console.WriteLine("--등록정보--");
            ProductSDK.Create("바나나", ProductType.RawMaterial);   //프로덕트 SDK에게 넘기기
            ProductSDK.Create("고구마", ProductType.RawMaterial);
            ProductSDK.Create("감자", ProductType.RawMaterial);
            ProductSDK.Create("옥수수", ProductType.RawMaterial);

            var products = ProductSDK.Get();        //프로덕트 전체 정보 가져오기
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} {product.Type}");      //이름 타입 출력
            }

            Console.WriteLine("--구매정보--");

            PurchaseSDK.Create("바나나", 100, new DateTime(2022, 10, 1));
            PurchaseSDK.Create("감자", 100, new DateTime(2022, 10, 1));

            var purchases = PurchaseSDK.GetHistory();
            foreach (var purchase in purchases)
            {
                Console.WriteLine($"{purchase.Product.Name} {purchase.Product.Type} {purchase.Quantity} {purchase.Date}");
            }

            Console.WriteLine("--판매정보--");
            SaleSDK.Create("바나나", 10, new DateTime(2022, 10, 1));
            SaleSDK.Create("옥수수", 10, new DateTime(2022, 10, 1));

            var sails = SaleSDK.GetHistory();
            foreach (var sail in sails)
            {
                Console.WriteLine($"{sail.Product.Name} {sail.Product.Type} {sail.Quantity} {sail.Date}");
            }
        }
    }
}
