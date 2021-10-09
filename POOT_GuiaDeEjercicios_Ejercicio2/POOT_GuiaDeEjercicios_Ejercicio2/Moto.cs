using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    class Moto : Vehiculo
    {

        //Definimos 2 variables propias de la clase Moto
        private double gastodfiario;
        private double kmrecorridos;

        //Re escribimos el metodo virtual para calcular el consumo de galosnes, en este caso de una moto

        public override void Calculoconsumo()
        {
            gastodfiario = (0.0044 * kmrecorridos);
            
            
        }

        public int Ruedas
        {
            get { return ruedas; }
            set { ruedas = value; }
        }

        public double Fuerzamotor
        {
            get { return fuerzamotor; }
            set { fuerzamotor = value; }
        }

    }
}
