using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnnext.Text = "start";
            btnA.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            richTextBox1.Enabled = false;
            richTextBox1.Text = "Bilgi Yarışmasına Hoş Geldiniz \n başlamak için start butonuna basınız!";
        }

        int soruNo = 0, dogru = 0, yanlis = 0;
              
        private void btnb_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;
            label5.Text = btnb.Text;
            if (label5.Text == label2.Text)
            {
                dogru++;
                label3.Text = "Doğru:" + dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label4.Text = "yanlis: " + yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;

            label5.Text = btnc.Text;
            if (label5.Text == label2.Text)
            {
                dogru++;
                label3.Text = "Doğru:" + dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label4.Text = "yanlis: " + yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;


            label5.Text = btnd.Text;
            if (label5.Text == label2.Text)
            {
                dogru++;
                label3.Text = "Doğru:" + dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label4.Text = "yanlis: " + yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;     
            btnnext.Enabled = true;

            label5.Text = btnA.Text;
            if (label5.Text==label2.Text)
            {
                dogru++;
                label3.Text = "Doğru:" + dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label4.Text = "yanlis: " + yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            btnnext.Text = "sonraki";
            soruNo++;
            label1.Text = "Soru no: " + soruNo.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnA.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;

            if (soruNo==1)
            {
                richTextBox1.Text = "İstanbul kaç yılında fethedildi?";
                btnA.Text = "1453";
                btnb.Text = "1923";
                btnc.Text = "1071";
                btnd.Text = "1243";
                label2.Text="1453";
                
            }

            else if (soruNo==2)
            {
                richTextBox1.Text = "Büyük Marmara Depremi Kaç yılında meydana gelmiştir?";
                btnA.Text = "1923";
                btnb.Text = "1983";
                btnc.Text = "1991";
                btnd.Text = "1999";
                label2.Text = "1999";

            }

            else
            {
                richTextBox1.Text = "Bilgi yarışmasının sonuna geldiniz";
                btnA.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnnext.Enabled = false;
                MessageBox.Show("Doğru:" + dogru + "\n" + "yanlıs:" + yanlis,"Sonuçlar");
                Close();
                
            }
        }
    }
}
