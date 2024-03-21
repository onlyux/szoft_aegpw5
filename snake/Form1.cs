using System.Security.Cryptography.X509Certificates;

namespace snake
{
    public partial class Form1 : Form
    {
        public int fejX = 100;
        public int fejY = 100;

        public int ir�nyX = 0;
        public int ir�nyY = 1;

        public int l�p�sSz�ml�m� = 0;

        public int hossz = 3;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�sSz�ml�m�++;

            fejX += ir�nyX * K�gy�Elem.M�ret;
            fejY += ir�nyY * K�gy�Elem.M�ret;

            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fejY && k.Left == fejX)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fejY;
            ke.Left = fejX;
            Controls.Add(ke);
            k�gy�.Add(ke);

            if (k�gy�.Count > hossz)
            {
                Controls.RemoveAt(0);
                k�gy�.RemoveAt(0);
            }

            if (l�p�sSz�ml�m� % 2 == 0) ke.BackColor = Color.Green;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ir�nyX = 0;
                ir�nyY = 1;
            }

            if (e.KeyCode == Keys.Up)
            {
                ir�nyX = 0;
                ir�nyY = -1;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�nyX = -1;
                ir�nyY = 0;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�nyX = 1;
                ir�nyY = 0;
            }


        }
    }
}