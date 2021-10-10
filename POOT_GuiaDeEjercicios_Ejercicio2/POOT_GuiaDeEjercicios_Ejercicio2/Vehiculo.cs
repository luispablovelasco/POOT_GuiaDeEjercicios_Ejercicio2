using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    public abstract class Vehiculo
    {
        //Definimos 2 campos de acceso portegido que almacenarán datos comunes para las demas clases

        //protected double distancia;
        //protected double gravedad = 9.8; //  Km/Segundocuadrado

        protected double gastogasolina;
        protected double pesovehiculo;

        //Constructor
        public Vehiculo(double G, double W)
        {
            gastogasolina = G;
            pesovehiculo = W;
        }

        /*public Vehiculo(double W)
        {
            pesovehiculo = G;
        }*/

        //Tengo que poner en los campos que son generales, a lo que quiero encontrar, osea peso y gasto gasolina

        //Metodos virtuales
        //Definimos el método virtual para calcular Gasto de Gasolina de cada vehiculo
         public virtual void CalcularGasto(Label LR)
        {

        }

        //Definimos el metodo virtual para calcular el peso del vehiculo

        public virtual void CalcularPeso(Label LR)
        {

        }




    }
}
