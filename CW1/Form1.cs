using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collections;

namespace CW1
{
    public partial class Form1 : Form
    {
        Collection a = new ArrayCollection(10);
        Collection B = new LinkedCollection();
        Collection d = new LinkHeaderCollections();
        Set x = new ArraySet(10);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x.add(textBox1.Text);
            MessageBox.Show("Added");
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(x.contains(textBox2.Text))
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("Noting Found. Did u Add Data?");
            }
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(x.contains(textBox3.Text))
            {
                MessageBox.Show("Found");
                x.remove(textBox3.Text);
                MessageBox.Show("Removed");
            }
            else
            {
                MessageBox.Show("Not Found. Did u Add a data????");
            }
            textBox3.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int livedata = x.size();
            label1.Text = livedata.ToString();
            label1.Text = $"จำนวน : {x.size()} คน ";
        }
    }
}
