using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Show_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numQuestion = 0,correct=0,wrong=0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            label5.Text = btnB.Text;

            if (label4.Text == label5.Text)
            {
                correct++;
                lblCorrect.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                correct++;
                lblCorrect.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                correct++;
                lblCorrect.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            label5.Text = btnA.Text;

            if (label4.Text == label5.Text)
            {
                correct++;
                lblCorrect.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numQuestion++;
            lblNumQuestion.Text = numQuestion.ToString();

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnNext.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible=false;

            if (numQuestion == 1)
            {
                richTextBox1.Text = "In what year was the Republic declared?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";

            }
            if (numQuestion == 2)
            {
                richTextBox1.Text = "Who is the author of The Last Birds book?";
                btnA.Text = "Sait Faik Abasıyanık";
                btnB.Text = "Reşat Nuri Güntekin";
                btnC.Text = "Zülfü Livaneli";
                btnD.Text = "Cemal Süreya";
                label4.Text = "Sait Faik Abasıyanık";


            }
            if (numQuestion == 3)
            {
                richTextBox1.Text = "Which province is not located in the Aegean Region?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";
                btnNext.Text = "Results";

            }
            
            if(numQuestion == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Correct : " + correct + "\n" + "Wrong : " + wrong);

            }
            

        }
        

    }
}
