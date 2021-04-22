namespace Sistema_Construrama
{
    partial class ReporteEspecificoAlmacen
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ARTICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FerreteriaDataSet1 = new Sistema_Construrama.FerreteriaDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.ARTICULOTableAdapter = new Sistema_Construrama.FerreteriaDataSet1TableAdapters.ARTICULOTableAdapter();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCant = new System.Windows.Forms.Button();
            this.txtCantMax = new System.Windows.Forms.TextBox();
            this.txtCantMin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ReporteEspecificoAlmacenCantidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FerreteriaDataSet2 = new Sistema_Construrama.FerreteriaDataSet2();
            this.ReporteEspecificoAlmacen2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteEspecificoAlmacen2TableAdapter = new Sistema_Construrama.FerreteriaDataSet2TableAdapters.ReporteEspecificoAlmacen2TableAdapter();
            this.ReporteEspecificoAlmacenCantidadTableAdapter = new Sistema_Construrama.FerreteriaDataSet2TableAdapters.ReporteEspecificoAlmacenCantidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ARTICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEspecificoAlmacenCantidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEspecificoAlmacen2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ARTICULOBindingSource
            // 
            this.ARTICULOBindingSource.DataMember = "ARTICULO";
            this.ARTICULOBindingSource.DataSource = this.FerreteriaDataSet1;
            // 
            // FerreteriaDataSet1
            // 
            this.FerreteriaDataSet1.DataSetName = "FerreteriaDataSet1";
            this.FerreteriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 55);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reporte Especifico de Almacen";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(894, 625);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // ARTICULOTableAdapter
            // 
            this.ARTICULOTableAdapter.ClearBeforeFill = true;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.txtCantMin);
            this.gbFecha.Controls.Add(this.txtCantMax);
            this.gbFecha.Controls.Add(this.label2);
            this.gbFecha.Controls.Add(this.label1);
            this.gbFecha.Controls.Add(this.btnCant);
            this.gbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(12, 61);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(299, 113);
            this.gbFecha.TabIndex = 22;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Rango de Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maximo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Minimo";
            // 
            // btnCant
            // 
            this.btnCant.Location = new System.Drawing.Point(189, 67);
            this.btnCant.Name = "btnCant";
            this.btnCant.Size = new System.Drawing.Size(88, 32);
            this.btnCant.TabIndex = 9;
            this.btnCant.Text = "Buscar";
            this.btnCant.UseVisualStyleBackColor = true;
            this.btnCant.Click += new System.EventHandler(this.btnCant_Click);
            // 
            // txtCantMax
            // 
            this.txtCantMax.Location = new System.Drawing.Point(83, 70);
            this.txtCantMax.Name = "txtCantMax";
            this.txtCantMax.Size = new System.Drawing.Size(100, 26);
            this.txtCantMax.TabIndex = 13;
            // 
            // txtCantMin
            // 
            this.txtCantMin.Location = new System.Drawing.Point(83, 34);
            this.txtCantMin.Name = "txtCantMin";
            this.txtCantMin.Size = new System.Drawing.Size(100, 26);
            this.txtCantMin.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCodigo);
            this.groupBox2.Controls.Add(this.txtCodigoCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(317, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 113);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Codigo Cliente";
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(120, 44);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(80, 31);
            this.btnCodigo.TabIndex = 1;
            this.btnCodigo.Text = "Buscar";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(14, 49);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoCliente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecioMin);
            this.groupBox1.Controls.Add(this.txtPrecioMax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPrecio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(538, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 113);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Precio";
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.Location = new System.Drawing.Point(83, 34);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(100, 26);
            this.txtPrecioMin.TabIndex = 14;
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.Location = new System.Drawing.Point(83, 70);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(100, 26);
            this.txtPrecioMax.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Maximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minimo";
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(189, 67);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(88, 32);
            this.btnPrecio.TabIndex = 9;
            this.btnPrecio.Text = "Buscar";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteEspecificoAlmacenCantidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Construrama.ReporteEspecificoAlmacen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 180);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(952, 439);
            this.reportViewer1.TabIndex = 24;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(856, 142);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 32);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ReporteEspecificoAlmacenCantidadBindingSource
            // 
            this.ReporteEspecificoAlmacenCantidadBindingSource.DataMember = "ReporteEspecificoAlmacenCantidad";
            this.ReporteEspecificoAlmacenCantidadBindingSource.DataSource = this.FerreteriaDataSet2;
            // 
            // FerreteriaDataSet2
            // 
            this.FerreteriaDataSet2.DataSetName = "FerreteriaDataSet2";
            this.FerreteriaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteEspecificoAlmacen2BindingSource
            // 
            this.ReporteEspecificoAlmacen2BindingSource.DataMember = "ReporteEspecificoAlmacen2";
            this.ReporteEspecificoAlmacen2BindingSource.DataSource = this.FerreteriaDataSet2;
            // 
            // ReporteEspecificoAlmacen2TableAdapter
            // 
            this.ReporteEspecificoAlmacen2TableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEspecificoAlmacenCantidadTableAdapter
            // 
            this.ReporteEspecificoAlmacenCantidadTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEspecificoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(976, 653);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteEspecificoAlmacen";
            this.Text = "ReporteEspecificoAlmacen";
            this.Load += new System.EventHandler(this.ReporteEspecificoAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ARTICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEspecificoAlmacenCantidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEspecificoAlmacen2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource ARTICULOBindingSource;
        private FerreteriaDataSet1 FerreteriaDataSet1;
        private FerreteriaDataSet1TableAdapters.ARTICULOTableAdapter ARTICULOTableAdapter;
        private System.Windows.Forms.BindingSource ReporteEspecificoAlmacen2BindingSource;
        private FerreteriaDataSet2 FerreteriaDataSet2;
        private FerreteriaDataSet2TableAdapters.ReporteEspecificoAlmacen2TableAdapter ReporteEspecificoAlmacen2TableAdapter;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.TextBox txtCantMin;
        private System.Windows.Forms.TextBox txtCantMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecioMin;
        private System.Windows.Forms.TextBox txtPrecioMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrecio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteEspecificoAlmacenCantidadBindingSource;
        private FerreteriaDataSet2TableAdapters.ReporteEspecificoAlmacenCantidadTableAdapter ReporteEspecificoAlmacenCantidadTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
    }
}