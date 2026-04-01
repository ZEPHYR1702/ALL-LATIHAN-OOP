using System;
using System.Collections.Generic;
using System.Text;

namespace ALL_LATIHAN_OOP
{
    public static class Selector
    {
        public static Dictionary<string, Form> formSelector = new Dictionary<string, Form>();

        public static void Initialize()
        {
            formSelector.Add("Form Ovo", new FormOvoSimpleApplication.FormOvo());
            formSelector.Add("Form Fraction", new Week_2B.FormFraction());
            formSelector.Add("Form Time App", new Week_2B.FormTimeApplication());
        }
    }
}
