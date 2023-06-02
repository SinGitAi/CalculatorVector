using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vecto
{
    public partial class VectorAddSub : Form
    {
        Result res;
        public VectorAddSub()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu mainWind = new StartMenu();
            mainWind.Show();
        }




        private void VectorAddSub_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex == 1)
            {
                DataBank.CBIndex = comboBox1.SelectedIndex;
                label7.Show();
                label7.Text = "a=";
                label10.Location = new Point(247, 240);
                label13.Hide();
                textBox3.Hide();
                label8.Hide();
                label11.Hide();
                label15.Hide();
                label16.Hide();
                label12.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
            }
            else if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 0)
            {
                DataBank.CBIndex = comboBox1.SelectedIndex;
                label13.Show();
                label10.Show();
                label10.Location = new Point(306, 240);
                label12.Show();
                label12.Location = new Point(306, 275);
                textBox3.Show();
                label7.Show();
                label7.Text = "A=";
                label8.Show();
                label8.Text = "B=";
                label11.Show();
                label15.Show();
                label16.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
            }
            else if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 1)
            {
                DataBank.CBIndex = comboBox1.SelectedIndex;
                label7.Show();
                label7.Text = "a=";
                label8.Hide();
                label11.Hide();
                label15.Hide();
                label16.Hide();
                label12.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
                label13.Show();
                label10.Show();
                label10.Location = new Point(306, 240);
                textBox3.Show();
            }
            else if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex == 0)
            {
                DataBank.CBIndex = comboBox1.SelectedIndex;
                label13.Hide();
                label16.Hide();
                textBox3.Hide();
                textBox6.Hide();
                label7.Show();
                label7.Text = "A=";
                label8.Show();
                label8.Text = "B=";
                label11.Show();
                label15.Show();
                label12.Show();
                label12.Location = new Point(247, 275);
                textBox4.Show();
                textBox5.Show();
                label10.Show();
                label10.Location = new Point(247, 240);
            }
        }

        private void comboBox1_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 & comboBox3.SelectedIndex == 1)
            {
                DataBank.CBIndex = comboBox1.SelectedIndex;
                label17.Show();
                label17.Text = "b=";
                label21.Hide();
                textBox9.Hide();
                label25.Location = new Point(498, 240);
                label18.Hide();
                label26.Hide();
                label22.Hide();
                label23.Hide();
                label24.Hide();
                textBox10.Hide();
                textBox11.Hide();
                textBox12.Hide();

            }
            else if (comboBox1.SelectedIndex == 0 & comboBox3.SelectedIndex == 0)
            {
                DataBank.CBIndex = comboBox1.SelectedIndex;
                label21.Show();
                textBox9.Show();
                label25.Location = new Point(557, 240);
                label17.Show();
                label17.Text = "A=";
                label18.Show();
                label18.Text = "B=";
                label26.Show();
                label22.Show();
                label23.Show();
                label24.Show();
                label24.Location = new Point(557, 275);
                textBox10.Show();
                textBox11.Show();
                textBox12.Show();
            }
            else if (comboBox1.SelectedIndex == 0 & comboBox3.SelectedIndex == 1)
            {
                DataBank.CBIndex = comboBox1.SelectedIndex;
                label17.Show();
                label17.Text = "b=";
                label18.Hide();
                label26.Hide();
                label22.Hide();
                label23.Hide();
                label24.Hide();
                textBox10.Hide();
                textBox11.Hide();
                textBox12.Hide();
                label21.Show();
                textBox9.Show();
                label25.Show();
                label25.Location = new Point(557, 240);
            }
            else if (comboBox1.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
            {
                DataBank.CBIndex = comboBox1.SelectedIndex;
                label17.Show();
                label17.Text = "A=";
                label18.Show();
                label18.Text = "B=";
                label26.Show();
                label22.Show();
                label23.Hide();
                label24.Show();
                label24.Location = new Point(498, 275);
                textBox10.Show();
                textBox11.Show();
                textBox12.Hide();
                label21.Hide();
                label25.Show();
                label25.Location = new Point(498, 240);
                textBox9.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x,y,z,x1,y1,z1,rezx,rezy,rezz;
            string a, b, c;
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text); z = Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text); z1 = Int32.Parse(textBox9.Text);
                    rezx = x + x1;
                    rezy = y + y1;
                    rezz = z + z1;
                    a = rezx.ToString(); b = rezy.ToString(); c = rezz.ToString();
                    DataBank.x = a; DataBank.y = b; DataBank.z = c;
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    z = Int32.Parse(textBox6.Text) - Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    z1 = Int32.Parse(textBox12.Text) - Int32.Parse(textBox9.Text);
                    rezx = x + x1;
                    rezy = y + y1;
                    rezz = z + z1;
                    a = rezx.ToString(); b = rezy.ToString(); c = rezz.ToString();
                    DataBank.x = a; DataBank.y = b; DataBank.z = c;
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    z = Int32.Parse(textBox6.Text) - Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text); z1 = Int32.Parse(textBox9.Text);
                    rezx = x + x1;
                    rezy = y + y1;
                    rezz = z + z1;
                    a = rezx.ToString(); b = rezy.ToString(); c = rezz.ToString();
                    DataBank.x = a; DataBank.y = b; DataBank.z = c;
                }

                else if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text); z = Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    z1 = Int32.Parse(textBox12.Text) - Int32.Parse(textBox9.Text);
                    rezx = x + x1;
                    rezy = y + y1;
                    rezz = z + z1;
                    a = rezx.ToString(); b = rezy.ToString(); c = rezz.ToString();
                    DataBank.x = a; DataBank.y = b; DataBank.z = c;
                }
            }
            else if ((comboBox1.SelectedIndex == 1))
            {
                if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text);
                    rezx = x + x1;
                    rezy = y + y1;
                    a = rezx.ToString(); b = rezy.ToString();
                    DataBank.x = a; DataBank.y = b;
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    rezx = x + x1;
                    rezy = y + y1;
                    a = rezx.ToString(); b = rezy.ToString();
                    DataBank.x = a; DataBank.y = b;
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text);
                    rezx = x + x1;
                    rezy = y + y1;
                    a = rezx.ToString(); b = rezy.ToString();
                    DataBank.x = a; DataBank.y = b;
                }

                else if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    rezx = x + x1;
                    rezy = y + y1;
                    a = rezx.ToString(); b = rezy.ToString();
                    DataBank.x = a; DataBank.y = b;
                }
            }
            this.Hide();
            res = new Result();
            res.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, y, z, x1, y1, z1, rezx, rezy, rezz;
            string a, b, c;
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text); z = Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text); z1 = Int32.Parse(textBox9.Text);
                    rezx = x - x1;
                    rezy = y - y1;
                    rezz = z - z1;
                    a = rezx.ToString(); b = rezy.ToString(); c = rezz.ToString();
                    DataBank.x = a; DataBank.y = b; DataBank.z = c;
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text); z = Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text); z1 = Int32.Parse(textBox9.Text);
                    rezx = x - x1;
                    rezy = y - y1;
                    rezz = z - z1;
                    a = rezx.ToString(); b = rezy.ToString(); c = rezz.ToString();
                    DataBank.x = a; DataBank.y = b; DataBank.z = c;
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    z = Int32.Parse(textBox6.Text) - Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text); z1 = Int32.Parse(textBox9.Text);
                    rezx = x - x1;
                    rezy = y - y1;
                    rezz = z - z1;
                    a = rezx.ToString(); b = rezy.ToString(); c = rezz.ToString();
                    DataBank.x = a; DataBank.y = b; DataBank.z = c;
                }

                else if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text); z = Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    z1 = Int32.Parse(textBox12.Text) - Int32.Parse(textBox9.Text);
                    rezx = x - x1;
                    rezy = y - y1;
                    rezz = z - z1;
                    a = rezx.ToString(); b = rezy.ToString(); c = rezz.ToString();
                    DataBank.x = a; DataBank.y = b; DataBank.z = c;
                }
            }
            else if ((comboBox1.SelectedIndex == 1))
            {
                if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text);
                    rezx = x - x1;
                    rezy = y - y1;
                    a = rezx.ToString(); b = rezy.ToString();
                    DataBank.x = a; DataBank.y = b;
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text);
                    rezx = x - x1;
                    rezy = y - y1;
                    a = rezx.ToString(); b = rezy.ToString();
                    DataBank.x = a; DataBank.y = b;
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text);
                    rezx = x - x1;
                    rezy = y - y1;
                    a = rezx.ToString(); b = rezy.ToString();
                    DataBank.x = a; DataBank.y = b;
                }

                else if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    rezx = x - x1;
                    rezy = y - y1;
                    a = rezx.ToString(); b = rezy.ToString();
                    DataBank.x = a; DataBank.y = b;
                }
            }
            this.Hide();
            res = new Result();
            res.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 1)
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0) || (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0) || (comboBox3.Text.Length == 0) || (textBox7.Text.Length == 0) || (textBox8.Text.Length == 0))
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                }

            else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 0)
            {
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0) || (textBox7.Text.Length == 0) || (textBox8.Text.Length == 0) || (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0) || (comboBox3.Text.Length == 0) || (textBox4.Text.Length == 0) || (textBox5.Text.Length == 0) || (textBox10.Text.Length == 0) || (textBox11.Text.Length == 0))
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }

            else if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
            {
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0) || (textBox7.Text.Length == 0) || (textBox8.Text.Length == 0) || (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0) || (comboBox3.Text.Length == 0) || (textBox10.Text.Length == 0) || (textBox11.Text.Length == 0))
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }

            else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 1)
            {
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0) || (textBox4.Text.Length == 0) || (textBox5.Text.Length == 0) || (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0) || (comboBox3.Text.Length == 0) || (textBox7.Text.Length == 0) || (textBox8.Text.Length == 0))
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}



