using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fecha_de_Nacimiento_de_una_Persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - dtpFechaNacimiento.Value.Year;
            if (fechaActual < dtpFechaNacimiento.Value.AddYears(edad)) edad--;
            lblEdad.Text = "Tienes " + edad.ToString() + " años";
        }
    }
}
