namespace BreadShopApplication
{
    partial class FormBread
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            comboBoxBreadVariant = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            buttonAdd = new Button();
            groupBoxAddNewVariant = new GroupBox();
            listBoxData = new ListBox();
            buttonDisplayAll = new Button();
            buttonClear = new Button();
            buttonExit = new Button();
            groupBoxData = new GroupBox();
            button1 = new Button();
            label5 = new Label();
            textBoxQuantityMade = new TextBox();
            buttonMade = new Button();
            groupBoxMadeTheBread = new GroupBox();
            button5 = new Button();
            label4 = new Label();
            textBoxQuantitySell = new TextBox();
            buttonSell = new Button();
            label6 = new Label();
            comboBoxPayment = new ComboBox();
            groupBoxSellTheBread = new GroupBox();
            groupBoxAddNewVariant.SuspendLayout();
            groupBoxData.SuspendLayout();
            groupBoxMadeTheBread.SuspendLayout();
            groupBoxSellTheBread.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 174);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 37;
            label3.Text = "Select Bread Variant :";
            // 
            // comboBoxBreadVariant
            // 
            comboBoxBreadVariant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBreadVariant.FormattingEnabled = true;
            comboBoxBreadVariant.Location = new Point(140, 174);
            comboBoxBreadVariant.Margin = new Padding(3, 4, 3, 4);
            comboBoxBreadVariant.Name = "comboBoxBreadVariant";
            comboBoxBreadVariant.Size = new Size(209, 23);
            comboBoxBreadVariant.TabIndex = 1;
            comboBoxBreadVariant.SelectedIndexChanged += comboBoxBreadVariant_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 27;
            label1.Text = "Variant Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 64);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 30;
            label2.Text = "Price :";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(128, 31);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(207, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(128, 64);
            textBoxPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(104, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(128, 98);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 32);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupBoxAddNewVariant
            // 
            groupBoxAddNewVariant.Controls.Add(buttonAdd);
            groupBoxAddNewVariant.Controls.Add(textBoxPrice);
            groupBoxAddNewVariant.Controls.Add(textBoxName);
            groupBoxAddNewVariant.Controls.Add(label2);
            groupBoxAddNewVariant.Controls.Add(label1);
            groupBoxAddNewVariant.Location = new Point(14, 11);
            groupBoxAddNewVariant.Margin = new Padding(2);
            groupBoxAddNewVariant.Name = "groupBoxAddNewVariant";
            groupBoxAddNewVariant.Padding = new Padding(2);
            groupBoxAddNewVariant.Size = new Size(365, 141);
            groupBoxAddNewVariant.TabIndex = 0;
            groupBoxAddNewVariant.TabStop = false;
            groupBoxAddNewVariant.Text = "Add New Variant";
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.Location = new Point(16, 22);
            listBoxData.Margin = new Padding(3, 4, 3, 4);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(374, 379);
            listBoxData.TabIndex = 31;
            // 
            // buttonDisplayAll
            // 
            buttonDisplayAll.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDisplayAll.Location = new Point(17, 412);
            buttonDisplayAll.Margin = new Padding(3, 4, 3, 4);
            buttonDisplayAll.Name = "buttonDisplayAll";
            buttonDisplayAll.Size = new Size(118, 32);
            buttonDisplayAll.TabIndex = 0;
            buttonDisplayAll.Text = "DISPLAY ALL";
            buttonDisplayAll.UseVisualStyleBackColor = true;
            buttonDisplayAll.Click += buttonDisplayAll_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(152, 412);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(118, 32);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(284, 412);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(105, 32);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(buttonExit);
            groupBoxData.Controls.Add(buttonClear);
            groupBoxData.Controls.Add(buttonDisplayAll);
            groupBoxData.Controls.Add(listBoxData);
            groupBoxData.Location = new Point(397, 1);
            groupBoxData.Margin = new Padding(2);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Padding = new Padding(2);
            groupBoxData.Size = new Size(408, 460);
            groupBoxData.TabIndex = 4;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Data";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(228, 403);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(105, 32);
            button1.TabIndex = 32;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 34);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 36;
            label5.Text = "Quantity :";
            // 
            // textBoxQuantityMade
            // 
            textBoxQuantityMade.Location = new Point(126, 31);
            textBoxQuantityMade.Margin = new Padding(3, 4, 3, 4);
            textBoxQuantityMade.Name = "textBoxQuantityMade";
            textBoxQuantityMade.Size = new Size(86, 23);
            textBoxQuantityMade.TabIndex = 0;
            // 
            // buttonMade
            // 
            buttonMade.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMade.Location = new Point(126, 64);
            buttonMade.Margin = new Padding(3, 4, 3, 4);
            buttonMade.Name = "buttonMade";
            buttonMade.Size = new Size(105, 32);
            buttonMade.TabIndex = 1;
            buttonMade.Text = "MADE";
            buttonMade.UseVisualStyleBackColor = true;
            buttonMade.Click += buttonMade_Click;
            // 
            // groupBoxMadeTheBread
            // 
            groupBoxMadeTheBread.Controls.Add(buttonMade);
            groupBoxMadeTheBread.Controls.Add(textBoxQuantityMade);
            groupBoxMadeTheBread.Controls.Add(label5);
            groupBoxMadeTheBread.Controls.Add(button1);
            groupBoxMadeTheBread.Location = new Point(14, 212);
            groupBoxMadeTheBread.Margin = new Padding(2);
            groupBoxMadeTheBread.Name = "groupBoxMadeTheBread";
            groupBoxMadeTheBread.Padding = new Padding(2);
            groupBoxMadeTheBread.Size = new Size(365, 104);
            groupBoxMadeTheBread.TabIndex = 2;
            groupBoxMadeTheBread.TabStop = false;
            groupBoxMadeTheBread.Text = "Made the Bread";
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(228, 403);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(105, 32);
            button5.TabIndex = 32;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 72);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 35;
            label4.Text = "Quantity :";
            // 
            // textBoxQuantitySell
            // 
            textBoxQuantitySell.Location = new Point(126, 68);
            textBoxQuantitySell.Margin = new Padding(3, 4, 3, 4);
            textBoxQuantitySell.Name = "textBoxQuantitySell";
            textBoxQuantitySell.Size = new Size(86, 23);
            textBoxQuantitySell.TabIndex = 1;
            // 
            // buttonSell
            // 
            buttonSell.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSell.Location = new Point(128, 102);
            buttonSell.Margin = new Padding(3, 4, 3, 4);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(105, 32);
            buttonSell.TabIndex = 2;
            buttonSell.Text = "SELL";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 36);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 37;
            label6.Text = "Payment Method :";
            // 
            // comboBoxPayment
            // 
            comboBoxPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPayment.FormattingEnabled = true;
            comboBoxPayment.Items.AddRange(new object[] { "Cash", "Credit Card" });
            comboBoxPayment.Location = new Point(126, 33);
            comboBoxPayment.Margin = new Padding(3, 4, 3, 4);
            comboBoxPayment.Name = "comboBoxPayment";
            comboBoxPayment.Size = new Size(107, 23);
            comboBoxPayment.TabIndex = 0;
            // 
            // groupBoxSellTheBread
            // 
            groupBoxSellTheBread.Controls.Add(comboBoxPayment);
            groupBoxSellTheBread.Controls.Add(label6);
            groupBoxSellTheBread.Controls.Add(buttonSell);
            groupBoxSellTheBread.Controls.Add(textBoxQuantitySell);
            groupBoxSellTheBread.Controls.Add(label4);
            groupBoxSellTheBread.Controls.Add(button5);
            groupBoxSellTheBread.Location = new Point(14, 321);
            groupBoxSellTheBread.Margin = new Padding(2);
            groupBoxSellTheBread.Name = "groupBoxSellTheBread";
            groupBoxSellTheBread.Padding = new Padding(2);
            groupBoxSellTheBread.Size = new Size(365, 137);
            groupBoxSellTheBread.TabIndex = 3;
            groupBoxSellTheBread.TabStop = false;
            groupBoxSellTheBread.Text = "Sell the Bread";
            // 
            // FormBread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 478);
            Controls.Add(groupBoxSellTheBread);
            Controls.Add(groupBoxMadeTheBread);
            Controls.Add(comboBoxBreadVariant);
            Controls.Add(groupBoxData);
            Controls.Add(label3);
            Controls.Add(groupBoxAddNewVariant);
            Margin = new Padding(2);
            Name = "FormBread";
            Text = "Bread Shop Application";
            Load += FormBread_Load;
            groupBoxAddNewVariant.ResumeLayout(false);
            groupBoxAddNewVariant.PerformLayout();
            groupBoxData.ResumeLayout(false);
            groupBoxMadeTheBread.ResumeLayout(false);
            groupBoxMadeTheBread.PerformLayout();
            groupBoxSellTheBread.ResumeLayout(false);
            groupBoxSellTheBread.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBreadVariant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxAddNewVariant;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuantityMade;
        private System.Windows.Forms.Button buttonMade;
        private System.Windows.Forms.GroupBox groupBoxMadeTheBread;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuantitySell;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.GroupBox groupBoxSellTheBread;
    }
}