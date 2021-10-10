using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    public partial class FrmCarro : POOT_GuiaDeEjercicios_Ejercicio2.FrmBaseVehiculo
    {
        public FrmCarro()
        {
            InitializeComponent();
        }

        private void btngastocarro_Click(object sender, EventArgs e)
        {
            double D = double.Parse(txtgastocarro.Text);
            double G = 0;
            double W = 0;
            double M = 0;
            Carro automovil = new Carro(G, W, M, D);
            automovil.CalcularGasto(labelgastocarro);
        }

        private void btnpesocarro_Click(object sender, EventArgs e)
        {
            double M = double.Parse(txtmasacarro.Text);
            double G = 9.8;
            double W = 0;
            double D = 0;
            Carro automovil = new Carro(G, W, M, D);
            automovil.CalcularPeso(labelpesocarro);
        }

        private void FrmCarro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
