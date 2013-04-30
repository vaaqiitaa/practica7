using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int punto = 0;
            if (this.jonatan.Checked)
            {
                punto++;
            }
            if (this.numeros.Text == "4")
                punto++;

            if (this.mexico.Checked)
            {
                punto++;
            }
            if (this.peru.Checked)
            {
                punto++;
            }
            DateTime fecha = this.calendario.SelectionStart;
            string fechaselecionada = fecha.ToShortDateString();
            if (fechaselecionada == "16/04/2013")
            {
                punto++;
            }
            MessageBox.Show("Tienes : " + punto + " de 5"); 



        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
