using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Practise
{
    public partial class Form4 : Form
    {
        int counter = 0;
        private SoundPlayer d1, d2, d3, d4, d5, d6, d7, d8;

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox3.Checked)
            {
                d6.Play();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox4.Checked)
            {
                d4.Play();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox5.Checked)
            {
                d8.Play();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox7.Checked)
            {
                d2.Play();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox8.Checked)
            {
                d5.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if(checkBox2.Checked)
            {
                d3.Play();
            }
        }

        public Form4()
        {
            InitializeComponent();
            d1 = new SoundPlayer("Bassdrum.wav");
            d2 = new SoundPlayer("Crashcymbal.wav");
            d3 = new SoundPlayer("Floortom.wav");
            d4 = new SoundPlayer("Hightom.wav");
            d5 = new SoundPlayer("Hihat.wav");
            d6 = new SoundPlayer("middletom.wav");
            d7 = new SoundPlayer("ridecymbal.wav");
            d8 = new SoundPlayer("snare.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f42 = new Form2();
            f42.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if(checkBox1.Checked)
            {
                d7.Play();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox6.Checked)
            {
                d1.Play();
            }
        }
    }
}
