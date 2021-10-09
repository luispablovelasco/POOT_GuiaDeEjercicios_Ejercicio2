using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    class Vehiculo
    {
        //Definimos 2 campos de acceso portegido que almacenarán datos comunes para las demas clases

        protected int ruedas;
        protected double fuerzamotor;

        //Definimos el método virtual para calcular cuantos galones de gasolina consumira un vehiculo
         public virtual void Calculoconsumo()
        {
            
        }


    }
}
