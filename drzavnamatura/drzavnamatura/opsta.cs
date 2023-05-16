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
    public partial class opsta : Form
    {
        public opsta()
        {
            InitializeComponent();
        }
        public string s5 = "";
        public string s4 = "";
        public string s3 = "";
        public string s2 = "";
        public string s1 = "";
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index1 = checkedListBox1.SelectedIndex;
            int count1 = checkedListBox1.Items.Count;
            for (int i = 0; i < count1; i++)
            {
                if (index1 != i) checkedListBox1.SetItemChecked(i, false);
            }
            for (int i = 0; i <= (count1 - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    s1 = checkedListBox1.Items[i].ToString();
                }
            }
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index3 = checkedListBox3.SelectedIndex;
            int count3 = checkedListBox3.Items.Count;
            for (int i = 0; i < count3; i++)
            {
                if (index3 != i) checkedListBox3.SetItemChecked(i, false);
            }
            for (int i = 0; i <= (count3 - 1); i++)
            {
                if (checkedListBox3.GetItemChecked(i))
                {
                    s3 = checkedListBox3.Items[i].ToString();
                }
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index2 = checkedListBox2.SelectedIndex;
            int count2 = checkedListBox2.Items.Count;
            for (int i = 0; i < count2; i++)
            {
                if (index2 != i) checkedListBox2.SetItemChecked(i, false);
            }
            for (int i = 0; i <= (count2 - 1); i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    s2 = checkedListBox2.Items[i].ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            patternsOpsta p = new patternsOpsta();
            p.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.ClearSelected();
            checkedListBox2.ClearSelected();
            checkedListBox3.ClearSelected();
            checkedListBox4.ClearSelected();
            checkedListBox5.ClearSelected();
            int index = comboBox1.SelectedIndex;
            for (int i = 0; i < patternsOpsta.brojac; i++)
            {
                if (index == i)
                {
                    int index5 = checkedListBox5.SelectedIndex;
                    int count5 = checkedListBox5.Items.Count;
                    for (int j = 0; j < count5; j++)
                    {
                        if (index5 != j) checkedListBox5.SetItemChecked(j, false);
                    }
                    int index4 = checkedListBox4.SelectedIndex;
                    int count4 = checkedListBox4.Items.Count;
                    for (int j = 0; j < count4; j++)
                    {
                        if (index4 != j) checkedListBox4.SetItemChecked(j, false);
                    }
                    int index3 = checkedListBox3.SelectedIndex;
                    int count3 = checkedListBox3.Items.Count;
                    for (int j = 0; j < count3; j++)
                    {
                        if (index3 != j) checkedListBox3.SetItemChecked(j, false);
                    }
                    int index2 = checkedListBox2.SelectedIndex;
                    int count2 = checkedListBox2.Items.Count;
                    for (int j = 0; j < count2; j++)
                    {
                        if (index2 != j) checkedListBox2.SetItemChecked(j, false);
                    }
                    int index1 = checkedListBox1.SelectedIndex;
                    int count1 = checkedListBox1.Items.Count;
                    for (int j = 0; j < count1; j++)
                    {
                        if (index1 != j) checkedListBox1.SetItemChecked(j, false);
                    }
                    s5 = patternsOpsta.jezik[index];
                    int pom5 = checkedListBox5.Items.IndexOf(patternsOpsta.jezik[index]);
                    checkedListBox5.SetItemChecked(pom5, true);
                    s4 = patternsOpsta.smer[index];
                    int pom4 = checkedListBox4.Items.IndexOf(patternsOpsta.smer[index]);
                    checkedListBox4.SetItemChecked(pom4, true);
                    s3 = patternsOpsta.pr3[index];
                    int pom3 = checkedListBox3.Items.IndexOf(patternsOpsta.pr3[index]);
                    checkedListBox3.SetItemChecked(pom3, true);
                    s2 = patternsOpsta.pr2[index];
                    int pom2 = checkedListBox2.Items.IndexOf(patternsOpsta.pr2[index]);
                    checkedListBox2.SetItemChecked(pom2, true);
                    s1 = patternsOpsta.pr1[index];
                    int pom1 = checkedListBox1.Items.IndexOf(patternsOpsta.pr1[index]);
                    checkedListBox1.SetItemChecked(pom1, true);
                }
            }
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index5 = checkedListBox5.SelectedIndex;
            int count5 = checkedListBox5.Items.Count;
            for (int i = 0; i < count5; i++)
            {
                if (index5 != i) checkedListBox5.SetItemChecked(i, false);
            }
            for (int i = 0; i <= (count5 - 1); i++)
            {
                if (checkedListBox5.GetItemChecked(i))
                {
                    s5 = checkedListBox5.Items[i].ToString();
                }
            }
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index4 = checkedListBox4.SelectedIndex;
            int count4 = checkedListBox4.Items.Count;
            for (int i = 0; i < count4; i++)
            {
                if (index4 != i) checkedListBox4.SetItemChecked(i, false);
            }
            for (int i = 0; i <= (count4 - 1); i++)
            {
                if (checkedListBox4.GetItemChecked(i))
                {
                    s4 = checkedListBox4.Items[i].ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("uceniciOpsta.txt", true);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && checkedListBox1.CheckedIndices.Count == 1 && checkedListBox2.CheckedIndices.Count == 1 && checkedListBox3.CheckedIndices.Count == 1 && checkedListBox4.CheckedIndices.Count == 1 && checkedListBox5.CheckedIndices.Count == 1)
            {
                richTextBox1.Text += textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + s5 + ";" + s4 + ";" + s1 + ";" + s2 + ";" + s3 + ";";
                f.WriteLine(textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + s5 + ";" + s4 + ";" + s1 + ";" + s2 + ";" + s3 + ";");
            }
            f.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            int br = patternsOpsta.brojac;
            for (int i = 0; i < br; i++)
            {
                comboBox1.Items.Add(patternsOpsta.listaimena[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StreamReader fajl = new StreamReader("uceniciOpsta.txt");
            while (!fajl.EndOfStream)
            {
                richTextBox1.Text += fajl.ReadLine();
            }
            fajl.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter fajl = new StreamWriter("uceniciOpsta.txt");
            fajl.Dispose();
            fajl.Close();
            richTextBox1.Text = "";
        }
    }
}
