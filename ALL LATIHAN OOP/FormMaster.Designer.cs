namespace ALL_LATIHAN_OOP
{
    partial class FormMaster
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
            label1 = new Label();
            comboBoxForm = new ComboBox();
            buttonEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 42);
            label1.Name = "label1";
            label1.Size = new Size(181, 22);
            label1.TabIndex = 0;
            label1.Text = "ALL LATIHAN OOP";
            // 
            // comboBoxForm
            // 
            comboBoxForm.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxForm.FormattingEnabled = true;
            comboBoxForm.Location = new Point(68, 91);
            comboBoxForm.Name = "comboBoxForm";
            comboBoxForm.Size = new Size(181, 26);
            comboBoxForm.TabIndex = 2;
            // 
            // buttonEnter
            // 
            buttonEnter.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnter.Location = new Point(68, 143);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(181, 36);
            buttonEnter.TabIndex = 3;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // FormMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 215);
            Controls.Add(buttonEnter);
            Controls.Add(comboBoxForm);
            Controls.Add(label1);
            Name = "FormMaster";
            Text = "FormMaster";
            Load += FormMaster_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxForm;
        private Button buttonEnter;
    }
}