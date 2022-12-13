using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 0)
                la.Text = " Loading.....";
            if (a == 20)
                la.Text = " FARES MEZYAD";
            if (a == 60)
                la.Text = " Ve..OSAMA ALSAIDI  ";
            if (a == 70)
                la.Text = " Ve.. MEHHEMET ÇATAKAÇIN  ";
            if (a == 80)
                la.Text = " MUTLU GÜNLER DİLERLER.....";
            a += 1;
            if (a >= 100)
            {
                this.Hide();
                timer1.Enabled = false;
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            gunaProgressBar1.Value = a;




        }
    }
}