namespace Sistema_Construrama
{
    partial class ReporteEspecificoFactura
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
            this.FACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FerreteriaDataSet1 = new Sistema_Construrama.FerreteriaDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.FACTURATableAdapter = new Sistema_Construrama.FerreteriaDataSet1TableAdapters.FACTURATableAdapter();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.btnFecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FerreteriaDataSet = new Sistema_Construrama.FerreteriaDataSet();
            this.ARTICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARTICULOTableAdapter = new Sistema_Construrama.FerreteriaDataSetTableAdapters.ARTICULOTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCodigoCliente = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ReporteEspecificoFacturaFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FerreteriaDataSet2 = new Sistema_Construrama.FerreteriaDataSet2();
            this.ReporteEspecificoFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteEspecificoFacturaTableAdapter = new Sistema_Construrama.FerreteriaDataSet2TableAdapters.ReporteEspecificoFacturaTableAdapter();
            this.ReporteEspecificoFacturaFechaTableAdapter = new Sistema_Construrama.FerreteriaDataSet2TableAdapters.ReporteEspecificoFacturaFechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARTICULOBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEspecificoFacturaFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEspecificoFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FACTURABindingSource
            // 
            this.FACTURABindingSource.DataMember = "FACTURA";
            this.FACTURABindingSource.DataSource = this.FerreteriaDataSet1;
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 55);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reporte Especifico de Factura";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(889, 623);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 25);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FACTURATableAdapter
            // 
            this.FACTURATableAdapter.ClearBeforeFill = true;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.label2);
            this.gbFecha.Controls.Add(this.label1);
            this.gbFecha.Controls.Add(this.btnFecha);
            this.gbFecha.Controls.Add(this.dtFecha2);
            this.gbFecha.Controls.Add(this.dtFecha1);
            this.gbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(12, 62);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(299, 164);
            this.gbFecha.TabIndex = 8;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Rango de Fechas";
            // 
            // dtFecha2
            // 
            this.dtFecha2.Location = new System.Drawing.Point(70, 68);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(200, 26);
            this.dtFecha2.TabIndex = 9;
            // 
            // dtFecha1
            // 
            this.dtFecha1.Location = new System.Drawing.Point(70, 32);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(200, 26);
            this.dtFecha1.TabIndex = 10;
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(95, 111);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(88, 32);
            this.btnFecha.TabIndex = 9;
            this.btnFecha.Text = "Buscar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Desde";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(317, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo Factura";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(11, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(117, 30);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(80, 31);
            this.btnCodigo.TabIndex = 1;
            this.btnCodigo.Text = "Buscar";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetReportesEspecificos";
            reportDataSource1.Value = this.ReporteEspecificoFacturaFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Construrama.ReporteEspecificoFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 232);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(952, 385);
            this.reportViewer1.TabIndex = 10;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FerreteriaDataSet
            // 
            this.FerreteriaDataSet.DataSetName = "FerreteriaDataSet";
            this.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ARTICULOBindingSource
            // 
            this.ARTICULOBindingSource.DataMember = "ARTICULO";
            this.ARTICULOBindingSource.DataSource = this.FerreteriaDataSet;
            // 
            // ARTICULOTableAdapter
            // 
            this.ARTICULOTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCodigoCliente);
            this.groupBox2.Controls.Add(this.txtCodigoCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(317, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 79);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Codigo Cliente";
            // 
            // btnCodigoCliente
            // 
            this.btnCodigoCliente.Location = new System.Drawing.Point(114, 30);
            this.btnCodigoCliente.Name = "btnCodigoCliente";
            this.btnCodigoCliente.Size = new System.Drawing.Size(80, 31);
            this.btnCodigoCliente.TabIndex = 1;
            this.btnCodigoCliente.Text = "Buscar";
            this.btnCodigoCliente.UseVisualStyleBackColor = true;
            this.btnCodigoCliente.Click += new System.EventHandler(this.btnCodigoCliente_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(8, 32);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoCliente.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(613, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteEspecificoFacturaFechaBindingSource
            // 
            this.ReporteEspecificoFacturaFechaBindingSource.DataMember = "ReporteEspecificoFacturaFecha";
            this.ReporteEspecificoFacturaFechaBindingSource.DataSource = this.FerreteriaDataSet2;
            // 
            // FerreteriaDataSet2
            // 
            this.FerreteriaDataSet2.DataSetName = "FerreteriaDataSet2";
            this.FerreteriaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteEspecificoFacturaBindingSource
            // 
            this.ReporteEspecificoFacturaBindingSource.DataMember = "ReporteEspecificoFactura";
            this.ReporteEspecificoFacturaBindingSource.DataSource = this.FerreteriaDataSet2;
            // 
            // ReporteEspecificoFacturaTableAdapter
            // 
            this.ReporteEspecificoFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEspecificoFacturaFechaTableAdapter
            // 
            this.ReporteEspecificoFacturaFechaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEspecificoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(976, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteEspecificoFactura";
            this.Text = "ReporteEspecificoFactura";
            this.Load += new System.EventHandler(this.ReporteEspecificoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARTICULOBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEspecificoFacturaFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEspecificoFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource FACTURABindingSource;
        private FerreteriaDataSet1 FerreteriaDataSet1;
        private FerreteriaDataSet1TableAdapters.FACTURATableAdapter FACTURATableAdapter;
        private System.Windows.Forms.BindingSource ReporteEspecificoFacturaBindingSource;
        private FerreteriaDataSet2 FerreteriaDataSet2;
        private FerreteriaDataSet2TableAdapters.ReporteEspecificoFacturaTableAdapter ReporteEspecificoFacturaTableAdapter;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ARTICULOBindingSource;
        private FerreteriaDataSet FerreteriaDataSet;
        private FerreteriaDataSetTableAdapters.ARTICULOTableAdapter ARTICULOTableAdapter;
        private System.Windows.Forms.BindingSource ReporteEspecificoFacturaFechaBindingSource;
        private FerreteriaDataSet2TableAdapters.ReporteEspecificoFacturaFechaTableAdapter ReporteEspecificoFacturaFechaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCodigoCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Button button1;
    }
}