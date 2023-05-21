namespace animalesWinForms
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridAnimales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnimales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAnimales
            // 
            this.gridAnimales.AutoGenerateColumns = false;
            this.gridAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnimales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.calleDataGridViewTextBoxColumn,
            this.numerocalleDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.gridAnimales.DataSource = this.alumnosBindingSource;
            this.gridAnimales.Location = new System.Drawing.Point(28, 120);
            this.gridAnimales.Margin = new System.Windows.Forms.Padding(4);
            this.gridAnimales.Name = "gridAnimales";
            this.gridAnimales.RowHeadersWidth = 51;
            this.gridAnimales.Size = new System.Drawing.Size(1005, 354);
            this.gridAnimales.TabIndex = 0;
            this.gridAnimales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(164, 49);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(561, 39);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(769, 49);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(121, 43);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Buscar";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(913, 49);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(120, 43);
            this.btncreate.TabIndex = 4;
            this.btncreate.Text = "Crear";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataSource = typeof(animalesWinForms.Alumnos);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 80;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 80;
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            this.fechanacimientoDataGridViewTextBoxColumn.Width = 140;
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            this.provinciaDataGridViewTextBoxColumn.Width = 80;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.Width = 80;
            // 
            // calleDataGridViewTextBoxColumn
            // 
            this.calleDataGridViewTextBoxColumn.DataPropertyName = "Calle";
            this.calleDataGridViewTextBoxColumn.HeaderText = "Calle";
            this.calleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            this.calleDataGridViewTextBoxColumn.Width = 80;
            // 
            // numerocalleDataGridViewTextBoxColumn
            // 
            this.numerocalleDataGridViewTextBoxColumn.DataPropertyName = "Numero_calle";
            this.numerocalleDataGridViewTextBoxColumn.HeaderText = "Numero_calle";
            this.numerocalleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numerocalleDataGridViewTextBoxColumn.Name = "numerocalleDataGridViewTextBoxColumn";
            this.numerocalleDataGridViewTextBoxColumn.Width = 120;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            this.Editar.Width = 80;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            this.Eliminar.Width = 80;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAnimales);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridAnimales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAnimales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}

