using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mosabegatKoshti
{
    
    public partial class Form1 : Form
    {
        int Round=1,emtiazA=0,emtiazG=0;
        String checkPayan = "false";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Hide();
            
        }
        
        System.Diagnostics.Stopwatch ss = new System.Diagnostics.Stopwatch { };
      

      
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int mins = ss.Elapsed.Minutes, secs = ss.Elapsed.Seconds,meli=ss.Elapsed.Milliseconds;
            label1.Text = mins + ":";
            if (secs < 10)
                label1.Text += "0" + secs + ":";
            else
                label1.Text += secs + ":";
            if (meli < 10)
                label1.Text += "0" + meli;
            else                
                    label1.Text += meli;
               
            if (mins==3)
            {             
                if (Round == 1)
                {
                    Round++;
                }
                else
                {
                    Round = 1;
                    checkPayan = "true";
                }
                label8.Text = "" + Round;
                label1.Text = "3:00:00";
                ss.Stop();
                ss.Reset();
                timer1.Enabled = false; 

            }

        }

        

     
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                if (checkPayan == "false")
                {
                    ss.Start();
                    timer1.Enabled = true;
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("بازی به پایان رسیده است");
                }
            }
            if (e.KeyCode == Keys.W)
            {
                ss.Stop();
                timer1.Enabled = false; 
                textBox1.Clear();
                textBox1.Focus();
            }
            if (e.KeyCode == Keys.E)
            {
                ss.Reset();
                timer1.Enabled = false;
                textBox1.Clear();
                textBox1.Focus();
                label1.Text = "00:00:00";
            }
            if(e.KeyCode==Keys.G)
            {
                emtiazG++;
                label7.Text = "" + emtiazG;
            }
            if (e.KeyCode == Keys.B)
            {
                emtiazG--;
                label7.Text = "" + emtiazG;
            }
            if (e.KeyCode == Keys.F)
            {
                emtiazA++;
                label6.Text = "" + emtiazA;
            }
            if (e.KeyCode == Keys.V)
            {
                emtiazA--;
                label6.Text = "" + emtiazA;
            }
            if (e.KeyCode == Keys.O)
            {
                Round=1;
                label8.Text = "" + Round;
            }
            if (e.KeyCode == Keys.P)
            {
                Round = 2;
                label8.Text = "" + Round;
            }

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void مسابقهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            textBox2.Focus();
        }
        private void Startnew()
        {
            checkPayan = "false";
            Round = 1;
            emtiazA = 0;
            emtiazG = 0;
            label6.Text = "" + emtiazA;
            label7.Text = "" + emtiazG;
            label8.Text =""+ Round;
            textBox2.Text = "";
            textBox3.Text = "";
            ss.Stop();
            ss.Reset();
            label1.Text = "0:00:00";


        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("نام یکی از کشتی گیران خالی است");
            }
            else
            {
                label4.Text = textBox2.Text;
                label5.Text = textBox3.Text;
                Startnew();
                panel1.Hide();
                textBox1.Focus();
            }

        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void راهنماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Q: "+"شروع به کار تایمر"+"\n"
                           + " W: " + "توقف  تایمر" + "\n"
                           + " E: " + "شروع مجدد  تایمر" + "\n"
                           + " F: " + "افزودن یک امتیاز به آبی" + "\n"
                           + " V: " + "کاهش یک امتیاز از آبی" + "\n"
                           + " G: " + "افزودن یک امتیاز به قرمز" + "\n"
                           + " B: " + "کاهش یک امتیاز از قرمز" + "\n"
                           + " O: " + "تغییر به دست اول" + "\n"
                           + " P: " + "تغییر به دست دوم" + "\n"

              );
        }
    }
}
