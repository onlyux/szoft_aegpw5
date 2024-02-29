using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HarmadikHet
{
    internal class SzamoloGomb : VillogoGomb
    {
        int szám = 1;

        public SzamoloGomb()
        {
            Width = 20;
            Height = 20;
            MouseClick += SzamoloGomb_MouseClick;
            szám = 1;
            Text = szám.ToString();
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szám++;
            if (szám == 6)
            {
                szám = 1;
            }
            Text = szám.ToString();
        }
    }
}
