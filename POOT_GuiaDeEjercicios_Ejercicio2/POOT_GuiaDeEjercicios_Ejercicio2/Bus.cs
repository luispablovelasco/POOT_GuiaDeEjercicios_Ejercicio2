using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    class Bus : Vehiculo
    {
        //Definimos los campos propios de la clase Bus
        double masaBus;
        double distancia;

        //Constructor
        public Bus(double G, double W, double M, double D):base(G,W)
        {
            masaBus = M;
            distancia = D;
        }

        //Metodos virtuales reescritos
        //Reescribimos el metodo virtual para calcular el gasto de gasolina, en este caso de una moto
        public override void CalcularGasto(Label LR)
        {
            
            Gastogasolina = distancia * 0.4;
            LR.Text = "Gasto de gasolina: " + Gastogasolina + " Galones";

        }

        //Reescribimos el metodo virtual para calcular el pese, en este caso de una moto;
        public override void CalcularPeso(Label Peso)
        {
            
            Pesovehiculo = 9.8 * masaBus;
            Peso.Text = "Peso del bus: " + Pesovehiculo + " N";
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
        public double MasaBus
        {
            get { return masaBus; }
            set { masaBus = value; }
        }

        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }

    }
}
