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
    public partial class OP : Form
    {
        public OP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 pvp = new Form1();
            pvp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PVE pve = new PVE();
            pve.Show();
        }
    }
}
