namespace pryChiarenzaSP3
{
    partial class frmRepuestos
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblNumRepuesto = new System.Windows.Forms.Label();
            this.txtNumRepuesto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.rdbImportado = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(47, 55);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(145, 16);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca del repuesto:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(44, 95);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(148, 16);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen del repuesto:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "P",
            "F",
            "R"});
            this.cmbMarca.Location = new System.Drawing.Point(198, 50);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(81, 21);
            this.cmbMarca.TabIndex = 2;
            // 
            // lblNumRepuesto
            // 
            this.lblNumRepuesto.AutoSize = true;
            this.lblNumRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRepuesto.Location = new System.Drawing.Point(36, 130);
            this.lblNumRepuesto.Name = "lblNumRepuesto";
            this.lblNumRepuesto.Size = new System.Drawing.Size(156, 16);
            this.lblNumRepuesto.TabIndex = 4;
            this.lblNumRepuesto.Text = "Numero del repuesto:";
            // 
            // txtNumRepuesto
            // 
            this.txtNumRepuesto.Location = new System.Drawing.Point(198, 126);
            this.txtNumRepuesto.Name = "txtNumRepuesto";
            this.txtNumRepuesto.Size = new System.Drawing.Size(93, 20);
            this.txtNumRepuesto.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(7, 169);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(185, 16);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion del repuesto:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(198, 165);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(45, 205);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(147, 16);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio del repuesto:";
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNacional.Location = new System.Drawing.Point(200, 94);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(84, 19);
            this.rdbNacional.TabIndex = 9;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "NACIONAL";
            this.rdbNacional.UseVisualStyleBackColor = true;
            // 
            // rdbImportado
            // 
            this.rdbImportado.AutoSize = true;
            this.rdbImportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbImportado.Location = new System.Drawing.Point(285, 94);
            this.rdbImportado.Name = "rdbImportado";
            this.rdbImportado.Size = new System.Drawing.Size(97, 19);
            this.rdbImportado.TabIndex = 10;
            this.rdbImportado.TabStop = true;
            this.rdbImportado.Text = "IMPORTADO";
            this.rdbImportado.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(95, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 18);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "VENTA DE REPUESTOS";
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(392, 327);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rdbImportado);
            this.Controls.Add(this.rdbNacional);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNumRepuesto);
            this.Controls.Add(this.lblNumRepuesto);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblMarca);
            this.Name = "frmRepuestos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblNumRepuesto;
        private System.Windows.Forms.TextBox txtNumRepuesto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.RadioButton rdbImportado;
        private System.Windows.Forms.Label lblTitulo;
    }
}

