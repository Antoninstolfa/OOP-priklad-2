using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Příklad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelclovek1.Text = "";
            labelclovek2.Text = "";
            odpoved.Text = "";
            int vek; 
            string jmeno1 = textBox1.Text;
            string jmeno2 = textBox2.Text;
            try
            {
                DateTime vek1 = Convert.ToDateTime(maskedTextBox1.Text);
                DateTime vek2 = Convert.ToDateTime(maskedTextBox2.Text);
                Clovek clovek1 = new Clovek(jmeno1, vek1);
                Clovek clovek2 = new Clovek(jmeno2, vek2);
                clovek1.Vek();
                clovek2.Vek();
                labelclovek1.Text = clovek1.ToString();
                labelclovek2.Text =  clovek2.ToString();
                odpoved.Text = clovek1.Starsi(clovek1, clovek2);
            }
            catch 
            {
                MessageBox.Show("Zadejte všechny parametry správně!");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }
    }
}
