using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesLiuMathQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CultureInfo culture = new CultureInfo("en-US");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            label5.Text = DateTime.Now.ToString("dd MMMM yyyy", dtfi);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
