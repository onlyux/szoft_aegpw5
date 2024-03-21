using System.Security.Cryptography.X509Certificates;

namespace snake
{
    public partial class Form1 : Form
    {
        public int fejX = 100;
        public int fejY = 100;

        public int irányX = 0;
        public int irányY = 1;

        public int lépésSzámlámó = 0;

        public int hossz = 3;

        List<KígyóElem> kígyó = new List<KígyóElem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésSzámlámó++;

            fejX += irányX * KígyóElem.Méret;
            fejY += irányY * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fejY && k.Left == fejX)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KígyóElem ke = new KígyóElem();
            ke.Top = fejY;
            ke.Left = fejX;
            Controls.Add(ke);
            kígyó.Add(ke);

            if (kígyó.Count > hossz)
            {
                Controls.RemoveAt(0);
                kígyó.RemoveAt(0);
            }

            if (lépésSzámlámó % 2 == 0) ke.BackColor = Color.Green;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                irányX = 0;
                irányY = 1;
            }

            if (e.KeyCode == Keys.Up)
            {
                irányX = 0;
                irányY = -1;
            }

            if (e.KeyCode == Keys.Left)
            {
                irányX = -1;
                irányY = 0;
            }

            if (e.KeyCode == Keys.Right)
            {
                irányX = 1;
                irányY = 0;
            }


        }
    }
}