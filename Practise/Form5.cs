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
    public partial class Form5 : Form
    {
        private SoundPlayer f1, f2, f3, f4, f5, f6, f7, f8, f9;

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                f4.Play();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                f7.Play();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                f8.Play();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                f9.Play();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                f5.Play();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                f6.Play();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                f3.Play();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                f2.Play();
            }
        }

        public Form5()
        {
            InitializeComponent();
            f1 = new SoundPlayer("laughbabe.wav");
            f2 = new SoundPlayer("laughlong.wav");
            f3 = new SoundPlayer("laughduck.wav");
            f4 = new SoundPlayer("laughminion.wav");
            f5 = new SoundPlayer("bird.wav");
            f6 = new SoundPlayer("fifi.wav");
            f7 = new SoundPlayer("horn.wav");
            f8 = new SoundPlayer("sirenpolice.wav");
            f9 = new SoundPlayer("tali.wav");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f52 = new Form2();
            f52.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                f1.Play();
            }
        }
    }
}
