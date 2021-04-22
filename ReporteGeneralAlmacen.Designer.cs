namespace Sistema_Construrama
{
    partial class ReporteGeneralAlmacen
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
            this.FerreteriaDataSet = new Sistema_Construrama.FerreteriaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.ARTICULOTableAdapter = new Sistema_Construrama.FerreteriaDataSetTableAdapters.ARTICULOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ARTICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ARTICULOBindingSource
            // 
            this.ARTICULOBindingSource.DataMember = "ARTICULO";
            this.ARTICULOBindingSource.DataSource = this.FerreteriaDataSet;
            // 
            // FerreteriaDataSet
            // 
            this.FerreteriaDataSet.DataSetName = "FerreteriaDataSet";
            this.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ARTICULOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Construrama.ReporteGeneralAlmacen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(849, 509);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ARTICULOTableAdapter
            // 
            this.ARTICULOTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGeneralAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(849, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteGeneralAlmacen";
            this.Text = "Ferreteria Construrama - Reporte General Almacen";
            this.Load += new System.EventHandler(this.ReporteGeneralAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ARTICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ARTICULOBindingSource;
        private FerreteriaDataSet FerreteriaDataSet;
        private System.Windows.Forms.Button button1;
        private FerreteriaDataSetTableAdapters.ARTICULOTableAdapter ARTICULOTableAdapter;
    }
}