using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh_gyak_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "félgömb, 0,25 sorozat";
            label1.Text = "félgömb sugara";
            label2.Text = "itt lesz majd a felszín";
            label3.Text = "Epszilon értéke";
            label4.Text = "itt lesz majd az eredmény";
            button1.Text = button2.Text = "SZÁMOLJ CSICSKA";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r;

            if (textBox1.Text == "")  r=1;
            else r = Convert.ToDouble(textBox1.Text);
            
                double felsz;
               
                felsz = 2 * r * r * Math.PI+r*r*Math.PI;
                label2.Text = "a félgömb felszíne: " + felsz.ToString("F4");
            
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tort, sor=0, eps, i=1;
            if (textBox2.Text == "") eps = 1;
            
            else eps = Convert.ToDouble(textBox2.Text);
            if (eps >= 1) label4.Text = "túl nagy a szám csicska";
            else
            {
                do
                {
                    tort = 1 / (i * (i + 1) * (i + 2));
                    sor += tort;
                    i++;

                } while (Math.Abs(tort) > eps);
                label4.Text = "a művelet eredménye: " + sor.ToString("F6");
            }
        } 
    }
}
