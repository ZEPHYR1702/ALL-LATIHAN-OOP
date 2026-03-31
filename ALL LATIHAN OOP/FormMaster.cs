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
        Dictionary<string, List<string>> selector = new Dictionary<string, List<string>>()
        {
            {"WEEK 1B", new List<string> {"FormOvo" } },
            {"WEEK 2B", new List<string> {"FormFraction", "FormTimeApplication" } }
        };

        public FormMaster()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            foreach (var key in selector.Keys)
            {
                comboBoxWeek.Items.Add(key);
            }
        }

        private void comboBoxWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxForm.Items.Clear();

            string selectedWeek = comboBoxWeek.SelectedItem.ToString();
            List<string> forms = selector[selectedWeek];

        }
    }
}
