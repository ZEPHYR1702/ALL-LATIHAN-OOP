using ALL_LATIHAN_OOP.Week_4B;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadShopApplication
{
    public partial class FormBread : Form
    {
        //Global variable
        Breads addBread;
        BindingList<Breads> breadsList = new BindingList<Breads>();
        Breads selectedBread;

        public FormBread()
        {
            InitializeComponent();
        }

        private void FormBread_Load(object sender, EventArgs e)
        {
            comboBoxBreadVariant.DataSource = breadsList;
            comboBoxBreadVariant.DisplayMember = "Name";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string variantName = textBoxName.Text;
                long.TryParse(textBoxPrice.Text, out long price);

                addBread = new Breads(variantName, price);
                breadsList.Add(addBread);

                listBoxData.Items.Clear();
                listBoxData.Items.AddRange(addBread.DisplayData().Split('\n'));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void comboBoxBreadVariant_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBread = (Breads)comboBoxBreadVariant.SelectedItem!;
        }

        private void buttonMade_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(textBoxQuantityMade.Text, out int quantityMade);

                selectedBread.AddBread(quantityMade);

                listBoxData.Items.Clear();
                listBoxData.Items.Add($"Selected Bread Type: {selectedBread.Name}");
                listBoxData.Items.Add($"Quantity made: {quantityMade}");
                listBoxData.Items.Add($"Current Stock: {selectedBread.Stock}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                string paymentMethod = comboBoxPayment.SelectedItem.ToString();
                int.TryParse(textBoxQuantitySell.Text, out int quantitySell);

                selectedBread.SellBread(paymentMethod, quantitySell, out double diskonQuantity, out double diskonPayMethod, out double grandTotal);

                listBoxData.Items.Clear();
                listBoxData.Items.Add($"Selected Bread Type: {selectedBread.Name}");
                listBoxData.Items.Add($"Amount Bread Sold: {quantitySell}");
                listBoxData.Items.Add($"Discount: {diskonQuantity}");
                listBoxData.Items.Add($"Additional Discount: {diskonPayMethod}");
                listBoxData.Items.Add($"Total Price: {grandTotal}");
                listBoxData.Items.Add($"Remaining Stocks: {selectedBread.Stock}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            foreach (Breads bread in breadsList)
            {
                listBoxData.Items.AddRange(bread.DisplayData().Split('\n'));
                listBoxData.Items.Add($"-------------------------------------");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
