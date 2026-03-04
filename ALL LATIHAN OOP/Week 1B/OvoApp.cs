using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALL_LATIHAN_OOP
{
    public class OvoApp
    {
        private string nama;
        private int ovoCash;
        private int ovoPoints;
        private int nomorTelpon;
        private string ovoID;
        private int pin;

        public string Nama { get => nama; set => nama = value; }
        public int OvoCash { get => ovoCash; set => ovoCash = value; }
        public int OvoPoints { get => ovoPoints; set => ovoPoints = value; }
        public int NomorTelpon { get => nomorTelpon; set => nomorTelpon = value; }
        public string OvoID { get => ovoID; set => ovoID = value; }
        public int Pin { get => pin; set => pin = value; }

        public void TopUp(int nominal)
        {
            OvoCash += nominal;
        }

        public void Buy(int nominal)
        {
            if (OvoCash >= nominal)
            {
                OvoCash -= nominal;
                OvoPoints += (nominal / 100);
            }
            else
            {
                //saldo tidak cukup
            }
        }

        public void Register(string nama, int noTelpon, int pin, string ovoID)
        {
            Nama = nama;
            NomorTelpon = noTelpon;
            Pin = pin;
            OvoID = ovoID;
            OvoCash = 0;
            OvoPoints = 0;
        }
    }
}