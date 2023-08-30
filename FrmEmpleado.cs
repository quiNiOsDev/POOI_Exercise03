using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio03
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado()
            {
               dni= txtDNI.Text,
               nombre= txtNombre.Text,
               cargo= txtCargo.Text,
               numeroHijos=int.Parse(txtCantHijos.Text),
               sueldoBasico=Double.Parse(txtSBasico.Text),  
            };
            txtEscolaridad.Text=empleado.escolaridad().ToString();
            txtRefrigerio.Text=empleado.calcularRefrigerio().ToString();
            txtRemuneracion.Text = empleado.calcularRemuneracion().ToString();
            txtAFP.Text=empleado.calcularAFP().ToString();
            txtSNeto.Text=empleado.sueldoNeto().ToString(); 

        }

        private void btnCalcularVendedor_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor()
            {
                dni = txtDNI.Text,
                nombre = txtNombre.Text,
                cargo = txtCargo.Text,
                numeroHijos = int.Parse(txtCantHijos.Text),
                sueldoBasico = Double.Parse(txtSBasico.Text),
                cantidadVentas= int.Parse(txtVentas.Text),
            };
            txtEscolaridad.Text = vendedor.escolaridad().ToString();
            txtRefrigerio.Text = vendedor.calcularRefrigerio().ToString();
            txtRemuneracion.Text = vendedor.calcularRemuneracion().ToString();
            txtAFP.Text = vendedor.calcularAFP().ToString();
            txtSNeto.Text = vendedor.sueldoNeto().ToString();

        }
    }
}
