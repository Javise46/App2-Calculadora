using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2_Calculadora
{
    public partial class Form1 : Form
    {
        double Resultado;
        private Operaciones op = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            
            string tipo = "";
            double n1;
            double n2;
            
            tipo = cbopcion.Text;
            n1 = double.Parse(txtb1.Text);
            n2 = double.Parse(txtb2.Text);

            if (tipo == "Suma")
            { 
                Resultado = op.Suma(n1, n2);
                
            }
            else if (tipo == "Resta")
            {
                Resultado = op.Resta(n1, n2);
            }
            else if (tipo == "Multiplicacion")
            {
                Resultado = op.Multiplicacion(n1,n2);
            }
            else if (tipo == "Division")
            {
                Resultado = op.Division(n1, n2);
            }

            lblResultado.Text = Resultado.ToString();

        }
    }
}
