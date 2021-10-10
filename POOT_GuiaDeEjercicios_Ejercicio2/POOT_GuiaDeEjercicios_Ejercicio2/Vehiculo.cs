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

        protected double distancia;
        protected double gravedad = 9.8; //  Km/Segundocuadrado

        //Metodos virtuales
        //Definimos el método virtual para calcular Gasto de Gasolina de cada vehiculo
         public virtual void GastoGasolina()
        {
            
        }

        public virtual void PesoVehiculo()
        {

        }


        //Definimos el metodo virtual para calcular el peso del vehiculo

        public virtual void PesoVehiculo()
        {

        }




    }
}
