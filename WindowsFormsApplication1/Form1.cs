using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // convertFromFahrenheit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }

        private void convertFromFahrenheit()
        {
            float f = 0;
            try
            {
                f = float.Parse(txt_fahrenheit.Text);
            }
            catch
            {
                MessageBox.Show("Enter numbers only");
            }
            float c = 5f / 9f * (f - 32f);
            float k = c - 273;

            txt_celsius.Text=c.ToString();
            txt_kelvin.Text=k.ToString();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //convertFromCelsius();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            convertFromCelsius();
        }

        private void convertFromCelsius()
        {
            float c = 0;
            try
            {
                c = float.Parse(txt_celsius.Text);
            }
            catch
            {
                MessageBox.Show("Enter numbers only");
            }
            float f = c * (9 / 5) + 32;
            float k = c + 273; 

            txt_fahrenheit.Text = f.ToString();
            txt_kelvin.Text = k.ToString();
        }






        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            convertFromkelvin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            convertFromkelvin();
        }


        private void convertFromkelvin()
        {
            float k = 0;
            try
            {
                k = float.Parse(txt_kelvin.Text);
            }
            catch
            {
                MessageBox.Show("Enter numbers only");
            }
            float f = (k - 273) * (9 / 5) + 32;
            float c = k - 27;

            txt_fahrenheit.Text = f.ToString();
            txt_celsius.Text = c.ToString();
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
