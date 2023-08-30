using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    class Empleado : Persona,IBonificaciones, IDescuento

        
    //dar clic en foquito para implementa interfaz

    //BONIFICACIONES
    {
        public string cargo { get; set; }
        public double sueldoBasico { get; set; }
        public int numeroHijos { get; set; }

        public double calcularAFP()
        {
            return 0.12*calcularRemuneracion() ;
        }

        public double calcularEPS()
        {
            throw new NotImplementedException();
        }

        public double calcularMovilidad()
        {
            throw new NotImplementedException();
        }

        public double calcularONP()
        {
            throw new NotImplementedException();
        }

        public double calcularRefrigerio()
        {
            return 100;
        }

        public double calcularRentecion5ta()
        {
            throw new NotImplementedException();
        }

        public double escolaridad()
        {
            return numeroHijos * 250;
        }
        public virtual double calcularRemuneracion()
        {
            return sueldoBasico + escolaridad()+calcularRefrigerio();
        }
        public double sueldoNeto()
        {
            return calcularRemuneracion()-calcularAFP();
        }

        



    }
}
