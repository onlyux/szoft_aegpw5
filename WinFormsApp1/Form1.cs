using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        BindingList<CountryData> countryList = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = countryList;
            countryDataBindingSource.DataSource = countryList;

            CountryData mo = new CountryData();
            mo.Name = "Magyarország";
            mo.Population = 9500000;
        }
    }
}