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

        public int OvoCash { get => ovoCash; set => ovoCash = value; }
        public int OvoPoints { get => ovoPoints; set => ovoPoints = value; }

        public string Nama 
        { 
            get => nama; 
            set
            {
                if (value != "")
                {
                    nama = value;
                }
                else
                {
                    throw new Exception("Nama tidak boleh kosong");
                }
            }
        }
        
        public int NomorTelpon 
        { 
            get => nomorTelpon;
            set
            {
                if (value != 0)
                {
                    nomorTelpon = value;
                }
                else
                {
                    throw new Exception("Nomor telpon tidak boleh kosong");
                }
            }
        }
        public string OvoID 
        { 
            get => ovoID;
            set
            {
                if (value != "")
                {
                    ovoID = value;
                }
                else
                {
                    throw new Exception("Ovo ID tidak boleh kosong");
                }
            }
        }
        public int Pin 
        { 
            get => pin;
            set
            {
                if (value != 0)
                {
                    pin = value;
                }
                else
                {
                    throw new Exception("PIN tidak boleh kosong");
                }
            }
        }

        public void TopUp(int nominal)
        {
            if (nominal < 10000)
            {
                throw new Exception("Minimal top up adalah 10000");
            }
            else
            {
                OvoCash += nominal;
            }
        }

        public void Buy(int nominal)
        {
            if (OvoCash >= nominal)
            {
                if (nominal < 5000)
                {
                    throw new Exception("Minimal transaksi adalah 5000");
                }
                else
                {
                    OvoCash -= nominal;
                    OvoPoints += (nominal / 100);
                }
            }
            else
            {
                //saldo tidak cukup
                throw new Exception("Saldo anda tidak cukup");
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