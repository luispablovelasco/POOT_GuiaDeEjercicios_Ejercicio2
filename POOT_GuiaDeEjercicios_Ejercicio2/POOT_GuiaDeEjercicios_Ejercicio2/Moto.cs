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
        private double masaMoto;
        private double coeficienteGastoMoto = 0.1; // Galon/Kilometro;


        //Metodos virtuales reescritos
        //Reescribimos el metodo virtual para calcular el gasto de gasolina, en este caso de una moto
        public override void GastoGasolina()
        {
            double result;
            result = Distancia * coeficienteGastoMoto;
        }

        //Reescribimos el metodo virtual para calcular el pese, en este caso de una moto;
        public override void PesoVehiculo()
        {
            double result;
            result = Gravedad * masaMoto;
        }

        //Definimos las propiedades para acceder a las variable de la Clase vehiculo
        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }

        public double Gravedad
        {
            get { return gravedad; }
            set { gravedad = value; }
        }
    }
}
