namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btngobus = new System.Windows.Forms.Button();
            this.btngomoto = new System.Windows.Forms.Button();
            this.btngocarro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(507, 288);
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // btngobus
            // 
            this.btngobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngobus.Location = new System.Drawing.Point(93, 167);
            this.btngobus.Name = "btngobus";
            this.btngobus.Size = new System.Drawing.Size(96, 39);
            this.btngobus.TabIndex = 1;
            this.btngobus.Text = "Bus";
            this.btngobus.UseVisualStyleBackColor = true;
            this.btngobus.Click += new System.EventHandler(this.btngobus_Click);
            // 
            // btngomoto
            // 
            this.btngomoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngomoto.Location = new System.Drawing.Point(244, 167);
            this.btngomoto.Name = "btngomoto";
            this.btngomoto.Size = new System.Drawing.Size(96, 39);
            this.btngomoto.TabIndex = 2;
            this.btngomoto.Text = "Moto";
            this.btngomoto.UseVisualStyleBackColor = true;
            this.btngomoto.Click += new System.EventHandler(this.btngomoto_Click);
            // 
            // btngocarro
            // 
            this.btngocarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngocarro.Location = new System.Drawing.Point(400, 167);
            this.btngocarro.Name = "btngocarro";
            this.btngocarro.Size = new System.Drawing.Size(96, 39);
            this.btngocarro.TabIndex = 3;
            this.btngocarro.Text = "Carro";
            this.btngocarro.UseVisualStyleBackColor = true;
            this.btngocarro.Click += new System.EventHandler(this.btngocarro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(206, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menú Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bienvenido al programa correspondiente al ejercicio 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Por favor, elija el tipo de vehiculo en el cual quiera evaluar su funcionamiento:" +
    " ";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(594, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngocarro);
            this.Controls.Add(this.btngomoto);
            this.Controls.Add(this.btngobus);
            this.Name = "FrmMenu";
            this.Text = "Menú";
            this.Controls.SetChildIndex(this.Btnsalir, 0);
            this.Controls.SetChildIndex(this.btngobus, 0);
            this.Controls.SetChildIndex(this.btngomoto, 0);
            this.Controls.SetChildIndex(this.btngocarro, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngobus;
        private System.Windows.Forms.Button btngomoto;
        private System.Windows.Forms.Button btngocarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
