using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜçgenAlanıBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       double Alan ( double k1, double h) 
       {
            return (k1 * h) / 2;

       }

        double Alan( double k1, double k2, int aci) 
        {
            return (k1 * k2 * Math.Sin(aci * (Math.PI / 180.00))) * 0.5;
        }

        double Alan (double k1, double k2, double k3) 
        {
            double uzunluk = (k1 * k2 * k3) / 2;
            return Math.Sqrt(uzunluk * (uzunluk - k1) * (uzunluk - k2) * (uzunluk - k3));
        
        }

        double kenar1;
        double kenar2;
        double kenar3;
        double yukselik;
        int aci;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                kenar1 = Convert.ToDouble(textBox1.Text);
                yukselik = Convert.ToDouble(textBox4.Text);
                listBox1.Items.Add("1. İşlem: " + Alan(kenar1, yukselik));
            
            }
            else if(radioButton2.Checked)
            {
                kenar1 = Convert.ToDouble(textBox1.Text);
                kenar2 = Convert.ToDouble(textBox2.Text);
                aci = Convert.ToInt32(textBox5.Text);
                listBox1.Items.Add("2. İşlem: " + Alan(kenar1, kenar2, aci));
            
            }
            else if (radioButton3.Checked) 
            {
                kenar1 = Convert.ToDouble(textBox1.Text);
                kenar2 = Convert.ToDouble(textBox2.Text);
                kenar3 = Convert.ToDouble(textBox3.Text);
                listBox1.Items.Add("3. İşlem: " + Alan(kenar1, kenar2, kenar3));
            }
            else 
            {
                MessageBox.Show("Herhangi Bir Seçim Yapmadınız!");
            
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
    }
}
