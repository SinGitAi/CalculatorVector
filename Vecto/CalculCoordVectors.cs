using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vecto
{
    public partial class CalculCoordVectors : Form
    {
        Result res;
        public CalculCoordVectors()
        {
            InitializeComponent();
            button21.Enabled = false;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBox1.SelectedIndex == 0)
                {
                    DataBank.CBIndex = comboBox1.SelectedIndex;
                    label13.Visible = true;
                    textBox6.Visible = true;
                    label10.Location = new Point(427, 131);
                    label18.Visible = true;
                    textBox9.Visible = true;
                    label12.Location = new Point(427, 217);
                }


                else
                {
                    DataBank.CBIndex = comboBox1.SelectedIndex;
                    label13.Visible = false;
                    textBox6.Visible = false;
                    label10.Location = new Point(367, 131);
                    label18.Visible = false;
                    textBox9.Visible = false;
                    label12.Location = new Point(367, 217);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu mainWind = new StartMenu();
            mainWind.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            int x, y, z;
            string a, b, c;
            if (comboBox1.SelectedIndex == 1)
            {
                x = Int32.Parse(textBox7.Text) - Int32.Parse(textBox4.Text);
                y = Int32.Parse(textBox8.Text) - Int32.Parse(textBox5.Text);
                z = Int32.Parse(textBox9.Text) - Int32.Parse(textBox6.Text);
                a = x.ToString();
                b = y.ToString();
                c = z.ToString();
                DataBank.x = a;
                DataBank.y = b;
                DataBank.z = c;
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                x = Int32.Parse(textBox7.Text) - Int32.Parse(textBox4.Text);
                y = Int32.Parse(textBox8.Text) - Int32.Parse(textBox5.Text);
                a = x.ToString();
                b = y.ToString();
                DataBank.x = a;
                DataBank.y = b;
            }
            this.Hide();
            res = new Result();
            res.Show();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if ((textBox4.Text.Length == 0) || (textBox5.Text.Length == 0) || (comboBox1.Text.Length == 0) | (textBox7.Text.Length == 0) | (textBox8.Text.Length == 0))
            {
                button21.Enabled = false;
            }
            else
            {
                button21.Enabled = true;
            }
        }



        private void CalculCoordVectors_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
