using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaPrvaWindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int brojA, brojB, zbroj;
            try { 
                brojA = Convert.ToInt32(txtUnosBrojaA.Text);
                brojB = Convert.ToInt32(txtUnosBrojaB.Text);
                zbroj = brojA + brojB;

                txtRezultat.Text = Convert.ToString(zbroj);
            }
            catch(Exception grska) 
            {
                string text = "Molim upisati broj. \n"+grska.Message;
                string naslov = "Pogrešan unos";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(text, naslov, buttons, icon);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
