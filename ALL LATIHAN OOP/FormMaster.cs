using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ALL_LATIHAN_OOP
{
    public partial class FormMaster : Form
    {
        

        public FormMaster()
        {
            InitializeComponent();

            Selector.Initialize();

            foreach (var form in Selector.formSelector)
            {
                comboBoxForm.Items.Add(form.Key);
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string selected = comboBoxForm.SelectedItem.ToString();

            if (Selector.formSelector.ContainsKey(selected))
            {
                Form formToOpen = Selector.formSelector[selected];
                formToOpen.ShowDialog();
            }
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
