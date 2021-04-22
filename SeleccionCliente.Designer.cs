namespace Sistema_Construrama
{
    partial class SeleccionCliente
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
            this.ferreteriaDataSet = new Sistema_Construrama.FerreteriaDataSet();
            this.ferreteriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new Sistema_Construrama.FerreteriaDataSetTableAdapters.CLIENTETableAdapter();
            this.dircliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apecliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccion de Cliente";
            // 
            // ferreteriaDataSet
            // 
            this.ferreteriaDataSet.DataSetName = "FerreteriaDataSet";
            this.ferreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ferreteriaDataSetBindingSource
            // 
            this.ferreteriaDataSetBindingSource.DataSource = this.ferreteriaDataSet;
            this.ferreteriaDataSetBindingSource.Position = 0;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.ferreteriaDataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // dircliDataGridViewTextBoxColumn
            // 
            this.dircliDataGridViewTextBoxColumn.DataPropertyName = "dir_cli";
            this.dircliDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.dircliDataGridViewTextBoxColumn.Name = "dircliDataGridViewTextBoxColumn";
            this.dircliDataGridViewTextBoxColumn.Width = 140;
            // 
            // cedcliDataGridViewTextBoxColumn
            // 
            this.cedcliDataGridViewTextBoxColumn.DataPropertyName = "ced_cli";
            this.cedcliDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedcliDataGridViewTextBoxColumn.Name = "cedcliDataGridViewTextBoxColumn";
            this.cedcliDataGridViewTextBoxColumn.Width = 105;
            // 
            // telcliDataGridViewTextBoxColumn
            // 
            this.telcliDataGridViewTextBoxColumn.DataPropertyName = "tel_cli";
            this.telcliDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telcliDataGridViewTextBoxColumn.Name = "telcliDataGridViewTextBoxColumn";
            this.telcliDataGridViewTextBoxColumn.Width = 105;
            // 
            // apecliDataGridViewTextBoxColumn
            // 
            this.apecliDataGridViewTextBoxColumn.DataPropertyName = "ape_cli";
            this.apecliDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apecliDataGridViewTextBoxColumn.Name = "apecliDataGridViewTextBoxColumn";
            // 
            // nomcliDataGridViewTextBoxColumn
            // 
            this.nomcliDataGridViewTextBoxColumn.DataPropertyName = "nom_cli";
            this.nomcliDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomcliDataGridViewTextBoxColumn.Name = "nomcliDataGridViewTextBoxColumn";
            this.nomcliDataGridViewTextBoxColumn.Width = 115;
            // 
            // idcliDataGridViewTextBoxColumn
            // 
            this.idcliDataGridViewTextBoxColumn.DataPropertyName = "id_cli";
            this.idcliDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idcliDataGridViewTextBoxColumn.Name = "idcliDataGridViewTextBoxColumn";
            this.idcliDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliDataGridViewTextBoxColumn,
            this.nomcliDataGridViewTextBoxColumn,
            this.apecliDataGridViewTextBoxColumn,
            this.telcliDataGridViewTextBoxColumn,
            this.cedcliDataGridViewTextBoxColumn,
            this.dircliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 416);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // SeleccionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(876, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "SeleccionCliente";
            this.Text = "Sistema Construrama - Seleccionar Cliente";
            this.Load += new System.EventHandler(this.SeleccionCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ferreteriaDataSetBindingSource;
        private FerreteriaDataSet ferreteriaDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private FerreteriaDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dircliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apecliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}