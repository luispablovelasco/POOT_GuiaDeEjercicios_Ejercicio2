namespace POOT_GuiaDeEjercicios_Ejercicio2
{
    partial class FrmBus
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
            this.txtmasabus = new System.Windows.Forms.TextBox();
            this.labelbus1 = new System.Windows.Forms.Label();
            this.btngastobus = new System.Windows.Forms.Button();
            this.labelpeso = new System.Windows.Forms.Label();
            this.txtmasabus2 = new System.Windows.Forms.TextBox();
            this.btnmasabus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btngastobus);
            this.tabPage1.Controls.Add(this.labelbus1);
            this.tabPage1.Controls.Add(this.txtmasabus);
            this.tabPage1.Text = "Gasto gasolina";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnmasabus);
            this.tabPage2.Controls.Add(this.txtmasabus2);
            this.tabPage2.Controls.Add(this.labelpeso);
            this.tabPage2.Text = "Peso Bus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(245, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menú Bus";
            // 
            // txtmasabus
            // 
            this.txtmasabus.Location = new System.Drawing.Point(164, 100);
            this.txtmasabus.Name = "txtmasabus";
            this.txtmasabus.Size = new System.Drawing.Size(183, 20);
            this.txtmasabus.TabIndex = 5;
            // 
            // labelbus1
            // 
            this.labelbus1.AutoSize = true;
            this.labelbus1.Location = new System.Drawing.Point(164, 143);
            this.labelbus1.Name = "labelbus1";
            this.labelbus1.Size = new System.Drawing.Size(0, 13);
            this.labelbus1.TabIndex = 6;
            // 
            // btngastobus
            // 
            this.btngastobus.Location = new System.Drawing.Point(353, 98);
            this.btngastobus.Name = "btngastobus";
            this.btngastobus.Size = new System.Drawing.Size(75, 23);
            this.btngastobus.TabIndex = 7;
            this.btngastobus.Text = "Calcular";
            this.btngastobus.UseVisualStyleBackColor = true;
            this.btngastobus.Click += new System.EventHandler(this.btngastobus_Click);
            // 
            // labelpeso
            // 
            this.labelpeso.AutoSize = true;
            this.labelpeso.Location = new System.Drawing.Point(161, 145);
            this.labelpeso.Name = "labelpeso";
            this.labelpeso.Size = new System.Drawing.Size(0, 13);
            this.labelpeso.TabIndex = 6;
            // 
            // txtmasabus2
            // 
            this.txtmasabus2.Location = new System.Drawing.Point(164, 105);
            this.txtmasabus2.Name = "txtmasabus2";
            this.txtmasabus2.Size = new System.Drawing.Size(177, 20);
            this.txtmasabus2.TabIndex = 7;
            // 
            // btnmasabus
            // 
            this.btnmasabus.Location = new System.Drawing.Point(347, 105);
            this.btnmasabus.Name = "btnmasabus";
            this.btnmasabus.Size = new System.Drawing.Size(75, 23);
            this.btnmasabus.TabIndex = 8;
            this.btnmasabus.Text = "Calcular";
            this.btnmasabus.UseVisualStyleBackColor = true;
            this.btnmasabus.Click += new System.EventHandler(this.btnmasabus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Masa del bus (Kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Para calcular el peso de un bus, debe ingresar la masa del vehículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Esta función calcula el peso de un bus\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Distancia recorrida (Km):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Para calcular el gasto de combustible, necesita ingresar un valor de la distancia" +
    " recorrida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Esta función realiza el gasto de combustible de un bus";
            // 
            // FrmBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(576, 399);
            this.Controls.Add(this.label1);
            this.Name = "FrmBus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBus_FormClosed);
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
        private System.Windows.Forms.TextBox txtmasabus;
        private System.Windows.Forms.Button btngastobus;
        private System.Windows.Forms.Label labelbus1;
        private System.Windows.Forms.Button btnmasabus;
        private System.Windows.Forms.TextBox txtmasabus2;
        private System.Windows.Forms.Label labelpeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
