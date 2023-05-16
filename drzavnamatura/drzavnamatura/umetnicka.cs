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
    public partial class umetnicka : Form
    {
        public umetnicka()
        {
            InitializeComponent();
        }
        public string s5 = "";
        public string s3 = "";
        public string s2 = "";
        public string s1 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            patternsUmetnicka p = new patternsUmetnicka();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            int br = patternsUmetnicka.brojac;
            for (int i = 0; i < br; i++)
            {
                comboBox1.Items.Add(patternsUmetnicka.listaimena[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("uceniciUmetnicka.txt", true);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && checkedListBox1.CheckedIndices.Count == 1 && checkedListBox2.CheckedIndices.Count == 1 && checkedListBox3.CheckedIndices.Count == 1 && checkedListBox5.CheckedIndices.Count == 1)
            {
                richTextBox1.Text += textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + s5 + ";" + s1 + ";" + s2 + ";" + s3 + ";";
                f.WriteLine(textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + s5 + ";" + s1 + ";" + s2 + ";" + s3 + ";");
            }
            f.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StreamReader fajl = new StreamReader("uceniciUmetnicka.txt");
            while (!fajl.EndOfStream)
            {
                richTextBox1.Text += fajl.ReadLine();
            }
            fajl.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter fajl = new StreamWriter("uceniciUmetnicka.txt");
            fajl.Dispose();
            fajl.Close();
            richTextBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.ClearSelected();
            checkedListBox2.ClearSelected();
            checkedListBox3.ClearSelected();
            checkedListBox5.ClearSelected();
            int index = comboBox1.SelectedIndex;
            for (int i = 0; i < patternsUmetnicka.brojac; i++)
            {
                if (index == i)
                {
                    int index5 = checkedListBox5.SelectedIndex;
                    int count5 = checkedListBox5.Items.Count;
                    for (int j = 0; j < count5; j++)
                    {
                        if (index5 != j) checkedListBox5.SetItemChecked(j, false);
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
                    s5 = patternsUmetnicka.jezik[index];
                    int pom5 = checkedListBox5.Items.IndexOf(patternsUmetnicka.jezik[index]);
                    checkedListBox5.SetItemChecked(pom5, true);
                    s3 = patternsUmetnicka.pr3[index];
                    int pom3 = checkedListBox3.Items.IndexOf(patternsUmetnicka.pr3[index]);
                    checkedListBox3.SetItemChecked(pom3, true);
                    s2 = patternsUmetnicka.pr2[index];
                    int pom2 = checkedListBox2.Items.IndexOf(patternsUmetnicka.pr2[index]);
                    checkedListBox2.SetItemChecked(pom2, true);
                    s1 = patternsUmetnicka.pr1[index];
                    int pom1 = checkedListBox1.Items.IndexOf(patternsUmetnicka.pr1[index]);
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
    }
}
