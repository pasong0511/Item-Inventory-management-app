using ECount.Model;
using ECount.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECount
{
    public class InventorySDK
    {
        static public Dictionary<ProductModel, int> GetStatus()
        {
            return GetStatus(DateTime.Now);
        }

        static public Dictionary<ProductModel, int> GetStatus(DateTime date)
        {
            var products = ProductSDK.Get();
            return GetStatus(products, date);
        }

        static public Dictionary<ProductModel, int> GetStatus(List<ProductModel> products)
        {
            return GetStatus(products, DateTime.Now);
        }

        //구매 정보 넘겨서 구매 개수 누적하기
        //-> sale 구현시 sale 정보랑 함께 뺀 후에 결과값 반환 필요
        //구매 내역에서 전체 개수 누적합
        static public Dictionary<ProductModel, int> GetStatus(List<ProductModel> products, DateTime date)
        {
            var result = new Dictionary<ProductModel, int>();

            //구매 -> 개수 증가
            foreach (var product in products)
            {
                result[product] = PurchaseSDK.GetQuantity(product) - SaleSDK.GetQuantity(product);
            }
            
            return result;
        }
    }
}
