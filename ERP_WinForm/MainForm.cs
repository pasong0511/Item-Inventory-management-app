using ECount;
using ECount.Enum;
using ECount.SDK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using ECount.Model;
using ECount.Dac;
using ECount.Store;

namespace ERP_WinForm
{
    public partial class MainForm : Form
    {
        //--폼 초기화--
        public MainForm()
        {
            new InFileStore<ProductModel>("product.dat");
            new InFileStore<PurchaseHistoryModel>("purchase.dat");
            new InFileStore<SaleHistoryModel>("sale.dat");
            InitializeComponent();
        }

        public void AddProducNameToCombobox(List<ProductModel> products, ComboBox comboBox)
        {
            comboBox.Items.Clear();                //구매 콤보 박스 먼저 비워두고 시작
            foreach (var product in products)
            {
                comboBox.Items.Add(product.Name);  //구매 콤보 박스에 입력 정보 추가
            }
        }
    }
}
