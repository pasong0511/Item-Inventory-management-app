using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECount.Model
{
    [Serializable]
    //구매이이력 생성 클래스
    public class PurchaseHistoryModel
    {

        public ProductModel Product;
        public int Quantity;    //양
        public DateTime Date;   //구매일자

        //생성자
        public PurchaseHistoryModel(ProductModel product, int quantity, DateTime date)
        {
            this.Product = product;
            this.Quantity = quantity;
            this.Date = date;
        }

        //문자열 변환
        public override string ToString()
        {
            return $"구매 ({this.Date.ToString("yy/MM/dd")}  {this.Product.Name}: {this.Quantity})";
        }
    }
}
