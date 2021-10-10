using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    public partial class FrmBus : POOT_GuiaDeEjercicios_Ejercicio2.FrmBaseVehiculo
    {
        public FrmBus()
        {
            InitializeComponent();
        }

        private void btngastobus_Click(object sender, EventArgs e)
        {
            double D = double.Parse(txtmasabus.Text);
            double G = 0;
            double W = 0;
            double M = 0;
            Bus autobus = new Bus(G, W, M, D);
            autobus.CalcularGasto(labelbus1);
        }

        private void btnmasabus_Click(object sender, EventArgs e)
        {
            double M = double.Parse(txtmasabus2.Text);
            double G = 9.8;
            double W = 0;
            double D = 0;
            Bus autobus = new Bus(G, W, M, D);
            autobus.CalcularPeso(labelpeso);
        }

        private void FrmBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
