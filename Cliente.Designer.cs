namespace Sistema_Construrama
{
    partial class Cliente
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
            System.Windows.Forms.Label nom_cliLabel;
            System.Windows.Forms.Label ape_cliLabel;
            System.Windows.Forms.Label tel_cliLabel;
            System.Windows.Forms.Label ced_cliLabel;
            System.Windows.Forms.Label dir_cliLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nom_cliTextBox = new System.Windows.Forms.TextBox();
            this.ape_cliTextBox = new System.Windows.Forms.TextBox();
            this.tel_cliTextBox = new System.Windows.Forms.TextBox();
            this.ced_cliTextBox = new System.Windows.Forms.TextBox();
            this.dir_cliTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cLIENTEDataGridView = new System.Windows.Forms.DataGridView();
            this.idcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apecliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dircliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ferreteriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferreteriaDataSet = new Sistema_Construrama.FerreteriaDataSet();
            this.cLIENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.cLIENTETableAdapter = new Sistema_Construrama.FerreteriaDataSetTableAdapters.CLIENTETableAdapter();
            this.cLIENTEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            nom_cliLabel = new System.Windows.Forms.Label();
            ape_cliLabel = new System.Windows.Forms.Label();
            tel_cliLabel = new System.Windows.Forms.Label();
            ced_cliLabel = new System.Windows.Forms.Label();
            dir_cliLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_cliLabel
            // 
            nom_cliLabel.AutoSize = true;
            nom_cliLabel.Location = new System.Drawing.Point(17, 31);
            nom_cliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nom_cliLabel.Name = "nom_cliLabel";
            nom_cliLabel.Size = new System.Drawing.Size(73, 20);
            nom_cliLabel.TabIndex = 2;
            nom_cliLabel.Text = "Nombre:";
            nom_cliLabel.Click += new System.EventHandler(this.nom_cliLabel_Click);
            // 
            // ape_cliLabel
            // 
            ape_cliLabel.AutoSize = true;
            ape_cliLabel.Location = new System.Drawing.Point(17, 61);
            ape_cliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ape_cliLabel.Name = "ape_cliLabel";
            ape_cliLabel.Size = new System.Drawing.Size(73, 20);
            ape_cliLabel.TabIndex = 4;
            ape_cliLabel.Text = "Apellido:";
            // 
            // tel_cliLabel
            // 
            tel_cliLabel.AutoSize = true;
            tel_cliLabel.Location = new System.Drawing.Point(283, 30);
            tel_cliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tel_cliLabel.Name = "tel_cliLabel";
            tel_cliLabel.Size = new System.Drawing.Size(46, 20);
            tel_cliLabel.TabIndex = 6;
            tel_cliLabel.Text = "Tele:";
            // 
            // ced_cliLabel
            // 
            ced_cliLabel.AutoSize = true;
            ced_cliLabel.Location = new System.Drawing.Point(275, 62);
            ced_cliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ced_cliLabel.Name = "ced_cliLabel";
            ced_cliLabel.Size = new System.Drawing.Size(66, 20);
            ced_cliLabel.TabIndex = 8;
            ced_cliLabel.Text = "Cedula:";
            // 
            // dir_cliLabel
            // 
            dir_cliLabel.AutoSize = true;
            dir_cliLabel.Location = new System.Drawing.Point(17, 94);
            dir_cliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dir_cliLabel.Name = "dir_cliLabel";
            dir_cliLabel.Size = new System.Drawing.Size(55, 20);
            dir_cliLabel.TabIndex = 10;
            dir_cliLabel.Text = "Direc:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 60);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nom_cliLabel);
            this.groupBox1.Controls.Add(this.nom_cliTextBox);
            this.groupBox1.Controls.Add(ape_cliLabel);
            this.groupBox1.Controls.Add(this.ape_cliTextBox);
            this.groupBox1.Controls.Add(tel_cliLabel);
            this.groupBox1.Controls.Add(this.tel_cliTextBox);
            this.groupBox1.Controls.Add(ced_cliLabel);
            this.groupBox1.Controls.Add(this.ced_cliTextBox);
            this.groupBox1.Controls.Add(dir_cliLabel);
            this.groupBox1.Controls.Add(this.dir_cliTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(579, 137);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // nom_cliTextBox
            // 
            this.nom_cliTextBox.Location = new System.Drawing.Point(96, 27);
            this.nom_cliTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nom_cliTextBox.Name = "nom_cliTextBox";
            this.nom_cliTextBox.Size = new System.Drawing.Size(179, 26);
            this.nom_cliTextBox.TabIndex = 3;
            // 
            // ape_cliTextBox
            // 
            this.ape_cliTextBox.Location = new System.Drawing.Point(96, 57);
            this.ape_cliTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ape_cliTextBox.Name = "ape_cliTextBox";
            this.ape_cliTextBox.Size = new System.Drawing.Size(169, 26);
            this.ape_cliTextBox.TabIndex = 5;
            // 
            // tel_cliTextBox
            // 
            this.tel_cliTextBox.Location = new System.Drawing.Point(335, 27);
            this.tel_cliTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tel_cliTextBox.Name = "tel_cliTextBox";
            this.tel_cliTextBox.Size = new System.Drawing.Size(214, 26);
            this.tel_cliTextBox.TabIndex = 7;
            // 
            // ced_cliTextBox
            // 
            this.ced_cliTextBox.Location = new System.Drawing.Point(350, 58);
            this.ced_cliTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ced_cliTextBox.Name = "ced_cliTextBox";
            this.ced_cliTextBox.Size = new System.Drawing.Size(199, 26);
            this.ced_cliTextBox.TabIndex = 9;
            // 
            // dir_cliTextBox
            // 
            this.dir_cliTextBox.Location = new System.Drawing.Point(78, 89);
            this.dir_cliTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dir_cliTextBox.Name = "dir_cliTextBox";
            this.dir_cliTextBox.Size = new System.Drawing.Size(471, 26);
            this.dir_cliTextBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(600, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(231, 137);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acción a Realizar";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(9, 82);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 39);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(117, 37);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 39);
            this.button6.TabIndex = 3;
            this.button6.Text = "Limpiar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cLIENTEDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 215);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(821, 342);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // cLIENTEDataGridView
            // 
            this.cLIENTEDataGridView.AllowUserToAddRows = false;
            this.cLIENTEDataGridView.AllowUserToDeleteRows = false;
            this.cLIENTEDataGridView.AllowUserToResizeColumns = false;
            this.cLIENTEDataGridView.AllowUserToResizeRows = false;
            this.cLIENTEDataGridView.AutoGenerateColumns = false;
            this.cLIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliDataGridViewTextBoxColumn,
            this.nomcliDataGridViewTextBoxColumn,
            this.apecliDataGridViewTextBoxColumn,
            this.telcliDataGridViewTextBoxColumn,
            this.cedcliDataGridViewTextBoxColumn,
            this.dircliDataGridViewTextBoxColumn});
            this.cLIENTEDataGridView.DataSource = this.cLIENTEBindingSource3;
            this.cLIENTEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLIENTEDataGridView.Location = new System.Drawing.Point(4, 23);
            this.cLIENTEDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.cLIENTEDataGridView.Name = "cLIENTEDataGridView";
            this.cLIENTEDataGridView.ReadOnly = true;
            this.cLIENTEDataGridView.RowHeadersVisible = false;
            this.cLIENTEDataGridView.Size = new System.Drawing.Size(813, 315);
            this.cLIENTEDataGridView.TabIndex = 1;
            this.cLIENTEDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cLIENTEDataGridView_CellContentClick_1);
            // 
            // idcliDataGridViewTextBoxColumn
            // 
            this.idcliDataGridViewTextBoxColumn.DataPropertyName = "id_cli";
            this.idcliDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idcliDataGridViewTextBoxColumn.Name = "idcliDataGridViewTextBoxColumn";
            this.idcliDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcliDataGridViewTextBoxColumn.Width = 40;
            // 
            // nomcliDataGridViewTextBoxColumn
            // 
            this.nomcliDataGridViewTextBoxColumn.DataPropertyName = "nom_cli";
            this.nomcliDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomcliDataGridViewTextBoxColumn.Name = "nomcliDataGridViewTextBoxColumn";
            this.nomcliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apecliDataGridViewTextBoxColumn
            // 
            this.apecliDataGridViewTextBoxColumn.DataPropertyName = "ape_cli";
            this.apecliDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apecliDataGridViewTextBoxColumn.Name = "apecliDataGridViewTextBoxColumn";
            this.apecliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telcliDataGridViewTextBoxColumn
            // 
            this.telcliDataGridViewTextBoxColumn.DataPropertyName = "tel_cli";
            this.telcliDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telcliDataGridViewTextBoxColumn.Name = "telcliDataGridViewTextBoxColumn";
            this.telcliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedcliDataGridViewTextBoxColumn
            // 
            this.cedcliDataGridViewTextBoxColumn.DataPropertyName = "ced_cli";
            this.cedcliDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedcliDataGridViewTextBoxColumn.Name = "cedcliDataGridViewTextBoxColumn";
            this.cedcliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dircliDataGridViewTextBoxColumn
            // 
            this.dircliDataGridViewTextBoxColumn.DataPropertyName = "dir_cli";
            this.dircliDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.dircliDataGridViewTextBoxColumn.Name = "dircliDataGridViewTextBoxColumn";
            this.dircliDataGridViewTextBoxColumn.ReadOnly = true;
            this.dircliDataGridViewTextBoxColumn.Width = 210;
            // 
            // cLIENTEBindingSource3
            // 
            this.cLIENTEBindingSource3.DataMember = "CLIENTE";
            this.cLIENTEBindingSource3.DataSource = this.ferreteriaDataSetBindingSource;
            // 
            // ferreteriaDataSetBindingSource
            // 
            this.ferreteriaDataSetBindingSource.DataSource = this.ferreteriaDataSet;
            this.ferreteriaDataSetBindingSource.Position = 0;
            // 
            // ferreteriaDataSet
            // 
            this.ferreteriaDataSet.DataSetName = "FerreteriaDataSet";
            this.ferreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource1
            // 
            this.cLIENTEBindingSource1.DataMember = "CLIENTE";
            this.cLIENTEBindingSource1.DataSource = this.ferreteriaDataSetBindingSource;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.ferreteriaDataSetBindingSource;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(740, 561);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 32);
            this.button7.TabIndex = 21;
            this.button7.Text = "Volver";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTEBindingSource2
            // 
            this.cLIENTEBindingSource2.DataMember = "CLIENTE";
            this.cLIENTEBindingSource2.DataSource = this.ferreteriaDataSet;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(853, 598);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Cliente";
            this.Text = "Ferreteria Construrama - Clientes";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nom_cliTextBox;
        private System.Windows.Forms.TextBox ape_cliTextBox;
        private System.Windows.Forms.TextBox tel_cliTextBox;
        private System.Windows.Forms.TextBox ced_cliTextBox;
        private System.Windows.Forms.TextBox dir_cliTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource ferreteriaDataSetBindingSource;
        private FerreteriaDataSet ferreteriaDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private FerreteriaDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource1;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource2;
        private System.Windows.Forms.DataGridView cLIENTEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apecliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dircliDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource3;
    }
}