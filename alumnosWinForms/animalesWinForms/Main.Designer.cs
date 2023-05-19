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
            this.gridAnimales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAnimales
            // 
            this.gridAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnimales.Location = new System.Drawing.Point(25, 97);
            this.gridAnimales.Name = "gridAnimales";
            this.gridAnimales.Size = new System.Drawing.Size(750, 283);
            this.gridAnimales.TabIndex = 0;
            this.gridAnimales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(123, 40);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(422, 33);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(577, 40);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(91, 35);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Buscar";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(685, 40);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(90, 35);
            this.btncreate.TabIndex = 4;
            this.btncreate.Text = "Crear";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAnimales);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridAnimales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAnimales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btncreate;
    }
}

