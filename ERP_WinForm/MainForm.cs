using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECount;
using ECount.Enum;
using ECount.SDK;

namespace ERP_WinForm
{
    public partial class MainForm : Form
    {
        DataTable productTable;
        DataTable purcharseTable;
        DataTable saleTable;
        DataTable InventoryTable;

        //폼 초기화
        public MainForm()
        {
            InitializeComponent();
        }

        //품목이벤트
        //품목에 등록 클릭 -> ProductSDK에게 넘겨서 생성시키기
        private void button1_Click(object sender, EventArgs e)
        {
            var productName = textBox1.Text;    //입력 텍스트 빼오기

            ProductType type;   //프로덕트 타입 선언??
            if (radioButton1.Checked) {
                type = ProductType.RawMaterial;     //타입 재료 지정
            } else if (radioButton2.Checked) {
                type = ProductType.Product;         //타입 제품 지정
            } else {
                type = ProductType.Goods;           //타입 상품 지정
            }

            ProductSDK.Create(productName, type);   //프로덕트 SDK에게 넘기기
            this.LoadProduct();
        }

        //테이블에 프로덕트 정보 렌더링
        private void Form1_Load(object sender, EventArgs e)
        {
            //품목
            this.productTable = new DataTable();
            this.productTable.Columns.Add("품목명", typeof(string));
            this.productTable.Columns.Add("구분", typeof(ProductType));
            this.LoadProduct(); //그려질때마다 구매 정보에도 이벤트 추가
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
            // this.InventoryTable.Columns.Add("날짜", typeof(DateTime));
            this.LoadInventory();
            inventoryGridView.DataSource = InventoryTable;

        }

        //---구매 이벤트----
        //콤보 박스에 프로덕트 정보 로드시키기
        private void LoadProduct()
        {
            //품목
            productTable.Rows.Clear();
            var products = ProductSDK.Get();        //프로덕트 전체 정보 가져오기
            foreach (var product in products) {
                productTable.Rows.Add(product.Name, product.Type);      //이름 타입 출력
            }

            //구매
            comboBox1.Items.Clear();                //구매 콤보 박스 먼저 비워두고 시작
            foreach (var product in products) {
                comboBox1.Items.Add(product.Name);  //구매 콤보 박스에 입력 정보 추가
            }

            //조회
            saleCombobox.Items.Clear();                //판매 콤보 박스 먼저 비워두고 시작
            foreach (var product in products)
            {
                saleCombobox.Items.Add(product.Name);  //판매 콤보 박스에 입력 정보 추가
            }

            //재고
            inventorycomboBox.Items.Clear();                //판매 콤보 박스 먼저 비워두고 시작
            foreach (var product in products)
            {
                inventorycomboBox.Items.Add(product.Name);  //판매 콤보 박스에 입력 정보 추가
            }
        }

        private void LoadPurchase() {
            purcharseTable.Rows.Clear();

            var purchases = PurchaseSDK.GetHistory();
            foreach(var purchase in purchases)
            {
                purcharseTable.Rows.Add(purchase.Product.Name, purchase.Product.Type, purchase.Quantity, purchase.Date);
            }
        }

        private void LoadSale()
        {
            saleTable.Rows.Clear();

            var sails = SaleSDK.GetHistory();
            foreach (var sail in sails)
            {
                saleTable.Rows.Add(sail.Product.Name, sail.Product.Type, sail.Quantity, sail.Date);
            }
        }

        private void LoadInventory()
        {
            InventoryTable.Rows.Clear();

            var inventorys = InventorySDK.GetStatus();

            foreach (KeyValuePair<ECount.Model.ProductModel, int> item in inventorys)
            {
                InventoryTable.Rows.Add(item.Key.Name, item.Key.Type, item.Value);
            }
        }

        //구매버튼을 클릭한 경우
        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            var purchaseName = comboBox1.Text;                          //구매 상품 이름
            var purchaseQuantity = Convert.ToInt32(purchaseCount.Text); //구매 개수
            var purchaseDate = purchaseDateTimePicker.Value;            //구매 날짜

            PurchaseSDK.Create(purchaseName, purchaseQuantity, purchaseDate);
            this.LoadPurchase();
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            var saleName = saleCombobox.Text;                       //판매 상품 이름
            var saleQuantity = Convert.ToInt32(saleCount.Text);     //판매 개수
            var saleDate = saleDateTimePicker.Value;                //판매 날짜

            SaleSDK.Create(saleName, saleQuantity, saleDate);
            this.LoadSale();
        }

        private void inventoryAllBtn_Click(object sender, EventArgs e)
        {
            this.LoadInventory();
        }
    }
}
