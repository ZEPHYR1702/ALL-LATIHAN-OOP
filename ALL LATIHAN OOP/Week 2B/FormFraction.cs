using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ALL_LATIHAN_OOP.Week_2B
{
    public partial class FormFraction : Form
    {
        public FormFraction()
        {
            InitializeComponent();
        }

        private void FormFraction_Load(object sender, EventArgs e)
        {
            textBoxFrac1Denom.Text = "0";
            textBoxFrac2Denom.Text = "0";
            textBoxFrac1Num.Text = "0";
            textBoxFrac2Num.Text = "0";
        }

        private void buttonKali_Click(object sender, EventArgs e)
        {
            try
            {
                FractionalNumber frac1 = new FractionalNumber();
                frac1.Numerator = int.Parse(textBoxFrac1Num.Text);
                frac1.Denominator = int.Parse(textBoxFrac1Denom.Text);

                FractionalNumber frac2 = new FractionalNumber();
                frac2.Numerator = int.Parse(textBoxFrac2Num.Text);
                frac2.Denominator = int.Parse(textBoxFrac2Denom.Text);

                FractionalNumber result = frac1.Multiply(frac2);

                listBoxOutput.Items.Clear();
                listBoxOutput.Items.Add($"{frac1} * {frac2} = {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonBagi_Click(object sender, EventArgs e)
        {
            try
            {
                FractionalNumber frac1 = new FractionalNumber();
                frac1.Numerator = int.Parse(textBoxFrac1Num.Text);
                frac1.Denominator = int.Parse(textBoxFrac1Denom.Text);

                FractionalNumber frac2 = new FractionalNumber();
                frac2.Numerator = int.Parse(textBoxFrac2Num.Text);
                frac2.Denominator = int.Parse(textBoxFrac2Denom.Text);

                FractionalNumber result = frac1.Divide(frac2);

                listBoxOutput.Items.Clear();
                listBoxOutput.Items.Add($"{frac1} / {frac2} = {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonPenjumlahan_Click(object sender, EventArgs e)
        {
            try
            {
                FractionalNumber frac1 = new FractionalNumber();
                frac1.Numerator = int.Parse(textBoxFrac1Num.Text);
                frac1.Denominator = int.Parse(textBoxFrac1Denom.Text);

                FractionalNumber frac2 = new FractionalNumber();
                frac2.Numerator = int.Parse(textBoxFrac2Num.Text);
                frac2.Denominator = int.Parse(textBoxFrac2Denom.Text);

                FractionalNumber result = frac1.Add(frac2);

                listBoxOutput.Items.Clear();
                listBoxOutput.Items.Add($"{frac1} + {frac2} = {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonPengurangan_Click(object sender, EventArgs e)
        {
            try
            {
                FractionalNumber frac1 = new FractionalNumber();
                frac1.Numerator = int.Parse(textBoxFrac1Num.Text);
                frac1.Denominator = int.Parse(textBoxFrac1Denom.Text);

                FractionalNumber frac2 = new FractionalNumber();
                frac2.Numerator = int.Parse(textBoxFrac2Num.Text);
                frac2.Denominator = int.Parse(textBoxFrac2Denom.Text);

                FractionalNumber result = frac1.Subtrack(frac2);

                listBoxOutput.Items.Clear();
                listBoxOutput.Items.Add($"{frac1} - {frac2} = {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
