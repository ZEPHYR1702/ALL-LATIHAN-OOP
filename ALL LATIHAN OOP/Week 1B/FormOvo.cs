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
        OvoApp myAccount;
        public FormOvo()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            myAccount = new OvoApp();

            string nama = textBoxName.Text;
            int noTelpon = int.Parse(textBoxPhoneNumber.Text);
            int pin = int.Parse(textBoxPIN.Text);
            string ovoID = textBoxOvoID.Text;

            myAccount.Register(nama, noTelpon, pin, ovoID);

            listBoxData.Items.Add($"{myAccount.Nama} telah berhasil dibuat.");
        }

        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(numericUpDownNominalTopUp.Value.ToString());

            myAccount.TopUp(nominal);

            listBoxData.Items.Add($"Top Up sebesar {nominal} berhasil. \nSaldo OVO Cash: {myAccount.OvoCash}");
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(numericUpDownPrice.Value.ToString());
            string kategori = comboBoxItems.Text;

            myAccount.Buy(nominal);

            listBoxData.Items.Add($"Pembelian {kategori} sebesar {nominal} berhasil. \nSaldo OVO Cash: {myAccount.OvoCash}, OVO Points: {myAccount.OvoPoints}");
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
