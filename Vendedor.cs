using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    class Vendedor : Empleado
    {
        public int cantidadVentas { get; set; }
        public double calcularBonificacionVenta()
        {
            return 10 * cantidadVentas;
        }
        public override double calcularRemuneracion()
        {
            return sueldoBasico + escolaridad() + calcularRefrigerio()+calcularBonificacionVenta();
        }
    }
}
