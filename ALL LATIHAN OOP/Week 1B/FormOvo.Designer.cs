namespace FormOvoSimpleApplication
{
    partial class FormOvo
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
            groupBoxTopUp = new GroupBox();
            numericUpDownNominalTopUp = new NumericUpDown();
            buttonTopUp = new Button();
            label7 = new Label();
            comboBoxItems = new ComboBox();
            label6 = new Label();
            buttonBuy = new Button();
            groupBoxBuy = new GroupBox();
            numericUpDownPrice = new NumericUpDown();
            label5 = new Label();
            buttonExit = new Button();
            buttonClearData = new Button();
            buttonDisplayData = new Button();
            listBoxData = new ListBox();
            buttonRegister = new Button();
            textBoxOvoID = new TextBox();
            label4 = new Label();
            textBoxPIN = new TextBox();
            label3 = new Label();
            textBoxPhoneNumber = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            groupBoxRegisterAccount = new GroupBox();
            label1 = new Label();
            groupBoxDisplayData = new GroupBox();
            groupBoxTopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNominalTopUp).BeginInit();
            groupBoxBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            groupBoxRegisterAccount.SuspendLayout();
            groupBoxDisplayData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTopUp
            // 
            groupBoxTopUp.Controls.Add(numericUpDownNominalTopUp);
            groupBoxTopUp.Controls.Add(buttonTopUp);
            groupBoxTopUp.Controls.Add(label7);
            groupBoxTopUp.Location = new Point(18, 290);
            groupBoxTopUp.Margin = new Padding(3, 4, 3, 4);
            groupBoxTopUp.Name = "groupBoxTopUp";
            groupBoxTopUp.Padding = new Padding(3, 4, 3, 4);
            groupBoxTopUp.Size = new Size(380, 161);
            groupBoxTopUp.TabIndex = 22;
            groupBoxTopUp.TabStop = false;
            groupBoxTopUp.Text = "Top Up";
            // 
            // numericUpDownNominalTopUp
            // 
            numericUpDownNominalTopUp.Location = new Point(128, 47);
            numericUpDownNominalTopUp.Name = "numericUpDownNominalTopUp";
            numericUpDownNominalTopUp.Size = new Size(204, 23);
            numericUpDownNominalTopUp.TabIndex = 9;
            // 
            // buttonTopUp
            // 
            buttonTopUp.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTopUp.Location = new Point(128, 88);
            buttonTopUp.Margin = new Padding(3, 4, 3, 4);
            buttonTopUp.Name = "buttonTopUp";
            buttonTopUp.Size = new Size(105, 32);
            buttonTopUp.TabIndex = 8;
            buttonTopUp.Text = "TOP UP";
            buttonTopUp.UseVisualStyleBackColor = true;
            buttonTopUp.Click += buttonTopUp_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 49);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 2;
            label7.Text = "Nominal Top Up :";
            // 
            // comboBoxItems
            // 
            comboBoxItems.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Items.AddRange(new object[] { "Electricity Voucher", "Internet Voucher" });
            comboBoxItems.Location = new Point(151, 32);
            comboBoxItems.Margin = new Padding(3, 4, 3, 4);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(193, 23);
            comboBoxItems.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 34);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 9;
            label6.Text = "Items to Buy :";
            // 
            // buttonBuy
            // 
            buttonBuy.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuy.Location = new Point(151, 111);
            buttonBuy.Margin = new Padding(3, 4, 3, 4);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(105, 32);
            buttonBuy.TabIndex = 8;
            buttonBuy.Text = "BUY";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // groupBoxBuy
            // 
            groupBoxBuy.Controls.Add(numericUpDownPrice);
            groupBoxBuy.Controls.Add(comboBoxItems);
            groupBoxBuy.Controls.Add(label6);
            groupBoxBuy.Controls.Add(buttonBuy);
            groupBoxBuy.Controls.Add(label5);
            groupBoxBuy.Location = new Point(407, 290);
            groupBoxBuy.Margin = new Padding(3, 4, 3, 4);
            groupBoxBuy.Name = "groupBoxBuy";
            groupBoxBuy.Padding = new Padding(3, 4, 3, 4);
            groupBoxBuy.Size = new Size(474, 161);
            groupBoxBuy.TabIndex = 23;
            groupBoxBuy.TabStop = false;
            groupBoxBuy.Text = "Buy";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(151, 76);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 76);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 2;
            label5.Text = "Price :";
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(775, 458);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(105, 32);
            buttonExit.TabIndex = 24;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonClearData
            // 
            buttonClearData.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClearData.Location = new Point(166, 232);
            buttonClearData.Margin = new Padding(3, 4, 3, 4);
            buttonClearData.Name = "buttonClearData";
            buttonClearData.Size = new Size(137, 32);
            buttonClearData.TabIndex = 10;
            buttonClearData.Text = "CLEAR DATA";
            buttonClearData.UseVisualStyleBackColor = true;
            buttonClearData.Click += buttonClearData_Click;
            // 
            // buttonDisplayData
            // 
            buttonDisplayData.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDisplayData.Location = new Point(23, 233);
            buttonDisplayData.Margin = new Padding(3, 4, 3, 4);
            buttonDisplayData.Name = "buttonDisplayData";
            buttonDisplayData.Size = new Size(137, 32);
            buttonDisplayData.TabIndex = 9;
            buttonDisplayData.Text = "DISPLAY DATA";
            buttonDisplayData.UseVisualStyleBackColor = true;
            buttonDisplayData.Click += buttonDisplayData_Click;
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.Location = new Point(23, 26);
            listBoxData.Margin = new Padding(3, 4, 3, 4);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(440, 199);
            listBoxData.TabIndex = 0;
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.Location = new Point(128, 212);
            buttonRegister.Margin = new Padding(3, 4, 3, 4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(105, 32);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "REGISTER";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxOvoID
            // 
            textBoxOvoID.Location = new Point(128, 169);
            textBoxOvoID.Margin = new Padding(3, 4, 3, 4);
            textBoxOvoID.Name = "textBoxOvoID";
            textBoxOvoID.Size = new Size(207, 23);
            textBoxOvoID.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 172);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Ovo ID :";
            // 
            // textBoxPIN
            // 
            textBoxPIN.Location = new Point(128, 127);
            textBoxPIN.Margin = new Padding(3, 4, 3, 4);
            textBoxPIN.Name = "textBoxPIN";
            textBoxPIN.PasswordChar = '*';
            textBoxPIN.Size = new Size(207, 23);
            textBoxPIN.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 130);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "PIN :";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(128, 84);
            textBoxPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(207, 23);
            textBoxPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 88);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone Number :";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(128, 44);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(207, 23);
            textBoxName.TabIndex = 1;
            // 
            // groupBoxRegisterAccount
            // 
            groupBoxRegisterAccount.Controls.Add(buttonRegister);
            groupBoxRegisterAccount.Controls.Add(textBoxOvoID);
            groupBoxRegisterAccount.Controls.Add(label4);
            groupBoxRegisterAccount.Controls.Add(textBoxPIN);
            groupBoxRegisterAccount.Controls.Add(label3);
            groupBoxRegisterAccount.Controls.Add(textBoxPhoneNumber);
            groupBoxRegisterAccount.Controls.Add(label2);
            groupBoxRegisterAccount.Controls.Add(textBoxName);
            groupBoxRegisterAccount.Controls.Add(label1);
            groupBoxRegisterAccount.Location = new Point(18, 10);
            groupBoxRegisterAccount.Margin = new Padding(3, 4, 3, 4);
            groupBoxRegisterAccount.Name = "groupBoxRegisterAccount";
            groupBoxRegisterAccount.Padding = new Padding(3, 4, 3, 4);
            groupBoxRegisterAccount.Size = new Size(380, 272);
            groupBoxRegisterAccount.TabIndex = 20;
            groupBoxRegisterAccount.TabStop = false;
            groupBoxRegisterAccount.Text = "Register Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 45);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // groupBoxDisplayData
            // 
            groupBoxDisplayData.Controls.Add(buttonClearData);
            groupBoxDisplayData.Controls.Add(buttonDisplayData);
            groupBoxDisplayData.Controls.Add(listBoxData);
            groupBoxDisplayData.Location = new Point(407, 10);
            groupBoxDisplayData.Margin = new Padding(3, 4, 3, 4);
            groupBoxDisplayData.Name = "groupBoxDisplayData";
            groupBoxDisplayData.Padding = new Padding(3, 4, 3, 4);
            groupBoxDisplayData.Size = new Size(474, 272);
            groupBoxDisplayData.TabIndex = 21;
            groupBoxDisplayData.TabStop = false;
            groupBoxDisplayData.Text = "Display Data";
            // 
            // FormOvo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 502);
            Controls.Add(groupBoxTopUp);
            Controls.Add(groupBoxBuy);
            Controls.Add(buttonExit);
            Controls.Add(groupBoxRegisterAccount);
            Controls.Add(groupBoxDisplayData);
            Margin = new Padding(2);
            Name = "FormOvo";
            Text = "Ovo Simple Application";
            groupBoxTopUp.ResumeLayout(false);
            groupBoxTopUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNominalTopUp).EndInit();
            groupBoxBuy.ResumeLayout(false);
            groupBoxBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            groupBoxRegisterAccount.ResumeLayout(false);
            groupBoxRegisterAccount.PerformLayout();
            groupBoxDisplayData.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTopUp;
        private System.Windows.Forms.Button buttonTopUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.GroupBox groupBoxBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Button buttonDisplayData;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxOvoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxRegisterAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDisplayData;
        private NumericUpDown numericUpDownNominalTopUp;
        private NumericUpDown numericUpDownPrice;
    }
}

