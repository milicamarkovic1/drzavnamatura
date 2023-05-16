using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drzavnamatura
{
    public partial class tipMature : Form
    {
        public tipMature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opsta o = new opsta();
            o.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            strucna s = new strucna();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            umetnicka u = new umetnicka();
            u.Show();
        }
    }
}
