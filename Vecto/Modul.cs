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
    public partial class Modul : Form
    {
        ResultNum resNum;
        public Modul()
        {
            InitializeComponent();
            button21.Enabled = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu mainWind = new StartMenu();
            mainWind.Show();
        }


        private void Modul_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex == 1)
            {
                label7.Show();
                label7.Text = "a =";
                label10.Location = new Point(365, 165);
                label13.Hide();
                textBox6.Hide();
                label8.Hide();
                label11.Hide();
                label17.Hide();
                label18.Hide();
                label12.Hide();
                textBox7.Hide();
                textBox8.Hide();
                textBox9.Hide();
            }
            else if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 0)
            {
                label13.Show();
                label10.Show();
                label10.Location = new Point(424, 165);
                label12.Show();
                label12.Location = new Point(424, 217);
                textBox6.Show();
                label7.Show();
                label7.Text = "A =";
                label8.Show();
                label8.Text = "B =";
                label11.Show();
                label17.Show();
                label18.Show();
                textBox7.Show();
                textBox8.Show();
                textBox9.Show();
            }
            else if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 1)
            {
                label7.Show();
                label7.Text = "a =";
                label8.Hide();
                label11.Hide();
                label17.Hide();
                label18.Hide();
                label12.Hide();
                textBox7.Hide();
                textBox8.Hide();
                textBox9.Hide();
                label13.Show() ;
                label10.Show() ;
                label10.Location = new Point(424, 165);
                textBox6 .Show() ;
            }
            else if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex == 0)
            {
                label13.Hide();
                label18.Hide();
                textBox6.Hide();
                textBox9.Hide();
                label7.Show();
                label7.Text = "A =";
                label8.Show();
                label8.Text = "B =";
                label11.Show();
                label17.Show();
                label12.Show();
                label12.Location = new Point(365, 217);
                textBox7 .Show();
                textBox8.Show();
                label10.Show();
                label10.Location = new Point(365, 165);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1 )
                if ((textBox4.Text.Length == 0) || (textBox5.Text.Length == 0) ||  (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0))
                {
                    button21.Enabled = false;
                }
                else
                {
                    button21.Enabled = true;
                }
            else if (comboBox2.SelectedIndex == 0)
            {
                if ((textBox4.Text.Length == 0) || (textBox5.Text.Length == 0) || (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0) || (textBox7.Text.Length == 0) || (textBox8.Text.Length == 0))
                {
                    button21.Enabled = false;
                }
                else
                {
                    button21.Enabled = true;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double x, y, z, dlin,okr;
            string a,b;
            if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex == 1)
            {
                x = Int32.Parse(textBox4.Text);
                y = Int32.Parse(textBox5.Text);
                dlin = Math.Sqrt(x * x + y * y);
                okr = Math.Round(dlin, 2);
                b = okr.ToString();
                DataBank.modul = b;
                
            }
            else if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 0)
            {
                x = Int32.Parse(textBox7.Text) - Int32.Parse(textBox4.Text);
                y = Int32.Parse(textBox8.Text) - Int32.Parse(textBox5.Text);
                z = Int32.Parse(textBox9.Text) - Int32.Parse(textBox6.Text);
                dlin = Math.Sqrt(x * x + y * y + z * z);
                okr = Math.Round(dlin, 2);
                b = okr.ToString();
                DataBank.modul = b;
            }

            else if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex == 0)
            {
                x = Int32.Parse(textBox7.Text) - Int32.Parse(textBox4.Text);
                y = Int32.Parse(textBox8.Text) - Int32.Parse(textBox5.Text);
                dlin = Math.Sqrt(x * x + y * y);
                okr = Math.Round(dlin, 2);
                b = okr.ToString();
                DataBank.modul = b;
            }

            else if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 1)
            {
                x = Int32.Parse(textBox4.Text);
                y = Int32.Parse(textBox5.Text);
                z = Int32.Parse(textBox6.Text);
                dlin = Math.Sqrt(x * x + y * y + z * z);
                okr = Math.Round(dlin, 2);
                b = okr.ToString();
                DataBank.modul = b;
            }
            this.Hide();
            ResultNum resNum = new ResultNum();
            resNum.Show();
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
