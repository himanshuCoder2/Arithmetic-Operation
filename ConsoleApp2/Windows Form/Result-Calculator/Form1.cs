using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result_Calculator
{
    public partial class Marksheet : Form
    {
        public Marksheet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double English = 0;
            double Math = 0;
            double History = 0;
            double Total;
            double Percentage;

            
            if (textEnglish.Text=="")
            {
                English = 0;
            }
            else
            {
                English = Convert.ToDouble(textEnglish.Text);
            }
            if (textMath.Text=="")
            {
                Math = 0;
            }
            else
            {
                Math = Convert.ToDouble(textMath.Text);
            }
            if (textHistory.Text=="")
            {
                History = 0;
            }
            else
            {
                History = Convert.ToDouble(textHistory.Text);
            }
           

            Total = English + Math + History;
            txtTotalOp.Text = Total.ToString();
            Percentage = Total / 3;
            txtPercentageOp.Text = Percentage.ToString();
        }
    }
}
