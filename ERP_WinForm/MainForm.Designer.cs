namespace ERP_WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseCount = new System.Windows.Forms.TextBox();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saleCount = new System.Windows.Forms.TextBox();
            this.saleCombobox = new System.Windows.Forms.ComboBox();
            this.saleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saleBtn = new System.Windows.Forms.Button();
            this.sailGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.inventorycomboBox = new System.Windows.Forms.ComboBox();
            this.inventoryAllBtn = new System.Windows.Forms.Button();
            this.inventoryTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sailGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 341);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(671, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "품목";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(293, 234);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(53, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(202, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 19);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "원재료";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(130, 19);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "상품";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(74, 19);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "제품";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 21);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.purchaseCount);
            this.tabPage2.Controls.Add(this.purchaseBtn);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.purchaseDateTimePicker);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(671, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "구매";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "수량";
            // 
            // purchaseCount
            // 
            this.purchaseCount.Location = new System.Drawing.Point(406, 37);
            this.purchaseCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseCount.Name = "purchaseCount";
            this.purchaseCount.Size = new System.Drawing.Size(88, 21);
            this.purchaseCount.TabIndex = 4;
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Location = new System.Drawing.Point(520, 39);
            this.purchaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(66, 18);
            this.purchaseBtn.TabIndex = 3;
            this.purchaseBtn.Text = "구매";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 105);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(608, 188);
            this.dataGridView2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // purchaseDateTimePicker
            // 
            this.purchaseDateTimePicker.Location = new System.Drawing.Point(31, 37);
            this.purchaseDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseDateTimePicker.Name = "purchaseDateTimePicker";
            this.purchaseDateTimePicker.Size = new System.Drawing.Size(178, 21);
            this.purchaseDateTimePicker.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.saleCount);
            this.tabPage3.Controls.Add(this.saleCombobox);
            this.tabPage3.Controls.Add(this.saleDateTimePicker);
            this.tabPage3.Controls.Add(this.saleBtn);
            this.tabPage3.Controls.Add(this.sailGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(671, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "판매";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // saleCount
            // 
            this.saleCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.saleCount.Location = new System.Drawing.Point(423, 48);
            this.saleCount.Name = "saleCount";
            this.saleCount.Size = new System.Drawing.Size(100, 21);
            this.saleCount.TabIndex = 4;
            // 
            // saleCombobox
            // 
            this.saleCombobox.FormattingEnabled = true;
            this.saleCombobox.Location = new System.Drawing.Point(261, 49);
            this.saleCombobox.Name = "saleCombobox";
            this.saleCombobox.Size = new System.Drawing.Size(121, 20);
            this.saleCombobox.TabIndex = 3;
            // 
            // saleDateTimePicker
            // 
            this.saleDateTimePicker.Location = new System.Drawing.Point(33, 49);
            this.saleDateTimePicker.Name = "saleDateTimePicker";
            this.saleDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.saleDateTimePicker.TabIndex = 2;
            // 
            // saleBtn
            // 
            this.saleBtn.Location = new System.Drawing.Point(560, 46);
            this.saleBtn.Name = "saleBtn";
            this.saleBtn.Size = new System.Drawing.Size(75, 23);
            this.saleBtn.TabIndex = 1;
            this.saleBtn.Text = "판매";
            this.saleBtn.UseVisualStyleBackColor = true;
            this.saleBtn.Click += new System.EventHandler(this.saleBtn_Click);
            // 
            // sailGridView
            // 
            this.sailGridView.AllowUserToAddRows = false;
            this.sailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sailGridView.Location = new System.Drawing.Point(33, 108);
            this.sailGridView.Name = "sailGridView";
            this.sailGridView.RowTemplate.Height = 23;
            this.sailGridView.Size = new System.Drawing.Size(612, 186);
            this.sailGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.inventorycomboBox);
            this.tabPage4.Controls.Add(this.inventoryAllBtn);
            this.tabPage4.Controls.Add(this.inventoryTimePicker);
            this.tabPage4.Controls.Add(this.inventoryGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(671, 315);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "재고";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "날짜조회";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inventorycomboBox
            // 
            this.inventorycomboBox.FormattingEnabled = true;
            this.inventorycomboBox.Location = new System.Drawing.Point(268, 46);
            this.inventorycomboBox.Name = "inventorycomboBox";
            this.inventorycomboBox.Size = new System.Drawing.Size(121, 20);
            this.inventorycomboBox.TabIndex = 3;
            // 
            // inventoryAllBtn
            // 
            this.inventoryAllBtn.Location = new System.Drawing.Point(431, 43);
            this.inventoryAllBtn.Name = "inventoryAllBtn";
            this.inventoryAllBtn.Size = new System.Drawing.Size(89, 23);
            this.inventoryAllBtn.TabIndex = 2;
            this.inventoryAllBtn.Text = "전체조회";
            this.inventoryAllBtn.UseVisualStyleBackColor = true;
            this.inventoryAllBtn.Click += new System.EventHandler(this.inventoryAllBtn_Click);
            // 
            // inventoryTimePicker
            // 
            this.inventoryTimePicker.Location = new System.Drawing.Point(43, 46);
            this.inventoryTimePicker.Name = "inventoryTimePicker";
            this.inventoryTimePicker.Size = new System.Drawing.Size(200, 21);
            this.inventoryTimePicker.TabIndex = 1;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AllowUserToAddRows = false;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(43, 92);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.RowTemplate.Height = 23;
            this.inventoryGridView.Size = new System.Drawing.Size(580, 199);
            this.inventoryGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sailGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox purchaseCount;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saleCount;
        private System.Windows.Forms.ComboBox saleCombobox;
        private System.Windows.Forms.DateTimePicker saleDateTimePicker;
        private System.Windows.Forms.Button saleBtn;
        private System.Windows.Forms.DataGridView sailGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox inventorycomboBox;
        private System.Windows.Forms.Button inventoryAllBtn;
        private System.Windows.Forms.DateTimePicker inventoryTimePicker;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button button2;
    }
}

