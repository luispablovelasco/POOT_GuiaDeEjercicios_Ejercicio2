namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    partial class FrmCarro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgastocarro = new System.Windows.Forms.TextBox();
            this.btngastocarro = new System.Windows.Forms.Button();
            this.labelcarrogasto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasacarro = new System.Windows.Forms.TextBox();
            this.btnpesocarro = new System.Windows.Forms.Button();
            this.labelgastocarro = new System.Windows.Forms.Label();
            this.labelpesocarro = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelgastocarro);
            this.tabPage1.Controls.Add(this.labelcarrogasto);
            this.tabPage1.Controls.Add(this.btngastocarro);
            this.tabPage1.Controls.Add(this.txtgastocarro);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Text = "Gasto gasolina";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelpesocarro);
            this.tabPage2.Controls.Add(this.btnpesocarro);
            this.tabPage2.Controls.Add(this.txtmasacarro);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Text = "Peso carro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menú Carro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Distancia recorrida (Km):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Para calcular el gasto de combustible, necesita ingresar un valor de la distancia" +
    " recorrida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Esta función realiza el gasto de combustible de un carro\r\n";
            // 
            // txtgastocarro
            // 
            this.txtgastocarro.Location = new System.Drawing.Point(187, 108);
            this.txtgastocarro.Name = "txtgastocarro";
            this.txtgastocarro.Size = new System.Drawing.Size(151, 20);
            this.txtgastocarro.TabIndex = 14;
            // 
            // btngastocarro
            // 
            this.btngastocarro.Location = new System.Drawing.Point(360, 108);
            this.btngastocarro.Name = "btngastocarro";
            this.btngastocarro.Size = new System.Drawing.Size(75, 23);
            this.btngastocarro.TabIndex = 15;
            this.btngastocarro.Text = "Calcular";
            this.btngastocarro.UseVisualStyleBackColor = true;
            this.btngastocarro.Click += new System.EventHandler(this.btngastocarro_Click);
            // 
            // labelcarrogasto
            // 
            this.labelcarrogasto.AutoSize = true;
            this.labelcarrogasto.Location = new System.Drawing.Point(187, 151);
            this.labelcarrogasto.Name = "labelcarrogasto";
            this.labelcarrogasto.Size = new System.Drawing.Size(0, 13);
            this.labelcarrogasto.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Masa del carro (Kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Para calcular el peso de un carro, debe ingresar la masa del vehículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Esta función calcula el peso de un carro\r\n\r\n";
            // 
            // txtmasacarro
            // 
            this.txtmasacarro.Location = new System.Drawing.Point(186, 102);
            this.txtmasacarro.Name = "txtmasacarro";
            this.txtmasacarro.Size = new System.Drawing.Size(146, 20);
            this.txtmasacarro.TabIndex = 15;
            // 
            // btnpesocarro
            // 
            this.btnpesocarro.Location = new System.Drawing.Point(338, 102);
            this.btnpesocarro.Name = "btnpesocarro";
            this.btnpesocarro.Size = new System.Drawing.Size(75, 23);
            this.btnpesocarro.TabIndex = 16;
            this.btnpesocarro.Text = "Calcular";
            this.btnpesocarro.UseVisualStyleBackColor = true;
            this.btnpesocarro.Click += new System.EventHandler(this.btnpesocarro_Click);
            // 
            // labelgastocarro
            // 
            this.labelgastocarro.AutoSize = true;
            this.labelgastocarro.Location = new System.Drawing.Point(187, 151);
            this.labelgastocarro.Name = "labelgastocarro";
            this.labelgastocarro.Size = new System.Drawing.Size(0, 13);
            this.labelgastocarro.TabIndex = 17;
            // 
            // labelpesocarro
            // 
            this.labelpesocarro.AutoSize = true;
            this.labelpesocarro.Location = new System.Drawing.Point(186, 144);
            this.labelpesocarro.Name = "labelpesocarro";
            this.labelpesocarro.Size = new System.Drawing.Size(0, 13);
            this.labelpesocarro.TabIndex = 17;
            // 
            // FrmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(576, 399);
            this.Controls.Add(this.label1);
            this.Name = "FrmCarro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCarro_FormClosed);
            this.Controls.SetChildIndex(this.Btnsalir, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelcarrogasto;
        private System.Windows.Forms.Button btngastocarro;
        private System.Windows.Forms.TextBox txtgastocarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnpesocarro;
        private System.Windows.Forms.TextBox txtmasacarro;
        private System.Windows.Forms.Label labelgastocarro;
        private System.Windows.Forms.Label labelpesocarro;
    }
}
