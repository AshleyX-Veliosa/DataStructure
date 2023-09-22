using Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2
{
    public partial class Form1 : Form
    {
        ArrayList a = new ArrayList(10);
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.add(textBox1.Text);
            i++;
            textBox3.Text = "" + i;
            label1.Text = "จำนวน " + i + " คน";
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย");
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a.contains(textBox1.Text))
            {
                MessageBox.Show("เจอแล้ว");
            }
            else
            {
                MessageBox.Show("ไม่เจอใส่ข้อมูลหรือยัง?/");
            }
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.remove(textBox1.Text);
            if (a.contains(textBox1.Text))
            {
                MessageBox.Show("เจอแล้ว");
                if (textBox3 != null)
                {
                    i--;
                    textBox3.Text = "" + i;
                }
                label1.Text = "จำนวน " + i + " คน";
            }
            else
            {
                MessageBox.Show("ไม่เจอใส่ข้อมูลหรือยัง?/");
            }
            textBox1.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox2.Text);
            textBox2.Text = "" + a.get(i - 1);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            int i = int.Parse(textBox3.Text);
            a.set(i - 1, textBox2.Text);
            MessageBox.Show("แก้ไขเรียบร้อย");
            label1.Text = "จำนวน " + i + " คน";
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            textBox3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
                for (int i = 0; i < a.size(); i++)
                {
                    richTextBox1.Text += (i+1) + " : " +  a.get(i) + "\n";
                }
                if (a.size() == 0)
                {
                    MessageBox.Show("ไม่มีข้อมูล");
                }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
