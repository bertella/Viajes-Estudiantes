using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViajesBotta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Viaje numeroViaje;


        private void btnRegistraViaje_Click(object sender, EventArgs e)
        {
            numeroViaje = new Viaje();

            numeroViaje.pNumeroViajes = Convert.ToInt32(txtNumViaje.Text);
            numeroViaje.pLugarDest = txtDestino.Text;
            numeroViaje.pCostoUnitario = Convert.ToDouble(txtCosto.Text);



        }


        private void btnRegistraEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante  nuevoEstudiante = new Estudiante();


            nuevoEstudiante.pLegajo = Convert.ToInt32(txtLegajo.Text);
            nuevoEstudiante.pNombre = txtNombre.Text;
            nuevoEstudiante.pEdad = Convert.ToInt32(txtEdad.Text);
            nuevoEstudiante.pSexo = rbtMasculino.Checked;
            


            if (! numeroViaje.AgregarViajero(nuevoEstudiante) )
                 MessageBox.Show("Se Registro Correctamente ");
           

        }

       

        private void btnCalculaTotal_Click(object sender, EventArgs e)
        {
            lblCostoTotal.Text += numeroViaje.CalcularCostoViaje();
        }

        private void btnCalcPorcent_Click(object sender, EventArgs e)
        {
            lblCostoTotal.Text = numeroViaje.CalcularPorcentaje()+"%";
        }
    }
}
