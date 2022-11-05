using ECount.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECount.Model
{
    public class ProductModel
    {
        //상품의 이름과, 프로덕트 타입 객체를 생성한다.
        public string Name;
        public ProductType Type;    //enum으로 만든 타입

        //생성자
        public ProductModel(string name, ProductType type)
        {
            this.Name = name;
            this.Type = type;
        }

        //문자열로 반환해주는 함수
        public override string ToString()
        {
            return this.Name;
        }
    }
}
