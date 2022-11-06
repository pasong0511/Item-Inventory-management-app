using ECount.Enum;
using ECount.Model;
using ECount.SDK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ERP_WinForm
{
    public partial class MainForm : Form
    {
        DataTable productTable;

        //테이블에 프로덕트 정보 렌더링
        private void Form1_Load(object sender, EventArgs e)
        {
            //품목
            this.productTable = new DataTable();
            this.productTable.Columns.Add("품목명", typeof(string));
            this.productTable.Columns.Add("구분", typeof(ProductType));
            EventSDK.RegisterEventHandler("addProduct", this.updateProdutViewTable);
            //품목에 상품 정보 추가
            dataGridView1.DataSource = productTable;

            //구매
            this.purcharseTable = new DataTable();
            this.purcharseTable.Columns.Add("품목명", typeof(string));
            this.purcharseTable.Columns.Add("구분", typeof(ProductType));
            this.purcharseTable.Columns.Add("수량", typeof(int));
            this.purcharseTable.Columns.Add("날짜", typeof(DateTime));
            this.LoadPurchase();
            dataGridView2.DataSource = purcharseTable;

            //판매
            this.saleTable = new DataTable();
            this.saleTable.Columns.Add("품목명", typeof(string));
            this.saleTable.Columns.Add("구분", typeof(ProductType));
            this.saleTable.Columns.Add("수량", typeof(int));
            this.saleTable.Columns.Add("날짜", typeof(DateTime));
            this.LoadSale();
            sailGridView.DataSource = saleTable;

            //재고
            this.InventoryTable = new DataTable();
            this.InventoryTable.Columns.Add("품목명", typeof(string));
            this.InventoryTable.Columns.Add("구분", typeof(ProductType));
            this.InventoryTable.Columns.Add("수량", typeof(int));
            this.LoadInventory();
            inventoryGridView.DataSource = InventoryTable;

        }

        //제품 등록의 뷰 테이블 업데이트
        private void updateProdutViewTable(string name, object payload)
        {
            var products = ProductSDK.Get();        //프로덕트 전체 정보 가져오기
            AddProducToViewTable(products);         //뷰 테이블 렌더링
        }

        public void AddProducToViewTable(List<ProductModel>  products)
        {
            productTable.Rows.Clear();
            foreach (var product in products)
            {
                productTable.Rows.Add(product.Name, product.Type);      //이름 타입 출력
            }
        }


        //등록 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            
            var productName = textBox1.Text;    //입력 텍스트 빼오기

            ProductType type;   //프로덕트 타입 선언??
            if (radioButton1.Checked)
            {
                type = ProductType.RawMaterial;     //타입 재료 지정
            }
            else if (radioButton2.Checked)
            {
                type = ProductType.Product;         //타입 제품 지정
            }
            else
            {
                type = ProductType.Goods;           //타입 상품 지정
            }

            ProductSDK.Create(productName, type);   //프로덕트 SDK에게 제품 등록 넘기기
            EventSDK.EventEmit("addProduct");       //이벤트 실행 트리거
        }
    }
}
