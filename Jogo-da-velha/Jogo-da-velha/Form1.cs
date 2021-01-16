using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int troca = 0;
        string win;
        bool fim = true;

        private void a1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            troca++;
            
            if (troca == 1)
            {
                b.Text = "x";
            }

            if (troca == 2)
            {
                b.Text = "o";
                troca = 0;
            }
            b.Enabled = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Text != "" && fim == true)
            {
                win = a1.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");



            }
            if (a1.Text == a5.Text && a5.Text == a9.Text && a1.Text != "" && fim == true)
            {
                win = a1.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a1.Text == a4.Text && a4.Text == a7.Text && a1.Text != "" && fim == true)
            {
                win = a1.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a2.Text == a5.Text && a5.Text == a8.Text && a2.Text != "" && fim == true)
            {
                win = a2.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a3.Text == a6.Text && a6.Text == a9.Text && a3.Text != "" && fim == true)
            {
                win = a3.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a3.Text == a5.Text && a5.Text == a7.Text && a3.Text != "" && fim == true)
            {
                win = a3.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a4.Text == a5.Text && a5.Text == a6.Text && a4.Text != "" && fim == true)
            {
                win = a4.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a7.Text == a8.Text && a8.Text == a9.Text && a7.Text != "" && fim == true)
            {
                win = a7.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            a5.Text = "";
            a6.Text = "";
            a7.Text = "";
            a8.Text = "";
            a9.Text = "";

            fim = true;
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            a4.Enabled = true;
            a5.Enabled = true;
            a6.Enabled = true;
            a7.Enabled = true;
            a8.Enabled = true;
            a9.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
