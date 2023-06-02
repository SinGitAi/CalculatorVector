using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vecto
{
    public partial class Kolon : Form
    {
        ResultNum res;
        public Kolon()
        {
            InitializeComponent();
            button2.Enabled = false;
        }



        private void Kolon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu mainWind = new StartMenu();
            mainWind.Show();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex == 1)
            {
                label10.Location = new Point(247, 240);
                label7.Show();
                label7.Text = "a=";
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
                label7.Show();
                label7.Text = "A=";
                label13.Show();
                label10.Show();
                label10.Location = new Point(306, 240);
                label12.Show();
                label12.Location = new Point(306, 275);
                textBox3.Show();
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
                label8.Hide();
                label7.Show();
                label7.Text = "a=";
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
                label7.Show();
                label7.Text = "A=";
                label13.Hide();
                label16.Hide();
                textBox3.Hide();
                textBox6.Hide();
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
                label17.Show();
                label17.Text = "A=";
                label21.Show();
                textBox9.Show();
                label25.Location = new Point(557, 240);
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
                label17.Show();
                label17.Text = "b=";
                label18.Hide() ;
                label26.Hide() ;
                label22.Hide() ;
                label23.Hide() ;
                label24.Hide() ;
                textBox10.Hide() ;
                textBox11.Hide() ;
                textBox12.Hide() ;
                label21.Show() ;
                textBox9 .Show() ;
                label25 .Show() ;
                label25.Location = new Point(557, 240);
            }
            else if (comboBox1.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
            {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 1)
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0) || (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0) || (comboBox3.Text.Length == 0) || (textBox7.Text.Length == 0) || (textBox8.Text.Length == 0))
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }

            else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 0)
            {
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0) || (textBox7.Text.Length == 0) || (textBox8.Text.Length == 0) || (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0) || (comboBox3.Text.Length == 0) || (textBox4.Text.Length == 0) || (textBox5.Text.Length == 0) || (textBox10.Text.Length == 0) || (textBox11.Text.Length == 0))
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
            }

            else if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
            {
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0) || (textBox7.Text.Length == 0) || (textBox8.Text.Length == 0) || (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0) || (comboBox3.Text.Length == 0) || (textBox10.Text.Length == 0) || (textBox11.Text.Length == 0))
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
            }

            else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 1)
            {
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0) || (textBox4.Text.Length == 0) || (textBox5.Text.Length == 0) || (comboBox1.Text.Length == 0) || (comboBox2.Text.Length == 0) || (comboBox3.Text.Length == 0) || (textBox7.Text.Length == 0) || (textBox8.Text.Length == 0))
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, y, z, x1, y1, z1, rezx, rezy, rezz ;
            string a, b, c;
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text); z = Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text); z1 = Int32.Parse(textBox9.Text);
                    if(x != 0 & y != 0 & z != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0 & z != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0 & z != 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        rezz = (z * y1) / y;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y != 0 & z == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0 & z == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0 & z == 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        rezz = (z * y1) / y;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y == 0 & z != 0)
                    {
                        rezx = (x * z1) / z;
                        rezy = (y * z1) / z;
                        rezz = (z * z1) / z;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y == 0 & z == 0)
                    {
                        if (x == x1 & y == y1 & z == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    z = Int32.Parse(textBox6.Text) - Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    z1 = Int32.Parse(textBox12.Text) - Int32.Parse(textBox9.Text);
                    if (x != 0 & y != 0 & z != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0 & z != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0 & z != 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        rezz = (z * y1) / y;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y != 0 & z == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0 & z == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0 & z == 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        rezz = (z * y1) / y;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y == 0 & z != 0)
                    {
                        rezx = (x * z1) / z;
                        rezy = (y * z1) / z;
                        rezz = (z * z1) / z;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y == 0 & z == 0)
                    {
                        if (x == x1 & y == y1 & z == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    z = Int32.Parse(textBox6.Text) - Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text); z1 = Int32.Parse(textBox9.Text);
                    if (x != 0 & y != 0 & z != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0 & z != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0 & z != 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        rezz = (z * y1) / y;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y != 0 & z == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0 & z == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0 & z == 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        rezz = (z * y1) / y;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y == 0 & z != 0)
                    {
                        rezx = (x * z1) / z;
                        rezy = (y * z1) / z;
                        rezz = (z * z1) / z;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y == 0 & z == 0)
                    {
                        if (x == x1 & y == y1 & z == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                }

                else if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text); z = Int32.Parse(textBox3.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    z1 = Int32.Parse(textBox12.Text) - Int32.Parse(textBox9.Text);
                    if (x != 0 & y != 0 & z != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0 & z != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0 & z != 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        rezz = (z * y1) / y;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y != 0 & z == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0 & z == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        rezz = (z * x1) / x;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0 & z == 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        rezz = (z * y1) / y;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y == 0 & z != 0)
                    {
                        rezx = (x * z1) / z;
                        rezy = (y * z1) / z;
                        rezz = (z * z1) / z;
                        if (rezx == x1 & rezy == y1 & rezz == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y == 0 & z == 0)
                    {
                        if (x == x1 & y == y1 & z == z1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                }
            }
            else if ((comboBox1.SelectedIndex == 1))
            {
                if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text);
                    if(x == 0 & y == 0)
                    {
                        if (x == x1 & y == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if(x == 0 & y != 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if(y != 0 & x != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }

                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    if (x == 0 & y == 0)
                    {
                        if (x == x1 & y == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (y != 0 & x != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                }

                else if (comboBox2.SelectedIndex == 0 & comboBox3.SelectedIndex == 1)
                {
                    x = Int32.Parse(textBox4.Text) - Int32.Parse(textBox1.Text);
                    y = Int32.Parse(textBox5.Text) - Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox7.Text); y1 = Int32.Parse(textBox8.Text);
                    if (x == 0 & y == 0)
                    {
                        if (x == x1 & y == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (y != 0 & x != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                }

                else if (comboBox2.SelectedIndex == 1 & comboBox3.SelectedIndex == 0)
                {
                    x = Int32.Parse(textBox1.Text); y = Int32.Parse(textBox2.Text);
                    x1 = Int32.Parse(textBox10.Text) - Int32.Parse(textBox7.Text);
                    y1 = Int32.Parse(textBox11.Text) - Int32.Parse(textBox8.Text);
                    if (x == 0 & y == 0)
                    {
                        if (x == x1 & y == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x == 0 & y != 0)
                    {
                        rezx = (x * y1) / y;
                        rezy = (y * y1) / y;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (x != 0 & y == 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                    else if (y != 0 & x != 0)
                    {
                        rezx = (x * x1) / x;
                        rezy = (y * x1) / x;
                        if (rezx == x1 & rezy == y1) { DataBank.modul = "Вектора a и b коллинеарны"; }
                        else { DataBank.modul = "Вектора a и b не коллинеарны"; }
                    }
                }
            }
            this.Hide();
            res = new ResultNum();
            res.Show();
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
