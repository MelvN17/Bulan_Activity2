using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulan_Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int primeN = (int)numericUpDown1.Value;
            int primeG = (int)numericUpDown2.Value;
            int randomX = (int)numericUpDown3.Value;
            int randomY = (int)numericUpDown4.Value;
            int a, b, k1, k2;

            //Alice
            a = ((int)Math.Pow(primeG, randomX)) % primeN;

            //Bob
            b = ((int)Math.Pow(primeG, randomY)) % primeN;

            k1 = ((int)Math.Pow(b,randomX)) % primeN;
            k2 = ((int)Math.Pow(a, randomY)) % primeN;

            if (k1 == k2)
                textBox5.Text = Convert.ToString(k1);
            else
                textBox5.Text = "Prime number not valid";
        }

       }
}
