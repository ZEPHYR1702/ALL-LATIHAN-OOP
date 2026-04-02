using System;
using System.Collections.Generic;
using System.Text;

namespace ALL_LATIHAN_OOP.Week_4B
{
    public class Breads
    {
        private string name;
        private long price;
        private int stock;

        #region Constructor
        public Breads(string name, long price)
        {
            Name = name;
            Price = price;
            Stock = 0;
        }
        #endregion

        #region Properties
        public string Name
        {
            get => name;
            set 
            { 
                if (value == "")
                {
                    throw new Exception("Name cannot be empty.");
                }
                else
                {
                    name = value;
                }
            }
        }

        public long Price
        {
            get => price;
            set
            {
                if (value % 10_000 == 0 && value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Price must be a multiple of 10,000.");
                }
            }
        }

        public int Stock
        {
            get => stock;
            private set
            {
                if (value >= 0)
                {
                    stock = value;
                }
                else
                {
                    throw new Exception("Stock cannot be negative.");
                }
            }
        }
        #endregion

        #region Methods
        public void AddBread(int stockUp)
        {
            if (stockUp < 10 || stockUp > 50)
            {
                throw new Exception("Stock up must be between 10 and 50.");
            }
            else
            {
                this.Stock += stockUp;
            }
        }

        public void SellBread(string paymentMethod, int quantitySell, out double diskonQuantity, out double diskonPayMethod, out double finalPrice)
        {
            double grandTotal = 0;
            diskonQuantity = 0;
            diskonPayMethod = 0;

            if (quantitySell > 5)
            {
                double diskon = 0.1;
                long hargaAwal = this.Price * quantitySell;
                double jumlahDiskon = hargaAwal * diskon;
                diskonQuantity = jumlahDiskon;
                grandTotal = hargaAwal - jumlahDiskon;
            }

            if (paymentMethod == "Credit Card")
            {
                double diskon = grandTotal * 0.2;
                diskonPayMethod = diskon;
                grandTotal -= diskon;
            }

            this.Stock -= quantitySell;

            finalPrice = grandTotal;
        }

        public string DisplayData()
        {
            string data =
                $"Name: {this.Name}" +
                $"\nPrice: {this.Price}";
            return data;
        }
        #endregion
    }
}
