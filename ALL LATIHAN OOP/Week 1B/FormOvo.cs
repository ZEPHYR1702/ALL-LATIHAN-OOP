using ALL_LATIHAN_OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOvoSimpleApplication
{
    public partial class FormOvo : Form
    {
        OvoApp myAccount = new OvoApp();
        public FormOvo()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = textBoxName.Text;
                int.TryParse(textBoxPhoneNumber.Text, out int noTelpon);
                int.TryParse(textBoxPIN.Text, out int pin);
                string ovoID = textBoxOvoID.Text;

                myAccount.Register(nama, noTelpon, pin, ovoID);

                listBoxData.Items.Clear();
                listBoxData.Items.Add($"{myAccount.Nama} telah berhasil dibuat.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            try
            {
                int nominal = int.Parse(numericUpDownNominalTopUp.Value.ToString());

                myAccount.TopUp(nominal);

                listBoxData.Items.Clear();
                listBoxData.Items.Add($"Top Up sebesar {nominal} berhasil. \nSaldo OVO Cash: {myAccount.OvoCash}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                int nominal = int.Parse(numericUpDownPrice.Value.ToString());
                string kategori = comboBoxItems.Text;

                myAccount.Buy(nominal);

                listBoxData.Items.Clear();
                listBoxData.Items.Add($"Pembelian {kategori} sebesar {nominal} berhasil. \nSaldo OVO Cash: {myAccount.OvoCash}, OVO Points: {myAccount.OvoPoints}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDisplayData_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            listBoxData.Items.Add($"Nama: {myAccount.Nama}");
            listBoxData.Items.Add($"Nomor Telepon: {myAccount.NomorTelpon}");
            listBoxData.Items.Add($"OVO ID: {myAccount.OvoID}");
            listBoxData.Items.Add($"Saldo OVO Cash: {myAccount.OvoCash}");
            listBoxData.Items.Add($"Saldo OVO Points: {myAccount.OvoPoints}");

        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
