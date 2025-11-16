namespace cpProLimp
{
    partial class FrmVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUsuari = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblEmplead = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbxListaVenta = new System.Windows.Forms.GroupBox();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.gbxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxListaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1443, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ventas - ProLimp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(23, 78);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(96, 76);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(183, 26);
            this.cbxCliente.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(1226, 38);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(87, 24);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblUsuari
            // 
            this.lblUsuari.AutoSize = true;
            this.lblUsuari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuari.Location = new System.Drawing.Point(1319, 38);
            this.lblUsuari.Name = "lblUsuari";
            this.lblUsuari.Size = new System.Drawing.Size(109, 24);
            this.lblUsuari.TabIndex = 12;
            this.lblUsuari.Text = "Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nueva venta:";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(1231, 78);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(183, 24);
            this.dtpFechaVenta.TabIndex = 15;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(1074, 82);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(142, 20);
            this.lblFechaVenta.TabIndex = 14;
            this.lblFechaVenta.Text = "Fecha de Venta:";
            // 
            // lblEmplead
            // 
            this.lblEmplead.AutoSize = true;
            this.lblEmplead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplead.Location = new System.Drawing.Point(123, 117);
            this.lblEmplead.Name = "lblEmplead";
            this.lblEmplead.Size = new System.Drawing.Size(92, 20);
            this.lblEmplead.TabIndex = 17;
            this.lblEmplead.Text = "Vendedor:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(23, 117);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(94, 20);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1193, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1319, 117);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 25);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total:";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(175, 145);
            this.txtParametro.Multiline = true;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(191, 27);
            this.txtParametro.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Buscar producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(753, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Detalle de Venta:";
            // 
            // gbxListado
            // 
            this.gbxListado.Controls.Add(this.dgvLista);
            this.gbxListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListado.Location = new System.Drawing.Point(16, 186);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(688, 433);
            this.gbxListado.TabIndex = 24;
            this.gbxListado.TabStop = false;
            this.gbxListado.Text = "Lista de Productos";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(11, 23);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(671, 395);
            this.dgvLista.TabIndex = 0;
            // 
            // gbxListaVenta
            // 
            this.gbxListaVenta.Controls.Add(this.dgvVenta);
            this.gbxListaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListaVenta.Location = new System.Drawing.Point(758, 184);
            this.gbxListaVenta.Name = "gbxListaVenta";
            this.gbxListaVenta.Size = new System.Drawing.Size(625, 435);
            this.gbxListaVenta.TabIndex = 25;
            this.gbxListaVenta.TabStop = false;
            this.gbxListaVenta.Text = "ProLimp";
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(6, 25);
            this.dgvVenta.MultiSelect = false;
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(613, 405);
            this.dgvVenta.TabIndex = 0;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnRegistrar);
            this.pnlAcciones.Controls.Add(this.btnCancelar);
            this.pnlAcciones.Controls.Add(this.btnLimpiar);
            this.pnlAcciones.Controls.Add(this.btnBorrar);
            this.pnlAcciones.Location = new System.Drawing.Point(764, 637);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(613, 51);
            this.pnlAcciones.TabIndex = 26;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = global::cpProLimp.Properties.Resources.caja_registradora;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(325, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistrar.Size = new System.Drawing.Size(117, 45);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar Venta";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::cpProLimp.Properties.Resources.close;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(482, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(115, 45);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::cpProLimp.Properties.Resources.escoba;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(177, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLimpiar.Size = new System.Drawing.Size(97, 45);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = global::cpProLimp.Properties.Resources.borrar;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(16, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBorrar.Size = new System.Drawing.Size(118, 45);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar Producto";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Image = global::cpProLimp.Properties.Resources._new;
            this.btnNuevoCliente.Location = new System.Drawing.Point(295, 66);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(49, 45);
            this.btnNuevoCliente.TabIndex = 27;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::cpProLimp.Properties.Resources.anadir_al_carrito;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(289, 637);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregar.Size = new System.Drawing.Size(131, 45);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::cpProLimp.Properties.Resources.lupa__2_;
            this.btnBuscar.Location = new System.Drawing.Point(372, 134);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscar.Size = new System.Drawing.Size(48, 47);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnBuscar_KeyPress);
            // 
            // btnMas
            // 
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(1400, 383);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(46, 46);
            this.btnMas.TabIndex = 28;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(1400, 435);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(46, 46);
            this.btnMenos.TabIndex = 29;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1467, 743);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxListaVenta);
            this.Controls.Add(this.gbxListado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEmplead);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUsuari);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.gbxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxListaVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUsuari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblEmplead;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxListado;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox gbxListaVenta;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
    }
}