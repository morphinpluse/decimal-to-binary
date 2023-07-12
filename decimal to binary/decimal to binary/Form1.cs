using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decimal_to_binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adad = int.Parse(textBox1.Text);
            MessageBox.Show(binary(adad));
        }
        private string binary(int x)
        {
            string result;

            result = "";
            while (x > 1)
            {
                int y = x % 2;//y=باقیمانده تقسیم چکشی نسیت به 2
                result = Convert.ToString(y) + result;
                x /= 2;
            }
            result = Convert.ToString(x) + result;
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

