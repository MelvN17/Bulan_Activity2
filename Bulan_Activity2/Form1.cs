using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            //Bulan, Melvin S.
            BigInteger primeN = BigInteger.Parse(numericUpDown1.Value.ToString());
            BigInteger primeG = BigInteger.Parse(numericUpDown2.Value.ToString());
            BigInteger randomX = BigInteger.Parse(numericUpDown3.Value.ToString());
            BigInteger randomY = BigInteger.Parse(numericUpDown4.Value.ToString());
            BigInteger a, b, k1, k2;

            //Alice
            a = BigInteger.ModPow(primeG, randomX, primeN);

            //Bob
            b = BigInteger.ModPow(primeG, randomY, primeN);

            k1 = BigInteger.ModPow(b, randomX, primeN);
            k2 = BigInteger.ModPow(a, randomY, primeN);

            if (k1 == k2)
                textBox5.Text = k1.ToString();
            else
                textBox5.Text = "Prime number not valid";
        }

       }
}
