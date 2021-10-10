using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    public partial class FrmMoto : POOT_GuiaDeEjercicios_Ejercicio2.FrmBaseVehiculo
    {

        public FrmMoto()
        {
            InitializeComponent();
        }

        private void FrmMoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnmasaMoto_Click(object sender, EventArgs e)
        {

            double M = double.Parse(txtmasaMoto.Text);
            double G = 9.8;
            double W = 0;
            double D = 0;
            Moto motocicleta = new Moto(G, W, M, D);
            motocicleta.CalcularPeso(Labelresult);
            
        }

        private void btngastoMoto_Click(object sender, EventArgs e)
        {
            double D = double.Parse(txtdistanMoto.Text);
            double G = 0;
            double W = 0;
            double M = 0;
            Moto motocicleta1 = new Moto(G, W, M, D);
            motocicleta1.CalcularGasto(labelresult2);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
