using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mintaZH
{
    public partial class Form2 : Form
    {
        public Adatok asd = new Adatok();

        public Form2()
        {
            InitializeComponent();
            bindingSource1.DataSource = asd;
        }
    }
}
