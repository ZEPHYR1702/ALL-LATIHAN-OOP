namespace ALL_LATIHAN_OOP.Week_2B
{
    partial class FormFraction
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
            buttonKali = new Button();
            groupBox1 = new GroupBox();
            textBoxFrac2Denom = new TextBox();
            label5 = new Label();
            textBoxFrac1Denom = new TextBox();
            label6 = new Label();
            textBoxFrac2Num = new TextBox();
            textBoxFrac1Num = new TextBox();
            label7 = new Label();
            label8 = new Label();
            listBoxOutput = new ListBox();
            buttonClear = new Button();
            buttonBagi = new Button();
            buttonPengurangan = new Button();
            buttonPenjumlahan = new Button();
            label1 = new Label();
            buttonExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonKali
            // 
            buttonKali.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKali.Location = new Point(25, 108);
            buttonKali.Name = "buttonKali";
            buttonKali.Size = new Size(75, 39);
            buttonKali.TabIndex = 11;
            buttonKali.Text = "*";
            buttonKali.UseVisualStyleBackColor = true;
            buttonKali.Click += buttonKali_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxFrac2Denom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxFrac1Denom);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxFrac2Num);
            groupBox1.Controls.Add(textBoxFrac1Num);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(25, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 100);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBoxFrac2Denom
            // 
            textBoxFrac2Denom.Location = new Point(256, 64);
            textBoxFrac2Denom.Name = "textBoxFrac2Denom";
            textBoxFrac2Denom.Size = new Size(46, 23);
            textBoxFrac2Denom.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(237, 68);
            label5.Name = "label5";
            label5.Size = new Size(13, 19);
            label5.TabIndex = 17;
            label5.Text = "/";
            // 
            // textBoxFrac1Denom
            // 
            textBoxFrac1Denom.Location = new Point(185, 64);
            textBoxFrac1Denom.Name = "textBoxFrac1Denom";
            textBoxFrac1Denom.Size = new Size(46, 23);
            textBoxFrac1Denom.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(237, 32);
            label6.Name = "label6";
            label6.Size = new Size(13, 19);
            label6.TabIndex = 15;
            label6.Text = "/";
            // 
            // textBoxFrac2Num
            // 
            textBoxFrac2Num.Location = new Point(256, 28);
            textBoxFrac2Num.Name = "textBoxFrac2Num";
            textBoxFrac2Num.Size = new Size(46, 23);
            textBoxFrac2Num.TabIndex = 14;
            // 
            // textBoxFrac1Num
            // 
            textBoxFrac1Num.Location = new Point(185, 28);
            textBoxFrac1Num.Name = "textBoxFrac1Num";
            textBoxFrac1Num.Size = new Size(46, 23);
            textBoxFrac1Num.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 64);
            label7.Name = "label7";
            label7.Size = new Size(173, 19);
            label7.TabIndex = 12;
            label7.Text = "Fractional Number 2 :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 28);
            label8.Name = "label8";
            label8.Size = new Size(173, 19);
            label8.TabIndex = 11;
            label8.Text = "Fractional Number 1 :";
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(25, 170);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(327, 124);
            listBoxOutput.TabIndex = 16;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(25, 300);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 39);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonBagi
            // 
            buttonBagi.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBagi.Location = new Point(106, 108);
            buttonBagi.Name = "buttonBagi";
            buttonBagi.Size = new Size(75, 39);
            buttonBagi.TabIndex = 19;
            buttonBagi.Text = "/";
            buttonBagi.UseVisualStyleBackColor = true;
            buttonBagi.Click += buttonBagi_Click;
            // 
            // buttonPengurangan
            // 
            buttonPengurangan.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPengurangan.Location = new Point(277, 108);
            buttonPengurangan.Name = "buttonPengurangan";
            buttonPengurangan.Size = new Size(75, 39);
            buttonPengurangan.TabIndex = 20;
            buttonPengurangan.Text = "-";
            buttonPengurangan.UseVisualStyleBackColor = true;
            buttonPengurangan.Click += buttonPengurangan_Click;
            // 
            // buttonPenjumlahan
            // 
            buttonPenjumlahan.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPenjumlahan.Location = new Point(196, 108);
            buttonPenjumlahan.Name = "buttonPenjumlahan";
            buttonPenjumlahan.Size = new Size(75, 39);
            buttonPenjumlahan.TabIndex = 21;
            buttonPenjumlahan.Text = "+";
            buttonPenjumlahan.UseVisualStyleBackColor = true;
            buttonPenjumlahan.Click += buttonPenjumlahan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 150);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 22;
            label1.Text = "Result:";
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(277, 300);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 39);
            buttonExit.TabIndex = 23;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormFraction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 364);
            Controls.Add(buttonExit);
            Controls.Add(label1);
            Controls.Add(buttonPenjumlahan);
            Controls.Add(buttonPengurangan);
            Controls.Add(buttonBagi);
            Controls.Add(buttonClear);
            Controls.Add(listBoxOutput);
            Controls.Add(groupBox1);
            Controls.Add(buttonKali);
            Name = "FormFraction";
            Text = "FormFraction";
            Load += FormFraction_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKali;
        private GroupBox groupBox1;
        private TextBox textBoxFrac2Denom;
        private Label label5;
        private TextBox textBoxFrac1Denom;
        private Label label6;
        private TextBox textBoxFrac2Num;
        private TextBox textBoxFrac1Num;
        private Label label7;
        private Label label8;
        private ListBox listBoxOutput;
        private Button buttonClear;
        private Button buttonBagi;
        private Button buttonPengurangan;
        private Button buttonPenjumlahan;
        private Label label1;
        private Button buttonExit;
    }
}