using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    public partial class FrmMenu : POOT_GuiaDeEjercicios_Ejercicio2.FrmBase
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void btngobus_Click(object sender, EventArgs e)
        {
            FrmBus menubus = new FrmBus();
            this.Hide();
            menubus.Show();
        }

        private void btngomoto_Click(object sender, EventArgs e)
        {
            FrmMoto menumoto = new FrmMoto();
            this.Hide();
            menumoto.Show();
        }

        private void btngocarro_Click(object sender, EventArgs e)
        {
            FrmCarro menucarro = new FrmCarro();
            this.Show();
            menucarro.Show(); 
        }
    }
}
