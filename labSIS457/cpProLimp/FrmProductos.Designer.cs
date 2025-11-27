namespace cpProLimp
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.chkSinVencimiento = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudCantidadMinimaStock = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblCantidadMinimaStock = new System.Windows.Forms.Label();
            this.nudPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.erpCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpUnidadMedida = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPrecioUnitario = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpFechaVencimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpProveedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPrecioCompra = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCantidadMinimaStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.erpMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbxListado.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMinimaStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCantidadMinimaStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1103, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos - ProLimp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar el producto por Código, Descripción o Unidad de Medida";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(535, 39);
            this.txtParametro.Multiline = true;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(247, 27);
            this.txtParametro.TabIndex = 2;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // gbxListado
            // 
            this.gbxListado.Controls.Add(this.dgvLista);
            this.gbxListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListado.Location = new System.Drawing.Point(12, 72);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(1103, 377);
            this.gbxListado.TabIndex = 4;
            this.gbxListado.TabStop = false;
            this.gbxListado.Text = "Lista de Productos";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnBorrar);
            this.pnlAcciones.Controls.Add(this.btnCrear);
            this.pnlAcciones.Location = new System.Drawing.Point(17, 466);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(1098, 51);
            this.pnlAcciones.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::cpProLimp.Properties.Resources.close;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(854, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(100, 45);
            this.btnCerrar.TabIndex = 9;
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
            this.btnEditar.Location = new System.Drawing.Point(437, 3);
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
            this.btnBorrar.Location = new System.Drawing.Point(635, 3);
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
            this.btnCrear.Location = new System.Drawing.Point(237, 3);
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
            this.gbxDatos.Controls.Add(this.cbxMarca);
            this.gbxDatos.Controls.Add(this.lblMarca);
            this.gbxDatos.Controls.Add(this.cbxCategoria);
            this.gbxDatos.Controls.Add(this.lblCategoria);
            this.gbxDatos.Controls.Add(this.chkSinVencimiento);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.nudCantidadMinimaStock);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.nudPrecioCompra);
            this.gbxDatos.Controls.Add(this.cbxProveedor);
            this.gbxDatos.Controls.Add(this.dtpFechaVencimiento);
            this.gbxDatos.Controls.Add(this.lblCantidadMinimaStock);
            this.gbxDatos.Controls.Add(this.nudPrecioUnitario);
            this.gbxDatos.Controls.Add(this.lblPrecioCompra);
            this.gbxDatos.Controls.Add(this.nudStock);
            this.gbxDatos.Controls.Add(this.cbxUnidadMedida);
            this.gbxDatos.Controls.Add(this.txtNombreProducto);
            this.gbxDatos.Controls.Add(this.txtCodigo);
            this.gbxDatos.Controls.Add(this.lblProveedor);
            this.gbxDatos.Controls.Add(this.lblFechaVencimiento);
            this.gbxDatos.Controls.Add(this.lblPrecioUnitario);
            this.gbxDatos.Controls.Add(this.lblStock);
            this.gbxDatos.Controls.Add(this.lblUnidadMedida);
            this.gbxDatos.Controls.Add(this.lblDescripcion);
            this.gbxDatos.Controls.Add(this.lblCodigo);
            this.gbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(17, 539);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(1088, 248);
            this.gbxDatos.TabIndex = 6;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Agregar / Modificar datos:";
            // 
            // chkSinVencimiento
            // 
            this.chkSinVencimiento.AutoSize = true;
            this.chkSinVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinVencimiento.Location = new System.Drawing.Point(771, 95);
            this.chkSinVencimiento.Name = "chkSinVencimiento";
            this.chkSinVencimiento.Size = new System.Drawing.Size(229, 24);
            this.chkSinVencimiento.TabIndex = 20;
            this.chkSinVencimiento.Text = "Sin fecha de vencimiento";
            this.chkSinVencimiento.UseVisualStyleBackColor = true;
            this.chkSinVencimiento.CheckedChanged += new System.EventHandler(this.chkSinVencimiento_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::cpProLimp.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(1006, 119);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(74, 62);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudCantidadMinimaStock
            // 
            this.nudCantidadMinimaStock.Location = new System.Drawing.Point(771, 199);
            this.nudCantidadMinimaStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidadMinimaStock.Name = "nudCantidadMinimaStock";
            this.nudCantidadMinimaStock.Size = new System.Drawing.Size(183, 31);
            this.nudCantidadMinimaStock.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::cpProLimp.Properties.Resources.salvar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(1005, 32);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardar.Size = new System.Drawing.Size(74, 62);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudPrecioCompra
            // 
            this.nudPrecioCompra.Location = new System.Drawing.Point(771, 164);
            this.nudPrecioCompra.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrecioCompra.Name = "nudPrecioCompra";
            this.nudPrecioCompra.Size = new System.Drawing.Size(183, 31);
            this.nudPrecioCompra.TabIndex = 14;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(771, 119);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(183, 33);
            this.cbxProveedor.TabIndex = 13;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Checked = false;
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(771, 62);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.ShowCheckBox = true;
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(183, 31);
            this.dtpFechaVencimiento.TabIndex = 12;
            // 
            // lblCantidadMinimaStock
            // 
            this.lblCantidadMinimaStock.AutoSize = true;
            this.lblCantidadMinimaStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMinimaStock.Location = new System.Drawing.Point(500, 204);
            this.lblCantidadMinimaStock.Name = "lblCantidadMinimaStock";
            this.lblCantidadMinimaStock.Size = new System.Drawing.Size(261, 25);
            this.lblCantidadMinimaStock.TabIndex = 17;
            this.lblCantidadMinimaStock.Text = "Cantidad Mínima Stock:";
            // 
            // nudPrecioUnitario
            // 
            this.nudPrecioUnitario.Location = new System.Drawing.Point(771, 25);
            this.nudPrecioUnitario.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrecioUnitario.Name = "nudPrecioUnitario";
            this.nudPrecioUnitario.Size = new System.Drawing.Size(183, 31);
            this.nudPrecioUnitario.TabIndex = 11;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(500, 169);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(207, 25);
            this.lblPrecioCompra.TabIndex = 16;
            this.lblPrecioCompra.Text = "Precio de Compra:";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(283, 202);
            this.nudStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(183, 31);
            this.nudStock.TabIndex = 10;
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Location = new System.Drawing.Point(283, 167);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(183, 33);
            this.cbxUnidadMedida.TabIndex = 9;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(283, 58);
            this.txtNombreProducto.MaxLength = 100;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(183, 31);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(283, 24);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(183, 31);
            this.txtCodigo.TabIndex = 7;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(500, 122);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(127, 25);
            this.lblProveedor.TabIndex = 6;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(500, 64);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(253, 25);
            this.lblFechaVencimiento.TabIndex = 5;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(500, 24);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(168, 25);
            this.lblPrecioUnitario.TabIndex = 4;
            this.lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(6, 202);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(78, 25);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock:";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(3, 170);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(210, 25);
            this.lblUnidadMedida.TabIndex = 2;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 61);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(240, 25);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Nombre del Producto:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(3, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código: ";
            // 
            // erpCodigo
            // 
            this.erpCodigo.ContainerControl = this;
            // 
            // erpDescripcion
            // 
            this.erpDescripcion.ContainerControl = this;
            // 
            // erpUnidadMedida
            // 
            this.erpUnidadMedida.ContainerControl = this;
            // 
            // erpStock
            // 
            this.erpStock.ContainerControl = this;
            // 
            // erpPrecioUnitario
            // 
            this.erpPrecioUnitario.ContainerControl = this;
            // 
            // erpFechaVencimiento
            // 
            this.erpFechaVencimiento.ContainerControl = this;
            // 
            // erpProveedor
            // 
            this.erpProveedor.ContainerControl = this;
            // 
            // erpPrecioCompra
            // 
            this.erpPrecioCompra.ContainerControl = this;
            // 
            // erpCantidadMinimaStock
            // 
            this.erpCantidadMinimaStock.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::cpProLimp.Properties.Resources.lupa__2_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(788, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscar.Size = new System.Drawing.Size(102, 47);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(283, 127);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(183, 33);
            this.cbxCategoria.TabIndex = 22;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 130);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(121, 25);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(283, 92);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(183, 33);
            this.cbxMarca.TabIndex = 24;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 92);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(84, 25);
            this.lblMarca.TabIndex = 23;
            this.lblMarca.Text = "Marca:";
            // 
            // erpMarca
            // 
            this.erpMarca.ContainerControl = this;
            // 
            // erpCategoria
            // 
            this.erpCategoria.ContainerControl = this;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(7, 25);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(1086, 346);
            this.dgvLista.TabIndex = 1;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1127, 799);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxListado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Productos - ProLimp :::";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.gbxListado.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMinimaStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCantidadMinimaStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.GroupBox gbxListado;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.ComboBox cbxUnidadMedida;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.NumericUpDown nudPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblCantidadMinimaStock;
        private System.Windows.Forms.NumericUpDown nudCantidadMinimaStock;
        private System.Windows.Forms.NumericUpDown nudPrecioCompra;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider erpCodigo;
        private System.Windows.Forms.ErrorProvider erpDescripcion;
        private System.Windows.Forms.ErrorProvider erpUnidadMedida;
        private System.Windows.Forms.ErrorProvider erpStock;
        private System.Windows.Forms.ErrorProvider erpPrecioUnitario;
        private System.Windows.Forms.ErrorProvider erpFechaVencimiento;
        private System.Windows.Forms.ErrorProvider erpProveedor;
        private System.Windows.Forms.ErrorProvider erpPrecioCompra;
        private System.Windows.Forms.ErrorProvider erpCantidadMinimaStock;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkSinVencimiento;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ErrorProvider erpMarca;
        private System.Windows.Forms.ErrorProvider erpCategoria;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}