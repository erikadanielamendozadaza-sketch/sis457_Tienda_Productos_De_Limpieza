namespace cpProLimp
{
    partial class FrmClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblCedulaIdentidad = new System.Windows.Forms.Label();
            this.lblrazonSocial = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.erpRazonSocial = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(853, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente - ProLimp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar el cliente por Cedula de Identidad, Apellidos o Teléfono";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(536, 45);
            this.txtParametro.Multiline = true;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(202, 27);
            this.txtParametro.TabIndex = 3;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // gbxListado
            // 
            this.gbxListado.Controls.Add(this.dgvLista);
            this.gbxListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListado.Location = new System.Drawing.Point(12, 80);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(834, 184);
            this.gbxListado.TabIndex = 5;
            this.gbxListado.TabStop = false;
            this.gbxListado.Text = "Lista de Cliente";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(9, 28);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(815, 150);
            this.dgvLista.TabIndex = 0;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnBorrar);
            this.pnlAcciones.Controls.Add(this.btnCrear);
            this.pnlAcciones.Location = new System.Drawing.Point(12, 270);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(836, 51);
            this.pnlAcciones.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::cpProLimp.Properties.Resources.close;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(626, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(100, 45);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::cpProLimp.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(312, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditar.Size = new System.Drawing.Size(100, 45);
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
            this.btnBorrar.Location = new System.Drawing.Point(466, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBorrar.Size = new System.Drawing.Size(100, 45);
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
            this.btnCrear.Location = new System.Drawing.Point(175, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrear.Size = new System.Drawing.Size(95, 45);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.txtCedulaIdentidad);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.txtRazonSocial);
            this.gbxDatos.Controls.Add(this.lblCedulaIdentidad);
            this.gbxDatos.Controls.Add(this.lblrazonSocial);
            this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(12, 327);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(836, 156);
            this.gbxDatos.TabIndex = 7;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Agregar / Modificar datos:";
            // 
            // txtCedulaIdentidad
            // 
            this.txtCedulaIdentidad.Location = new System.Drawing.Point(645, 24);
            this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
            this.txtCedulaIdentidad.Size = new System.Drawing.Size(179, 26);
            this.txtCedulaIdentidad.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::cpProLimp.Properties.Resources.salvar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(538, 89);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardar.Size = new System.Drawing.Size(70, 62);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(191, 24);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(183, 26);
            this.txtRazonSocial.TabIndex = 7;
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(462, 27);
            this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
            this.lblCedulaIdentidad.Size = new System.Drawing.Size(176, 20);
            this.lblCedulaIdentidad.TabIndex = 3;
            this.lblCedulaIdentidad.Text = "Cedula de Identidad:";
            // 
            // lblrazonSocial
            // 
            this.lblrazonSocial.AutoSize = true;
            this.lblrazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrazonSocial.Location = new System.Drawing.Point(3, 27);
            this.lblrazonSocial.Name = "lblrazonSocial";
            this.lblrazonSocial.Size = new System.Drawing.Size(125, 20);
            this.lblrazonSocial.TabIndex = 0;
            this.lblrazonSocial.Text = "Razon Social: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::cpProLimp.Properties.Resources.lupa__2_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(744, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscar.Size = new System.Drawing.Size(102, 47);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // erpRazonSocial
            // 
            this.erpRazonSocial.ContainerControl = this;
            // 
            // erpCedulaIdentidad
            // 
            this.erpCedulaIdentidad.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::cpProLimp.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(645, 88);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(74, 62);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 495);
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
            this.MaximizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Clientes - ProLimp :::";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.gbxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxListado;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.Label lblrazonSocial;
        private System.Windows.Forms.TextBox txtCedulaIdentidad;
        private System.Windows.Forms.ErrorProvider erpRazonSocial;
        private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}