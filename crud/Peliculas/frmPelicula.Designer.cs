namespace Peliculas
{
    partial class frmPelicula
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDirector = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(165, 66);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(219, 23);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre de la película";
            // 
            // lbDirector
            // 
            this.lbDirector.AutoSize = true;
            this.lbDirector.Location = new System.Drawing.Point(165, 136);
            this.lbDirector.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(82, 23);
            this.lbDirector.TabIndex = 1;
            this.lbDirector.Text = "Director";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(165, 207);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(167, 23);
            this.lbFecha.TabIndex = 2;
            this.lbFecha.Text = "Fecha de Estreno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(431, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(431, 134);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(360, 30);
            this.txtDirector.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(134, 288);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 63);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(690, 288);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(170, 63);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(411, 288);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(170, 63);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(18, 360);
            this.dgvPeliculas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.RowHeadersVisible = false;
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(1164, 246);
            this.dgvPeliculas.TabIndex = 8;
            this.dgvPeliculas.DoubleClick += new System.EventHandler(this.dgvPeliculas_DoubleClick);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(431, 198);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(360, 30);
            this.dtpFecha.TabIndex = 9;
            // 
            // frmPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbDirector);
            this.Controls.Add(this.lbNombre);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "frmPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}

