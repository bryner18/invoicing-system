namespace Sistema_Construrama
{
    partial class SeleccionAlmacen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferreteriaDataSet = new Sistema_Construrama.FerreteriaDataSet();
            this.aRTICULOTableAdapter = new Sistema_Construrama.FerreteriaDataSetTableAdapters.ARTICULOTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 53);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccion de Articulo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idartDataGridViewTextBoxColumn,
            this.nomartDataGridViewTextBoxColumn,
            this.cantartDataGridViewTextBoxColumn,
            this.precartDataGridViewTextBoxColumn,
            this.descartDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aRTICULOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 418);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // idartDataGridViewTextBoxColumn
            // 
            this.idartDataGridViewTextBoxColumn.DataPropertyName = "id_art";
            this.idartDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idartDataGridViewTextBoxColumn.Name = "idartDataGridViewTextBoxColumn";
            this.idartDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomartDataGridViewTextBoxColumn
            // 
            this.nomartDataGridViewTextBoxColumn.DataPropertyName = "nom_art";
            this.nomartDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomartDataGridViewTextBoxColumn.Name = "nomartDataGridViewTextBoxColumn";
            this.nomartDataGridViewTextBoxColumn.Width = 130;
            // 
            // cantartDataGridViewTextBoxColumn
            // 
            this.cantartDataGridViewTextBoxColumn.DataPropertyName = "cant_art";
            this.cantartDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantartDataGridViewTextBoxColumn.Name = "cantartDataGridViewTextBoxColumn";
            // 
            // precartDataGridViewTextBoxColumn
            // 
            this.precartDataGridViewTextBoxColumn.DataPropertyName = "prec_art";
            this.precartDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precartDataGridViewTextBoxColumn.Name = "precartDataGridViewTextBoxColumn";
            // 
            // descartDataGridViewTextBoxColumn
            // 
            this.descartDataGridViewTextBoxColumn.DataPropertyName = "desc_art";
            this.descartDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descartDataGridViewTextBoxColumn.Name = "descartDataGridViewTextBoxColumn";
            this.descartDataGridViewTextBoxColumn.Width = 250;
            // 
            // aRTICULOBindingSource
            // 
            this.aRTICULOBindingSource.DataMember = "ARTICULO";
            this.aRTICULOBindingSource.DataSource = this.ferreteriaDataSet;
            // 
            // ferreteriaDataSet
            // 
            this.ferreteriaDataSet.DataSetName = "FerreteriaDataSet";
            this.ferreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRTICULOTableAdapter
            // 
            this.aRTICULOTableAdapter.ClearBeforeFill = true;
            // 
            // SeleccionAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(876, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "SeleccionAlmacen";
            this.Text = "Ferreteria Construrama - Seleccion de Almacen";
            this.Load += new System.EventHandler(this.SeleccionAlmacen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FerreteriaDataSet ferreteriaDataSet;
        private System.Windows.Forms.BindingSource aRTICULOBindingSource;
        private FerreteriaDataSetTableAdapters.ARTICULOTableAdapter aRTICULOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descartDataGridViewTextBoxColumn;
    }
}