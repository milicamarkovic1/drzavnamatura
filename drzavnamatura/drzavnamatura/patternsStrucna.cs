using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace drzavnamatura
{
    public partial class patternsStrucna : Form
    {
        public patternsStrucna()
        {
            InitializeComponent();
        }
        public static string[] lista = new string[100];
        public static string[] listaimena = new string[100];
        public static string[] jezik = new string[100];
        public static string[] pr1 = new string[100];
        public static string[] pr2 = new string[100];
        public static string[] pr3 = new string[100];
        public static int brojac = 0;
        string s = "";
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter fajl = new StreamWriter("patternsStrucna.txt", true);
            fajl.Write(textBox1.Text);
            fajl.Write(";");
            fajl.Write(comboBox1.SelectedItem.ToString());
            fajl.Write(";");
            fajl.Write(comboBox3.SelectedItem.ToString());
            fajl.Write(";");
            fajl.Write(comboBox4.SelectedItem.ToString());
            fajl.Write(";");
            fajl.Write(comboBox5.SelectedItem.ToString());
            fajl.Write(";");
            fajl.WriteLine("");
            fajl.Close();
            s = textBox1.Text + ";" + comboBox1.SelectedItem.ToString() + ";" + comboBox3.SelectedItem.ToString() + ";" + comboBox4.SelectedItem.ToString() + ";" + comboBox5.SelectedItem.ToString() + ";";
            richTextBox1.Text += s;
            lista[brojac] = s;
            listaimena[brojac] = textBox1.Text;
            jezik[brojac] = comboBox1.SelectedItem.ToString();
            pr1[brojac] = comboBox3.SelectedItem.ToString();
            pr2[brojac] = comboBox4.SelectedItem.ToString();
            pr3[brojac] = comboBox5.SelectedItem.ToString();
            brojac++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StreamReader fajl = new StreamReader("patternsStrucna.txt");
            while (!fajl.EndOfStream)
            {
                richTextBox1.Text += fajl.ReadLine();
            }
            fajl.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter fajl = new StreamWriter("patternsStrucna.txt");
            fajl.Dispose();
            fajl.Close();
            richTextBox1.Text = "";
            brojac = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
