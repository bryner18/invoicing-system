namespace Sistema_Construrama
{
    partial class ReporteGeneralFactura
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
            this.DETALLE_FACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FerreteriaDataSet2 = new Sistema_Construrama.FerreteriaDataSet2();
            this.FACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FerreteriaDataSet1 = new Sistema_Construrama.FerreteriaDataSet1();
            this.FACTURA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FerreteriaDataSet = new Sistema_Construrama.FerreteriaDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.FACTURA1TableAdapter = new Sistema_Construrama.FerreteriaDataSetTableAdapters.FACTURA1TableAdapter();
            this.FACTURATableAdapter = new Sistema_Construrama.FerreteriaDataSet1TableAdapters.FACTURATableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DETALLE_FACTURATableAdapter = new Sistema_Construrama.FerreteriaDataSet2TableAdapters.DETALLE_FACTURATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DETALLE_FACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURA1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DETALLE_FACTURABindingSource
            // 
            this.DETALLE_FACTURABindingSource.DataMember = "DETALLE_FACTURA";
            this.DETALLE_FACTURABindingSource.DataSource = this.FerreteriaDataSet2;
            // 
            // FerreteriaDataSet2
            // 
            this.FerreteriaDataSet2.DataSetName = "FerreteriaDataSet2";
            this.FerreteriaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // FACTURA1BindingSource
            // 
            this.FACTURA1BindingSource.DataMember = "FACTURA1";
            this.FACTURA1BindingSource.DataSource = this.FerreteriaDataSet;
            // 
            // FerreteriaDataSet
            // 
            this.FerreteriaDataSet.DataSetName = "FerreteriaDataSet";
            this.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FACTURA1TableAdapter
            // 
            this.FACTURA1TableAdapter.ClearBeforeFill = true;
            // 
            // FACTURATableAdapter
            // 
            this.FACTURATableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DETALLE_FACTURABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Construrama.ReporteGeneralFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(824, 492);
            this.reportViewer1.TabIndex = 2;
            // 
            // DETALLE_FACTURATableAdapter
            // 
            this.DETALLE_FACTURATableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGeneralFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 529);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "ReporteGeneralFactura";
            this.Text = "Ferreteria Construrama - Reporte General Factura";
            this.Load += new System.EventHandler(this.ReporteGeneralFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DETALLE_FACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURA1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource FACTURA1BindingSource;
        private FerreteriaDataSet FerreteriaDataSet;
        private FerreteriaDataSetTableAdapters.FACTURA1TableAdapter FACTURA1TableAdapter;
        private System.Windows.Forms.BindingSource FACTURABindingSource;
        private FerreteriaDataSet1 FerreteriaDataSet1;
        private FerreteriaDataSet1TableAdapters.FACTURATableAdapter FACTURATableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DETALLE_FACTURABindingSource;
        private FerreteriaDataSet2 FerreteriaDataSet2;
        private FerreteriaDataSet2TableAdapters.DETALLE_FACTURATableAdapter DETALLE_FACTURATableAdapter;
    }
}