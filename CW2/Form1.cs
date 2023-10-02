using System;
using Lists;
using System.Windows.Forms;

namespace CW2
{
    public partial class Form1 : Form
    {
        DoublyLinkedList a = new DoublyLinkedList();
        //ArrayList a = new ArrayList(10);
        //SinglyLinkedList a = new SinglyLinkedList();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            a.add(textBox1.Text);
            i++;
            label1.Text = "จำนวน" + i + "คน";
            textBox2.Text = "" + i;

            string name;
            name = textBox1.Text;
            MessageBox.Show("เพิ่มเรียบร้อยแล้ว");
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a.contains(textBox1.Text))
            {
                MessageBox.Show("เจอข้อมูล");
            }
            else
            {
                MessageBox.Show("ไม่เจอข้อมูล");
            }
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.remove(textBox1.Text);
            string name;
            name = textBox1.Text;
            MessageBox.Show("ลบเรียบร้อย");
            if (i == 0)
            {
                i = 0;
            }
            else i--;
            label1.Text = "จำนวน " + i + " คน";
            textBox2.Text = null;
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox2.Text);
            textBox3.Text = "" + a.get(i - 1);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox2.Text);
            i--;
            a.set(i, textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            for (int i = 0; i < a.size(); i++)
            {
                richTextBox1.Text += (i + 1) + " . " + a.get(i) + "\n";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
