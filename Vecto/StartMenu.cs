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
    public partial class StartMenu : Form
    {
        Form f;
        public StartMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VectorAddSub mainWind = new VectorAddSub();
            mainWind.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculCoordVectors mainWind = new CalculCoordVectors();
            mainWind.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modul mainWind = new Modul();
            mainWind.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            VectorMultiNum mainWind = new VectorMultiNum();
            mainWind.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scalyar mainWind = new Scalyar();
            mainWind.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kolon mainWind = new Kolon();
            mainWind.Show();
        }

        private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
