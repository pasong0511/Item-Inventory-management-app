using ECount;
using ECount.SDK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ERP_WinForm
{
    public partial class MainForm : Form
    {
        DataTable InventoryTable;

        private void LoadInventory()
        {
            InventoryTable.Rows.Clear();

            var inventorys = InventorySDK.GetStatus();

            foreach (KeyValuePair<ECount.Model.ProductModel, int> item in inventorys)
            {
                InventoryTable.Rows.Add(item.Key.Name, item.Key.Type, item.Value);
            }

            EventSDK.RegisterEventHandler("addProduct", this.updateInventoryProduct);
            updateInventoryProduct("", null);
        }
        private void updateInventoryProduct(string name, object payload)
        {
            var products = ProductSDK.Get();        //프로덕트 전체 정보 가져오기
            AddProducNameToCombobox(products, inventorycomboBox);
        }

        private void inventoryAllBtn_Click(object sender, EventArgs e)
        {
            this.LoadInventory();
        }
    }
}
