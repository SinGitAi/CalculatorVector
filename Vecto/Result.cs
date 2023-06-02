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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            if (DataBank.CBIndex == 0)
            {
                label1.Text = DataBank.x;
                label2.Text = DataBank.y;
                label3.Text = DataBank.z;
                label3.Visible = true;
                label9.Visible = true;
                label7.Location = new Point(350, 97);
                if (DataBank.x.Length == 4 & DataBank.y.Length == 4 & DataBank.z.Length == 4)
                {
                    label8.Location = new Point(252, 98);
                    label2.Location = new Point(269, 103);
                    label9.Location = new Point(330, 98);
                    label3.Location = new Point(356,103);
                    label7.Location = new Point(408, 98);
                }
                else if (DataBank.x.Length == 4 & DataBank.y.Length == 4 & DataBank.z.Length == 3)
                {
                    label8.Location = new Point(252, 98);
                    label2.Location = new Point(269, 103);
                    label9.Location = new Point(330, 98);
                    label3.Location = new Point(356, 103);
                    label7.Location = new Point(397, 98);
                }
                else if (DataBank.x.Length == 4 & DataBank.y.Length == 3 & DataBank.z.Length == 3)
                {
                    label8.Location = new Point(252, 98);
                    label2.Location = new Point(269, 103);
                    label9.Location = new Point(321, 98);
                    label3.Location = new Point(344, 103);
                    label7.Location = new Point(399, 98);
                }
                else if (DataBank.x.Length == 3 & DataBank.y.Length == 4 & DataBank.z.Length == 4)
                {
                    label8.Location = new Point(235, 98);
                    label2.Location = new Point(261, 103);
                    label9.Location = new Point(309, 98);
                    label3.Location = new Point(335, 103);
                    label7.Location = new Point(399, 98);
                }
                else if (DataBank.x.Length == 3 & DataBank.y.Length == 3 & DataBank.z.Length == 4)
                {
                    label8.Location = new Point(235, 98);
                    label2.Location = new Point(261, 103);
                    label9.Location = new Point(309, 98);
                    label3.Location = new Point(335, 103);
                    label7.Location = new Point(399, 98);
                }
                else if (DataBank.x.Length == 4 & DataBank.y.Length == 3 & DataBank.z.Length == 3)
                {
                    label8.Location = new Point(246, 98);
                    label2.Location = new Point(272, 103);
                    label9.Location = new Point(324, 98);
                    label3.Location = new Point(347, 103);
                    label7.Location = new Point(399, 98);
                }
                else if (DataBank.x.Length == 3 & DataBank.y.Length == 4 & DataBank.z.Length == 3)
                {
                    label8.Location = new Point(244, 98);
                    label2.Location = new Point(270, 103);
                    label9.Location = new Point(334, 98);
                    label3.Location = new Point(360, 103);
                    label7.Location = new Point(403, 98);
                }
                else if (DataBank.x.Length == 3 & DataBank.y.Length == 3 & DataBank.z.Length == 3)
                {
                    label8.Location = new Point(244, 98);
                    label2.Location = new Point(270, 103);
                    label9.Location = new Point(322, 98);
                    label3.Location = new Point(348, 103);
                    label7.Location = new Point(400, 98);
                }
                else if (DataBank.x.Length < 3 & DataBank.y.Length < 3 & DataBank.z.Length < 3)
                {
                    label8.Location = new Point(232, 98);
                    label2.Location = new Point(258, 103);
                    label9.Location = new Point(298, 98);
                    label3.Location = new Point(324, 103);
                    label7.Location = new Point(364, 98);
                }

            }
            else
            {
                label1.Text = DataBank.x;
                label2.Text = DataBank.y;
                label3.Visible = false;
                label9.Visible = false;
                if (DataBank.x.Length == 3 & DataBank.y.Length == 3)
                {
                    label8.Location = new Point(244, 98);
                    label2.Location = new Point(270, 103);
                    label7.Location = new Point(321, 98);
                }
                else if (DataBank.x.Length == 3 & DataBank.y.Length == 4)
                {
                    label8.Location = new Point(244, 98);
                    label2.Location = new Point(270, 103);
                    label7.Location = new Point(334, 98);
                }
                else if (DataBank.x.Length == 4 & DataBank.y.Length == 3)
                {
                    label8.Location = new Point(256, 98);
                    label2.Location = new Point(282, 103);
                    label7.Location = new Point(334, 98);
                }
                else if (DataBank.x.Length == 4 & DataBank.y.Length == 4)
                {
                    label8.Location = new Point(256, 98);
                    label2.Location = new Point(282, 103);
                    label7.Location = new Point(346, 98);
                }
                else if (DataBank.x.Length < 3 & DataBank.y.Length < 3)
                {
                    label8.Location = new Point(232, 98);
                    label2.Location = new Point(258, 103);
                    label7.Location = new Point(298, 98);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu mainWind = new StartMenu();
            mainWind.Show();
        }

        private void Result_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
