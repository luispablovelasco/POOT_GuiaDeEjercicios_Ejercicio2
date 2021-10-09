using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del programa?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)== DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
