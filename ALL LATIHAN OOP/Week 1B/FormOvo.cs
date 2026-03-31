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
        //global variable
        OvoApp myAccount;
        OvoApp selectedAccount;
        BindingList<OvoApp> ovoAccounts = new BindingList<OvoApp>();

        public FormOvo()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                myAccount = new OvoApp();

                string nama = textBoxName.Text;
                int.TryParse(textBoxPhoneNumber.Text, out int noTelpon);
                int.TryParse(textBoxPIN.Text, out int pin);
                string ovoID = textBoxOvoID.Text;

                myAccount.Register(nama, noTelpon, pin, ovoID);
                ovoAccounts.Add(myAccount);


                listBoxData.Items.Clear();
                listBoxData.Items.AddRange(myAccount.DisplayData().Split('\n'));

                comboBoxSelectedAccounts.DataSource = null;
                comboBoxSelectedAccounts.DataSource = ovoAccounts;
                comboBoxSelectedAccounts.DisplayMember = "Nama";
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

                selectedAccount = (OvoApp)comboBoxSelectedAccounts.SelectedItem;
                selectedAccount.TopUp(nominal);

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

                selectedAccount = (OvoApp)comboBoxSelectedAccounts.SelectedItem;
                selectedAccount.Buy(nominal);

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
            foreach (OvoApp account in ovoAccounts)
            {
                listBoxData.Items.AddRange(account.DisplayData().Split('\n'));
                listBoxData.Items.Add("--------------------------------------------------");
            }
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
