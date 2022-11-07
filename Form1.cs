using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declarando Variavel
            double b = double.Parse(txbaltura.Text.ToString());
            double h = double.Parse(txbbase.Text.ToString());
            double area = double.Parse(txbbase.Text.ToString());

            //Calculando a área
            lblresultado.Text = (b * h / 2).ToString();

        }
    }
}
