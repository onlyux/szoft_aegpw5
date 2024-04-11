using System.ComponentModel;

namespace Adatkötés

{
    public partial class Form1 : Form
    {

        BindingList<CountryData> countryList;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = countryList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("european_countries.csv");

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] s = sor.Split(",");

                CountryData country = new CountryData();
                country.Name = s[0];
                country.Population = int.Parse(s[1]);
                country.AreaInSquareKm = int.Parse(s[2]);

                countryList.Add(country);
            }

            sr.Close();
        }

        private void buttonMegnyitás_Click(object sender, EventArgs e)
        {

        }
    }
}