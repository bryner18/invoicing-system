namespace Sistema_Construrama
{
    partial class ReporteGeneralCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FerreteriaDataSet = new Sistema_Construrama.FerreteriaDataSet();
            this.CLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CLIENTETableAdapter = new Sistema_Construrama.FerreteriaDataSetTableAdapters.CLIENTETableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.CLIENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Construrama.ReporteGeneralCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(904, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // FerreteriaDataSet
            // 
            this.FerreteriaDataSet.DataSetName = "FerreteriaDataSet";
            this.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CLIENTEBindingSource
            // 
            this.CLIENTEBindingSource.DataMember = "CLIENTE";
            this.CLIENTEBindingSource.DataSource = this.FerreteriaDataSet;
            // 
            // CLIENTETableAdapter
            // 
            this.CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReporteGeneralCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 539);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteGeneralCliente";
            this.Text = "Ferretiera Construrama - Reporte General Cliente";
            this.Load += new System.EventHandler(this.ReporteGeneralCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FerreteriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CLIENTEBindingSource;
        private FerreteriaDataSet FerreteriaDataSet;
        private FerreteriaDataSetTableAdapters.CLIENTETableAdapter CLIENTETableAdapter;
        private System.Windows.Forms.Button button2;
    }
}