using ECount.Dac;
using ECount.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECount
{
    public class SaleSDK
    {
        //상품 이름, 구매 개수, 구매 시간으로 구매정보 생성
        static public void Create(string producName, int quantity, DateTime date)
        {
            //1. 상품 정보에 있는지 먼저 확인하기
            var product = ProductDac.Get(producName);

            //2. 상품이 등록되어있지 않으면 버리기
            if (product == null)
            {
                throw new Exception($"품목이 존재하지 않습니다. {producName}");
            }

            var purchase = PurchaseSDK.GetQuantity(product);
            var sale = GetQuantity(product) + quantity;

            if(purchase - sale < 0)
            {
                throw new Exception($"재고가 없는디요. {producName}");
            }
            //3. 상품이 이미 등록되어 있는 경우 구매정보 생성
            SaleDac.Create(product, quantity, date);
        }

        //구매 생성 정보 가져오기
        static public List<SaleHistoryModel> GetHistory()
        {
            return GetHistory(DateTime.Now);
        }

        //날짜로 구매 정보 가져오기
        static public List<SaleHistoryModel> GetHistory(DateTime date)
        {
            return SaleDac.GetHistory(date);
        }

        static public int GetQuantity(ProductModel product)
        {
            return GetQuantity(product, DateTime.Now);
        }

        static public int GetQuantity(ProductModel product, DateTime date)
        {
            var sales = GetHistory(date);
            var quantity = 0;
            foreach (var sale in sales)
            {
                if (sale.Product == product)
                {
                    quantity += sale.Quantity;
                }
            }
            return quantity;
        }
    }
}
