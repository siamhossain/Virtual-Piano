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
    public partial class Form3 : Form
    {
        int counter = 0;
        private SoundPlayer p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12;

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox12.Checked)
            {
                p9.Play();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox4.Checked)
            {
                p10.Play();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox8.Checked)
            {
                p11.Play();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox7.Checked)
            {
                p12.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox6.Checked)
            {
                p8.Play();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox11.Checked)
            {
                p7.Play();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox5.Checked)
            {
                p6.Play();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox2.Checked)
            {
                p5.Play();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox10.Checked)
            {
                p4.Play();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox9.Checked)
            {
                p2.Play();
            }
        }

        public Form3()
        {
            InitializeComponent();
            p1 = new SoundPlayer("C.wav");
            p2 = new SoundPlayer("C#.wav");
            p3 = new SoundPlayer("D.wav");
            p4 = new SoundPlayer("D#.wav");
            p5 = new SoundPlayer("E.wav");
            p6 = new SoundPlayer("F.wav");
            p7 = new SoundPlayer("F#.wav");
            p8 = new SoundPlayer("G.wav");
            p9 = new SoundPlayer("G#.wav");
            p10 = new SoundPlayer("A.wav");
            p11 = new SoundPlayer("Bb.wav");
            p12 = new SoundPlayer("B.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f32 = new Form2();
            f32.Show();
            this.Hide();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            if (checkBox3.Checked)
            {
                p3.Play();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            label1.ForeColor = Color.White;
            
            if (checkBox1.Checked)
            {
                p1.Play();
            }
        }
    }
}
