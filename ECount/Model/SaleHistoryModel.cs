using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECount.Model
{
    [Serializable]
    //판매 이력 생성 클래스
    public class SaleHistoryModel
    {

        public ProductModel Product;
        public int Quantity;    //양
        public DateTime Date;   //판매일자

        //생성자
        public SaleHistoryModel(ProductModel product, int quantity, DateTime date)
        {
            this.Product = product;
            this.Quantity = quantity;
            this.Date = date;
        }

        //문자열 변환
        public override string ToString()
        {
            return $"판매 ({this.Date.ToString("yy/MM/dd")}  {this.Product.Name}: {this.Quantity})";
        }
    }
}
