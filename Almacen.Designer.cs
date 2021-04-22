namespace Sistema_Construrama
{
    partial class Almacen
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecArt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescArt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantArt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProvArt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferreteriaDataSet = new Sistema_Construrama.FerreteriaDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.ferreteriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRTICULOTableAdapter = new Sistema_Construrama.FerreteriaDataSetTableAdapters.ARTICULOTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 60);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "ALMACEN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecArt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDescArt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCantArt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomArt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProvArt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(513, 137);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txtPrecArt
            // 
            this.txtPrecArt.Location = new System.Drawing.Point(304, 60);
            this.txtPrecArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecArt.Name = "txtPrecArt";
            this.txtPrecArt.Size = new System.Drawing.Size(200, 26);
            this.txtPrecArt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio";
            // 
            // txtDescArt
            // 
            this.txtDescArt.Location = new System.Drawing.Point(91, 95);
            this.txtDescArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescArt.Name = "txtDescArt";
            this.txtDescArt.Size = new System.Drawing.Size(413, 26);
            this.txtDescArt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrip.";
            // 
            // txtCantArt
            // 
            this.txtCantArt.Location = new System.Drawing.Point(91, 60);
            this.txtCantArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantArt.Name = "txtCantArt";
            this.txtCantArt.Size = new System.Drawing.Size(132, 26);
            this.txtCantArt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // txtNomArt
            // 
            this.txtNomArt.Location = new System.Drawing.Point(304, 26);
            this.txtNomArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomArt.Name = "txtNomArt";
            this.txtNomArt.Size = new System.Drawing.Size(200, 26);
            this.txtNomArt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtProvArt
            // 
            this.txtProvArt.Location = new System.Drawing.Point(91, 26);
            this.txtProvArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvArt.Name = "txtProvArt";
            this.txtProvArt.Size = new System.Drawing.Size(132, 26);
            this.txtProvArt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Artic.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(544, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(231, 137);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acción a Realizar";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(9, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(117, 84);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 34);
            this.button6.TabIndex = 3;
            this.button6.Text = "Limpiar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(115, 30);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Deshabilitar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 213);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(756, 342);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idartDataGridViewTextBoxColumn,
            this.nomartDataGridViewTextBoxColumn,
            this.cantartDataGridViewTextBoxColumn,
            this.precartDataGridViewTextBoxColumn,
            this.descartDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aRTICULOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(748, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // idartDataGridViewTextBoxColumn
            // 
            this.idartDataGridViewTextBoxColumn.DataPropertyName = "id_art";
            this.idartDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idartDataGridViewTextBoxColumn.Name = "idartDataGridViewTextBoxColumn";
            this.idartDataGridViewTextBoxColumn.ReadOnly = true;
            this.idartDataGridViewTextBoxColumn.Width = 55;
            // 
            // nomartDataGridViewTextBoxColumn
            // 
            this.nomartDataGridViewTextBoxColumn.DataPropertyName = "nom_art";
            this.nomartDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomartDataGridViewTextBoxColumn.Name = "nomartDataGridViewTextBoxColumn";
            this.nomartDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomartDataGridViewTextBoxColumn.Width = 120;
            // 
            // cantartDataGridViewTextBoxColumn
            // 
            this.cantartDataGridViewTextBoxColumn.DataPropertyName = "cant_art";
            this.cantartDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantartDataGridViewTextBoxColumn.Name = "cantartDataGridViewTextBoxColumn";
            this.cantartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precartDataGridViewTextBoxColumn
            // 
            this.precartDataGridViewTextBoxColumn.DataPropertyName = "prec_art";
            this.precartDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precartDataGridViewTextBoxColumn.Name = "precartDataGridViewTextBoxColumn";
            this.precartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descartDataGridViewTextBoxColumn
            // 
            this.descartDataGridViewTextBoxColumn.DataPropertyName = "desc_art";
            this.descartDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descartDataGridViewTextBoxColumn.Name = "descartDataGridViewTextBoxColumn";
            this.descartDataGridViewTextBoxColumn.ReadOnly = true;
            this.descartDataGridViewTextBoxColumn.Width = 180;
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
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(675, 565);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 22;
            this.button7.Text = "Volver";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ferreteriaDataSetBindingSource
            // 
            this.ferreteriaDataSetBindingSource.DataSource = this.ferreteriaDataSet;
            this.ferreteriaDataSetBindingSource.Position = 0;
            // 
            // aRTICULOTableAdapter
            // 
            this.aRTICULOTableAdapter.ClearBeforeFill = true;
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(788, 606);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Almacen";
            this.Text = "Ferreteria Construrama - Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecArt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantArt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProvArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource ferreteriaDataSetBindingSource;
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