using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    class Moto : Vehiculo
    {

        //Definimos 2 variables propias de la clase Moto
        private double masaMoto;
        private double distancia;


        //Constructor
        public Moto(double G, double W, double M, double D):base(G,W)
        {
            masaMoto = M;
            distancia = D;
        }


        //Metodos virtuales reescritos
        //Reescribimos el metodo virtual para calcular el gasto de gasolina, en este caso de una moto
        public override void CalcularGasto(Label LR)
        {
            
            Gastogasolina = distancia * 0.1; //El 0.1 representa el coeficiente de gasto de combustible de una moto Galon/Km
            LR.Text = "Gasto de gasolina: " + Gastogasolina + " Galones";
            
        }

        //Reescribimos el metodo virtual para calcular el pese, en este caso de una moto;
        public override void CalcularPeso(Label Peso)
        {
            
            Pesovehiculo = 9.8 * masaMoto;
            Peso.Text = "Peso de la moto: " + Pesovehiculo + " N";
        }

        //Definimos las propiedades para acceder a las variable de la Clase vehiculo
        public double Gastogasolina
        {
            get { return gastogasolina; }
            set { gastogasolina = value; }
        }

        public double Pesovehiculo
        {
            get { return pesovehiculo; }
            set { pesovehiculo = value; }
        }

        //Definimos las propiedades para acceder a las variables de la clase Moto
        public double MasaMoto
        {
            get { return masaMoto; }
            set { masaMoto = value; }
        }

        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }
    }
}
