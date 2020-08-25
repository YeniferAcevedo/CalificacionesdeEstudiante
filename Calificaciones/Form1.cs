using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);
            double nota3 = double.Parse(txtNota3.Text);
            double nota4 = double.Parse(txtNota4.Text);
            double nota5 = double.Parse(txtNota5.Text);
            double promedio;

            promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            lblResultado.Text = Convert.ToString(promedio);

            if (promedio > 0 && promedio <= 1.99)
            {
                lblMensaje.Text = ("Reprueba la materia sin lograr realizar proceso de recuperación.");
            }
            else if (promedio >= 1.1 && promedio <= 2.99)
            {
                lblMensaje.Text = ("Reprueba la materia y puede hacer recuperación");
            }
            else if (promedio >= 3 && promedio <= 3.99)
            {
                lblMensaje.Text = ("Aprueba la materia con plan de mejora");
            }
            else if (promedio >= 4 && promedio <= 4.59)
            {
                lblMensaje.Text = ("Buen rendimiento");
            }
            else if (promedio >= 4.6 && promedio <= 4.99)
            {
                lblMensaje.Text = ("Excelente");
            }
            else if (promedio == 5)
            {
                lblMensaje.Text = ("Graduado con honores");
            }

            lblResultado.Visible = true;
            lblMensaje.Visible = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            txtNota4.Text = string.Empty;
            txtNota5.Text = string.Empty;
            lblResultado.Text = " ";
            lblMensaje.Text = " ";
            txtNota1.Focus();
        }
    }
}
