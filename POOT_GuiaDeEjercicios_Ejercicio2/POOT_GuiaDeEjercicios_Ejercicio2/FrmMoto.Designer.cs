namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    partial class FrmMoto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdistanMoto = new System.Windows.Forms.TextBox();
            this.btngastoMoto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmasaMoto = new System.Windows.Forms.TextBox();
            this.btnmasaMoto = new System.Windows.Forms.Button();
            this.Labelresult = new System.Windows.Forms.Label();
            this.labelresult2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelresult2);
            this.tabPage1.Controls.Add(this.btngastoMoto);
            this.tabPage1.Controls.Add(this.txtdistanMoto);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Text = "Gasto Gasolina";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Labelresult);
            this.tabPage2.Controls.Add(this.btnmasaMoto);
            this.tabPage2.Controls.Add(this.txtmasaMoto);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Text = "Peso Moto";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(238, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menú Moto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Esta función realiza el gasto de combustible de una moto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Para calcular el gasto de combustible, necesita ingresar un valor de la distancia" +
    " recorrida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Distancia recorrida (Km):";
            // 
            // txtdistanMoto
            // 
            this.txtdistanMoto.Location = new System.Drawing.Point(191, 102);
            this.txtdistanMoto.Name = "txtdistanMoto";
            this.txtdistanMoto.Size = new System.Drawing.Size(137, 20);
            this.txtdistanMoto.TabIndex = 3;
            // 
            // btngastoMoto
            // 
            this.btngastoMoto.Location = new System.Drawing.Point(334, 100);
            this.btngastoMoto.Name = "btngastoMoto";
            this.btngastoMoto.Size = new System.Drawing.Size(75, 23);
            this.btngastoMoto.TabIndex = 4;
            this.btngastoMoto.Text = "Calcular";
            this.btngastoMoto.UseVisualStyleBackColor = true;
            this.btngastoMoto.Click += new System.EventHandler(this.btngastoMoto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Esta función calcula el peso de una moto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Para calcular el peso de una moto, debe ingresar la masa del vehículo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Masa de la moto (Kg):";
            // 
            // txtmasaMoto
            // 
            this.txtmasaMoto.Location = new System.Drawing.Point(167, 111);
            this.txtmasaMoto.Name = "txtmasaMoto";
            this.txtmasaMoto.Size = new System.Drawing.Size(169, 20);
            this.txtmasaMoto.TabIndex = 3;
            // 
            // btnmasaMoto
            // 
            this.btnmasaMoto.Location = new System.Drawing.Point(342, 109);
            this.btnmasaMoto.Name = "btnmasaMoto";
            this.btnmasaMoto.Size = new System.Drawing.Size(75, 23);
            this.btnmasaMoto.TabIndex = 4;
            this.btnmasaMoto.Text = "Calcular";
            this.btnmasaMoto.UseVisualStyleBackColor = true;
            this.btnmasaMoto.Click += new System.EventHandler(this.btnmasaMoto_Click);
            // 
            // Labelresult
            // 
            this.Labelresult.AutoSize = true;
            this.Labelresult.Location = new System.Drawing.Point(167, 158);
            this.Labelresult.Name = "Labelresult";
            this.Labelresult.Size = new System.Drawing.Size(0, 13);
            this.Labelresult.TabIndex = 6;
            // 
            // labelresult2
            // 
            this.labelresult2.AutoSize = true;
            this.labelresult2.Location = new System.Drawing.Point(252, 150);
            this.labelresult2.Name = "labelresult2";
            this.labelresult2.Size = new System.Drawing.Size(0, 13);
            this.labelresult2.TabIndex = 6;
            // 
            // FrmMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(576, 399);
            this.Controls.Add(this.label1);
            this.Name = "FrmMoto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMoto_FormClosed);
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
        private System.Windows.Forms.Button btngastoMoto;
        private System.Windows.Forms.TextBox txtdistanMoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmasaMoto;
        private System.Windows.Forms.TextBox txtmasaMoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Labelresult;
        private System.Windows.Forms.Label labelresult2;
    }
}
