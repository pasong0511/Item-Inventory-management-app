using ECount;
using ECount.SDK;
using System;
using System.Data;
using System.Windows.Forms;

namespace ERP_WinForm
{
    public partial class MainForm : Form
    {
        DataTable saleTable;

        private void LoadSale()
        {
            saleTable.Rows.Clear();

            var sails = SaleSDK.GetHistory();
            foreach (var sail in sails)
            {
                saleTable.Rows.Add(sail.Product.Name, sail.Product.Type, sail.Quantity, sail.Date);
            }

            ECount.SDK.EventSDK.RegisterEventHandler("addProduct", this.updateSaleProduct);
        }

        private void updateSaleProduct(string name, object payload)
        {
            var products = ProductSDK.Get();        //프로덕트 전체 정보 가져오기
            AddProducNameToCombobox(products, saleCombobox);
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            var saleName = saleCombobox.Text;                       //판매 상품 이름
            var saleQuantity = Convert.ToInt32(saleCount.Text);     //판매 개수
            var saleDate = saleDateTimePicker.Value;                //판매 날짜

            SaleSDK.Create(saleName, saleQuantity, saleDate);
            this.LoadSale();
        }
    }
}
