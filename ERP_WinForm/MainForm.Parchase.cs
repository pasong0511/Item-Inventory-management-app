using ECount;
using ECount.SDK;
using System;
using System.Data;
using System.Windows.Forms;

namespace ERP_WinForm
{
    public partial class MainForm : Form
    {
        DataTable purcharseTable;

        private void LoadPurchase()
        {
            purcharseTable.Rows.Clear();

            var purchases = PurchaseSDK.GetHistory();
            foreach (var purchase in purchases)
            {
                purcharseTable.Rows.Add(purchase.Product.Name, purchase.Product.Type, purchase.Quantity, purchase.Date);
            }

            EventSDK.RegisterEventHandler("addProduct", this.updatePurchaseProduct);
            this.updatePurchaseProduct("", null);
        }

        private void updatePurchaseProduct(string name, object payload)
        {
            var products = ProductSDK.Get();        //프로덕트 전체 정보 가져오기
            AddProducNameToCombobox(products, PurchaseComboBox);
        }

        //구매버튼을 클릭한 경우
        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            var purchaseName = PurchaseComboBox.Text;                          //구매 상품 이름
            var purchaseQuantity = Convert.ToInt32(purchaseCount.Text); //구매 개수
            var purchaseDate = purchaseDateTimePicker.Value;            //구매 날짜

            PurchaseSDK.Create(purchaseName, purchaseQuantity, purchaseDate);
            this.LoadPurchase();
        }
    }
}
