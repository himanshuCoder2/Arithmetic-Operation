using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksheetResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, num4, num5, Total, Obtain, p1, p2, p3, p4, p5, Per;

            num1 = Convert.ToInt32(txtbxSE.Text);
            num2 = Convert.ToInt32(txtbxCP.Text);
            num3 = Convert.ToInt32(txtbxNM.Text);
            num4 = Convert.ToInt32(txtbxTC.Text);
            num5 = Convert.ToInt32(txtbxWD.Text);


            //For Obtain Marks
            Total = num1 + num2 + num3 + num4 + num5;
            lblTotal.Text = Total.ToString();

            //For Individual course Grade 
            int A;
            A = Convert.ToInt32(txtbxSE.Text);
            if (A >= 45 && A <= 50)
            {
                lblSe.Text = "AA";
            }
            else if (A >= 40 && A <= 45)
            {
                lblSe.Text = "AB";
            }
            else if (A >= 35 && A <= 40)
            {
                lblSe.Text = "BA";
            }
            else if (A >= 30 && A <= 35)
            {
                lblSe.Text = "BB";
            }
            else if (A >= 25 && A <= 30)
            {
                lblSe.Text = "CA";
            }
            else if (A >= 21 && A <= 25)
            {
                lblSe.Text = "CB";

            }
            else if (A < 21)
            {
                lblSe.Text = "Fail";
            }
            int B;
            B = Convert.ToInt32(txtbxCP.Text);
            if (B >= 45 && B <= 50)
            {
                lblCP.Text = "AA";
            }
            else if (B >= 40 && B <= 45)
            {
                lblCP.Text = "AB";
            }
            else if (B >= 35 && B <= 40)
            {
                lblCP.Text = "BA";
            }
            else if (B >= 30 && B <= 35)
            {
                lblCP.Text = "BB";
            }
            else if (B >= 25 && B <= 30)
            {
                lblCP.Text = "CA";
            }
            else if (B >= 21 && B <= 25)
            {
                lblCP.Text = "CB";

            }
            else if (B < 21)
            {
                lblCP.Text = "Fail";
            }

            int C;
            C = Convert.ToInt32(txtbxNM.Text);
            if (C >= 45 && C <= 50)
            {
                lblNm.Text = "AA";
            }
            else if (C >= 40 && C <= 45)
            {
                lblNm.Text = "AB";
            }
            else if (C >= 35 && C <= 40)
            {
                lblNm.Text = "BA";
            }
            else if (C >= 30 && C <= 35)
            {
                lblNm.Text = "BB";
            }
            else if (C >= 25 && C <= 30)
            {
                lblNm.Text = "CA";
            }
            else if (C >= 21 && C <= 25)
            {
                lblNm.Text = "CB";

            }
            else if (C < 21)
            {
                lblNm.Text = "Fail";
            }

            int D;
            D = Convert.ToInt32(txtbxTC.Text);
            if (D >= 45 && D <= 50)
            {
                lblPerTc.Text = "AA";
            }
            else if (D >= 40 && D <= 45)
            {
                lblTc.Text = "AB";
            }
            else if (D >= 35 && D <= 40)
            {
                lblTc.Text = "BA";
            }
            else if (D >= 30 && D <= 35)
            {
                lblTc.Text = "BB";
            }
            else if (D >= 25 && D <= 30)
            {
                lblTc.Text = "CA";
            }
            else if (D >= 21 && D <= 25)
            {
                lblTc.Text = "CB";

            }
            else if (D < 21)
            {
                lblTc.Text = "Fail";
            }

            int E;
            E = Convert.ToInt32(txtbxWD.Text);
            if (E >= 45 && E <= 50)
            {
                lblGrWd.Text = "AA";
            }
            else if (E >= 40 && E <= 45)
            {
                lblGrWd.Text = "AB";
            }
            else if (E >= 35 && E <= 40)
            {
                lblGrWd.Text = "BA";
            }
            else if (E >= 30 && E <= 35)
            {
                lblGrWd.Text = "BB";
            }
            else if (E >= 25 && E <= 30)
            {
                lblGrWd.Text = "CA";
            }
            else if (E >= 21 && E <= 25)
            {
                lblGrWd.Text = "CB";

            }
            else if (E < 21)
            {
                lblGrWd.Text = "Fail";
            }

            //For All course Grade
            Total = Convert.ToInt32(lblGrade.Text);
            if(Total>=225 && Total<= 250) 
            {
                lblGrade.Text = "AA";
            }
            else if(Total>=200 && Total <= 225)
            {
                lblGrade.Text = "AB";
            }
            else if(Total>=185 && Total <= 200)
            {
                lblGrade.Text = "BA";

            }
            else if(Total>=160 && Total<=185)
            {
                lblGrade.Text = "BC";
            }
            else if(Total>=145 && Total <= 160)
            {
                lblGrade.Text = "CA";
            }
            else if(Total>=135 && Total <= 145)
            {
                lblGrade.Text = "CB";
            }
            else if (Total < 135)
            {
                lblGrade.Text = "Fail";
            }

            //For Individual Course Percentage
            p1 = num1 * 100/ 50;
            lblPerSe.Text = p1.ToString();
            p2 = num2 * 100 / 50;
            lblPerCp.Text = p2.ToString();
            p3 = num3 * 100 / 50;
            lblPerNm.Text = p3.ToString();
            p4 = num4 * 100 / 50;
            lblPerTc.Text = p4.ToString();
            p5 = num5 * 100 / 50;
            lblPerWd.Text = p5.ToString();

            //For All Courses Percentage
            Per = Total / 5;
            lblTotalPer.Text = Per.ToString();

        }
    
    }
}
