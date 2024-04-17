using CsvHelper;
using Microsoft.VisualBasic;
using System.CodeDom;
using System.ComponentModel;
using System.Globalization;

namespace mintaZH
{
    public partial class Form1 : Form
    {
        BindingList<Adatok> lista = new BindingList<Adatok>();

        public Form1()
        {
            InitializeComponent();
            adatokBindingSource.DataSource = lista;
            dataGridView1.DataSource = adatokBindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Adatok>();

                foreach (var item in tömb)
                {
                    lista.Add(item);
                }
                sr.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(lista);
                    sw.Close();
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (adatokBindingSource.Current is null)
            {
                return;
            }

            if (MessageBox.Show("a", "b", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                adatokBindingSource.RemoveCurrent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 asd2 = new Form2();
            if (asd2.ShowDialog() == DialogResult.OK)
            {
                adatokBindingSource.Add(asd2.asd);
            }
        }
    }
}
