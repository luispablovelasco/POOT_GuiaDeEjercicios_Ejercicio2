using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    class Carro : Vehiculo
    {

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
