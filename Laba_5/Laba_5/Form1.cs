using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raschet_Pryamougol gigachat1 = new Raschet_Pryamougol();
            gigachat1.functione1(textBox1.Text, textBox2.Text);

            textBox3.Text = gigachat1.Stor_3;
            textBox4.Text = gigachat1.Stor_4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Raschet_Treugol gigachat2 = new Raschet_Treugol();
            gigachat2.functione2(textBox8.Text, textBox7.Text, textBox9.Text, textBox10.Text);

            textBox6.Text = gigachat2.Stor_5;
            textBox5.Text = gigachat2.Stor_6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raschet_Krug gigachat3 = new Raschet_Krug();
            gigachat3.functione3(textBox14.Text);

            textBox12.Text = gigachat3.Stor_2;
            textBox11.Text = gigachat3.Stor_3;
        }
    }

    public class Raschet_Pryamougol
    {
        public string Stor_3;
        public string Stor_4;

        public void functione1 (string Stor1, string Stor2)
        {
            int Stor_1 = Convert.ToInt32(Stor1);
            int Stor_2 = Convert.ToInt32(Stor2);

            int Perimetr = 2 * (Stor_1 + Stor_2);
            int Ploshadb = Stor_1 * Stor_2;

            this.Stor_3 = Convert.ToString(Perimetr);
            this.Stor_4 = Convert.ToString(Ploshadb);
        }
    }

    public class Raschet_Treugol
    {
        public string Stor_5;
        public string Stor_6;

        public void functione2(string Stor1, string Stor2, string Stor_3, string Stor_4)
        {
            int Visota = Convert.ToInt32(Stor1);
            int Osnovanie = Convert.ToInt32(Stor2);
            int Stor_1 = Convert.ToInt32(Stor_3);
            int Stor_2 = Convert.ToInt32(Stor_4);

            int Perimetr = Osnovanie + Stor_1 + Stor_2;
            double Ploshadb = 0.5 * Osnovanie * Visota;

            this.Stor_5 = Convert.ToString(Perimetr);
            this.Stor_6 = Convert.ToString(Ploshadb);
        }
    }

    public class Raschet_Krug
    {
        public string Stor_2;
        public string Stor_3;

        public void functione3(string Stor1)
        {
            int Radius = Convert.ToInt32(Stor1);

            double Perimetr = 2 * 3.14 * Radius;
            double Ploshadb = 3.14 * (Radius * Radius);

            this.Stor_2 = Convert.ToString(Perimetr);
            this.Stor_3 = Convert.ToString(Ploshadb);
        }
    }
}
