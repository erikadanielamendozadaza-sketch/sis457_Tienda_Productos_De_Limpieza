namespace cpProLimp
{
    partial class FrmEmpleados
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCanelar = new System.Windows.Forms.Button();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.erpNombres = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPrimerApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpSegundoApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrimerApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSegundoApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::cpProLimp.Properties.Resources.lupa__2_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(700, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscar.Size = new System.Drawing.Size(102, 47);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(433, 44);
            this.txtParametro.Multiline = true;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(247, 27);
            this.txtParametro.TabIndex = 6;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar al empleado por los apellidos o el usuario";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empleados - ProLimp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxListado
            // 
            this.gbxListado.Controls.Add(this.dgvLista);
            this.gbxListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListado.Location = new System.Drawing.Point(12, 77);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(790, 193);
            this.gbxListado.TabIndex = 8;
            this.gbxListado.TabStop = false;
            this.gbxListado.Text = "Lista de Empleados";
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
            this.dgvLista.Size = new System.Drawing.Size(773, 164);
            this.dgvLista.TabIndex = 0;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCancelar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnBorrar);
            this.pnlAcciones.Controls.Add(this.btnCrear);
            this.pnlAcciones.Location = new System.Drawing.Point(12, 276);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(790, 51);
            this.pnlAcciones.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::cpProLimp.Properties.Resources.close;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(601, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(120, 45);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::cpProLimp.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(277, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditar.Size = new System.Drawing.Size(97, 45);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = global::cpProLimp.Properties.Resources.borrar;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(443, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBorrar.Size = new System.Drawing.Size(98, 45);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Image = global::cpProLimp.Properties.Resources.agregar;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(123, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrear.Size = new System.Drawing.Size(89, 45);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtTelefono);
            this.gbxDatos.Controls.Add(this.txtClave);
            this.gbxDatos.Controls.Add(this.txtUsuario);
            this.gbxDatos.Controls.Add(this.txtSegundoApellido);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.btnCanelar);
            this.gbxDatos.Controls.Add(this.txtPrimerApellido);
            this.gbxDatos.Controls.Add(this.txtNombres);
            this.gbxDatos.Controls.Add(this.lblTelefono);
            this.gbxDatos.Controls.Add(this.lblContraseña);
            this.gbxDatos.Controls.Add(this.lblUsuario);
            this.gbxDatos.Controls.Add(this.lblSegundoApellido);
            this.gbxDatos.Controls.Add(this.lblPrimerApellido);
            this.gbxDatos.Controls.Add(this.lblNombres);
            this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(12, 333);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(790, 198);
            this.gbxDatos.TabIndex = 10;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Agregar / Modificar datos:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(538, 86);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(183, 26);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(538, 54);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(183, 26);
            this.txtClave.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(538, 24);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 26);
            this.txtUsuario.TabIndex = 11;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(191, 86);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(183, 26);
            this.txtSegundoApellido.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::cpProLimp.Properties.Resources.salvar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(538, 130);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardar.Size = new System.Drawing.Size(74, 62);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCanelar
            // 
            this.btnCanelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanelar.Image = global::cpProLimp.Properties.Resources.cancel;
            this.btnCanelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCanelar.Location = new System.Drawing.Point(647, 130);
            this.btnCanelar.Name = "btnCanelar";
            this.btnCanelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCanelar.Size = new System.Drawing.Size(74, 62);
            this.btnCanelar.TabIndex = 8;
            this.btnCanelar.Text = "Cancelar";
            this.btnCanelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCanelar.UseVisualStyleBackColor = true;
            this.btnCanelar.Click += new System.EventHandler(this.btnCanelar_Click);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(191, 54);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(183, 26);
            this.txtPrimerApellido.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(191, 24);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(183, 26);
            this.txtNombres.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(396, 89);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(145, 20);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono/Celular:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(396, 57);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(107, 20);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(396, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(3, 89);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(155, 20);
            this.lblSegundoApellido.TabIndex = 2;
            this.lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(3, 57);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(134, 20);
            this.lblPrimerApellido.TabIndex = 1;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(3, 27);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(90, 20);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres: ";
            // 
            // erpNombres
            // 
            this.erpNombres.ContainerControl = this;
            // 
            // erpPrimerApellido
            // 
            this.erpPrimerApellido.ContainerControl = this;
            // 
            // erpSegundoApellido
            // 
            this.erpSegundoApellido.ContainerControl = this;
            // 
            // erpUsuario
            // 
            this.erpUsuario.ContainerControl = this;
            // 
            // erpContraseña
            // 
            this.erpContraseña.ContainerControl = this;
            // 
            // erpTelefono
            // 
            this.erpTelefono.ContainerControl = this;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 543);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxListado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Empleados - ProLimp :::";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.gbxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrimerApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSegundoApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxListado;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCanelar;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ErrorProvider erpNombres;
        private System.Windows.Forms.ErrorProvider erpPrimerApellido;
        private System.Windows.Forms.ErrorProvider erpSegundoApellido;
        private System.Windows.Forms.ErrorProvider erpUsuario;
        private System.Windows.Forms.ErrorProvider erpContraseña;
        private System.Windows.Forms.ErrorProvider erpTelefono;
    }
}