namespace Sistema_Construrama
{
    partial class VentanaReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenFactura = new System.Windows.Forms.Button();
            this.btnGeneralAlmacen = new System.Windows.Forms.Button();
            this.btnGeneralCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEspFactura = new System.Windows.Forms.Button();
            this.btnEspAlmacen = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnGenFactura);
            this.groupBox1.Controls.Add(this.btnGeneralAlmacen);
            this.groupBox1.Controls.Add(this.btnGeneralCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes Generales";
            // 
            // btnGenFactura
            // 
            this.btnGenFactura.Location = new System.Drawing.Point(570, 73);
            this.btnGenFactura.Name = "btnGenFactura";
            this.btnGenFactura.Size = new System.Drawing.Size(199, 42);
            this.btnGenFactura.TabIndex = 2;
            this.btnGenFactura.Text = "Factura";
            this.btnGenFactura.UseVisualStyleBackColor = true;
            this.btnGenFactura.Click += new System.EventHandler(this.btnGenFactura_Click);
            // 
            // btnGeneralAlmacen
            // 
            this.btnGeneralAlmacen.Location = new System.Drawing.Point(317, 73);
            this.btnGeneralAlmacen.Name = "btnGeneralAlmacen";
            this.btnGeneralAlmacen.Size = new System.Drawing.Size(199, 42);
            this.btnGeneralAlmacen.TabIndex = 1;
            this.btnGeneralAlmacen.Text = "Almacen";
            this.btnGeneralAlmacen.UseVisualStyleBackColor = true;
            this.btnGeneralAlmacen.Click += new System.EventHandler(this.btnGeneralAlmacen_Click);
            // 
            // btnGeneralCliente
            // 
            this.btnGeneralCliente.Location = new System.Drawing.Point(65, 73);
            this.btnGeneralCliente.Name = "btnGeneralCliente";
            this.btnGeneralCliente.Size = new System.Drawing.Size(199, 42);
            this.btnGeneralCliente.TabIndex = 0;
            this.btnGeneralCliente.Text = "Cliente";
            this.btnGeneralCliente.UseVisualStyleBackColor = true;
            this.btnGeneralCliente.Click += new System.EventHandler(this.btnGeneralCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 60);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ventana de Reportes";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.btnEspFactura);
            this.groupBox2.Controls.Add(this.btnEspAlmacen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reportes Especificos";
            // 
            // btnEspFactura
            // 
            this.btnEspFactura.Location = new System.Drawing.Point(318, 66);
            this.btnEspFactura.Name = "btnEspFactura";
            this.btnEspFactura.Size = new System.Drawing.Size(199, 42);
            this.btnEspFactura.TabIndex = 2;
            this.btnEspFactura.Text = "Factura";
            this.btnEspFactura.UseVisualStyleBackColor = true;
            this.btnEspFactura.Click += new System.EventHandler(this.btnEspFactura_Click);
            // 
            // btnEspAlmacen
            // 
            this.btnEspAlmacen.Location = new System.Drawing.Point(65, 66);
            this.btnEspAlmacen.Name = "btnEspAlmacen";
            this.btnEspAlmacen.Size = new System.Drawing.Size(199, 42);
            this.btnEspAlmacen.TabIndex = 1;
            this.btnEspAlmacen.Text = "Almacen";
            this.btnEspAlmacen.UseVisualStyleBackColor = true;
            this.btnEspAlmacen.Click += new System.EventHandler(this.btnEspAlmacen_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(792, 454);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 32);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // VentanaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(889, 489);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaReportes";
            this.Text = "Ferreteria Construrama - Ventana de Reportes";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenFactura;
        private System.Windows.Forms.Button btnGeneralAlmacen;
        private System.Windows.Forms.Button btnGeneralCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEspFactura;
        private System.Windows.Forms.Button btnEspAlmacen;
        private System.Windows.Forms.Button btnVolver;
    }
}