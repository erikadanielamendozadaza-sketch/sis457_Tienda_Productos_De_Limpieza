namespace cpProLimp
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnCaVenta = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonTab3 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonTab4 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCaEmpleados = new C1.Win.C1Ribbon.RibbonButton();
            this.btnCaProductos = new C1.Win.C1Ribbon.RibbonButton();
            this.btnCaClientes = new C1.Win.C1Ribbon.RibbonButton();
            this.btnOpVenta = new C1.Win.C1Ribbon.RibbonButton();
            this.btnReProveedores = new C1.Win.C1Ribbon.RibbonButton();
            this.btnReClientes = new C1.Win.C1Ribbon.RibbonButton();
            this.btnReProductos = new C1.Win.C1Ribbon.RibbonButton();
            this.btnReVentas = new C1.Win.C1Ribbon.RibbonButton();
            this.btnAdEmpleados = new C1.Win.C1Ribbon.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(797, 154);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.btnCaVenta);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab4);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Catálogos";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaEmpleados);
            this.ribbonGroup1.Items.Add(this.btnCaProductos);
            this.ribbonGroup1.Items.Add(this.btnCaClientes);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Administración de catálogos";
            // 
            // btnCaVenta
            // 
            this.btnCaVenta.Groups.Add(this.ribbonGroup2);
            this.btnCaVenta.Name = "btnCaVenta";
            this.btnCaVenta.Text = "Operaciones";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.btnOpVenta);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Registro de ventas";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup3);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Reportes";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.btnReProveedores);
            this.ribbonGroup3.Items.Add(this.btnReClientes);
            this.ribbonGroup3.Items.Add(this.btnReProductos);
            this.ribbonGroup3.Items.Add(this.btnReVentas);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Visualización de Reportes";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Groups.Add(this.ribbonGroup4);
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Administración";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.btnAdEmpleados);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Gestión de Administración";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::cpProLimp.Properties.Resources.fondo__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCaEmpleados
            // 
            this.btnCaEmpleados.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCaEmpleados.LargeImage")));
            this.btnCaEmpleados.Name = "btnCaEmpleados";
            this.btnCaEmpleados.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaEmpleados.SmallImage")));
            this.btnCaEmpleados.Text = "Empleados";
            this.btnCaEmpleados.ToolTip = "Registra empleados";
            this.btnCaEmpleados.Click += new System.EventHandler(this.btnCaEmpleados_Click);
            // 
            // btnCaProductos
            // 
            this.btnCaProductos.LargeImage = global::cpProLimp.Properties.Resources.limpieza__1_;
            this.btnCaProductos.Name = "btnCaProductos";
            this.btnCaProductos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaProductos.SmallImage")));
            this.btnCaProductos.Text = "Productos";
            this.btnCaProductos.ToolTip = "Registra productos";
            this.btnCaProductos.Click += new System.EventHandler(this.btnCaProductos_Click);
            // 
            // btnCaClientes
            // 
            this.btnCaClientes.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCaClientes.LargeImage")));
            this.btnCaClientes.Name = "btnCaClientes";
            this.btnCaClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaClientes.SmallImage")));
            this.btnCaClientes.Text = "Clientes";
            this.btnCaClientes.ToolTip = "Registra clientes";
            this.btnCaClientes.Click += new System.EventHandler(this.btnCaClientes_Click);
            // 
            // btnOpVenta
            // 
            this.btnOpVenta.LargeImage = global::cpProLimp.Properties.Resources.ventas;
            this.btnOpVenta.Name = "btnOpVenta";
            this.btnOpVenta.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnOpVenta.SmallImage")));
            this.btnOpVenta.Text = "Venta";
            this.btnOpVenta.ToolTip = "Registra Venta";
            this.btnOpVenta.Click += new System.EventHandler(this.btnOpVenta_Click);
            // 
            // btnReProveedores
            // 
            this.btnReProveedores.LargeImage = global::cpProLimp.Properties.Resources.provider;
            this.btnReProveedores.Name = "btnReProveedores";
            this.btnReProveedores.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnReProveedores.SmallImage")));
            this.btnReProveedores.Text = "Proveedores";
            this.btnReProveedores.ToolTip = "Lista proveedores";
            this.btnReProveedores.Click += new System.EventHandler(this.btnReProveedores_Click);
            // 
            // btnReClientes
            // 
            this.btnReClientes.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReClientes.LargeImage")));
            this.btnReClientes.Name = "btnReClientes";
            this.btnReClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnReClientes.SmallImage")));
            this.btnReClientes.Text = "Clientes";
            this.btnReClientes.ToolTip = "Lista clientes";
            this.btnReClientes.Click += new System.EventHandler(this.btnReClientes_Click);
            // 
            // btnReProductos
            // 
            this.btnReProductos.LargeImage = global::cpProLimp.Properties.Resources.limpieza__1_;
            this.btnReProductos.Name = "btnReProductos";
            this.btnReProductos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnReProductos.SmallImage")));
            this.btnReProductos.Text = "Productos";
            this.btnReProductos.ToolTip = "Lista productos";
            this.btnReProductos.Click += new System.EventHandler(this.btnReProductos_Click);
            // 
            // btnReVentas
            // 
            this.btnReVentas.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReVentas.LargeImage")));
            this.btnReVentas.Name = "btnReVentas";
            this.btnReVentas.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnReVentas.SmallImage")));
            this.btnReVentas.Text = "Ventas";
            this.btnReVentas.ToolTip = "Lista venta";
            this.btnReVentas.Click += new System.EventHandler(this.btnReVentas_Click);
            // 
            // btnAdEmpleados
            // 
            this.btnAdEmpleados.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdEmpleados.LargeImage")));
            this.btnAdEmpleados.Name = "btnAdEmpleados";
            this.btnAdEmpleados.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAdEmpleados.SmallImage")));
            this.btnAdEmpleados.Text = "Empleados";
            this.btnAdEmpleados.ToolTip = "Lista empleados";
            this.btnAdEmpleados.Click += new System.EventHandler(this.btnAdEmpleados_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private C1.Win.C1Ribbon.RibbonButton btnCaProductos;
        private C1.Win.C1Ribbon.RibbonButton btnCaClientes;
        private C1.Win.C1Ribbon.RibbonButton btnCaEmpleados;
        private C1.Win.C1Ribbon.RibbonTab btnCaVenta;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab3;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab4;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.C1Ribbon.RibbonButton btnOpVenta;
        private C1.Win.C1Ribbon.RibbonButton btnReProveedores;
        private C1.Win.C1Ribbon.RibbonButton btnReClientes;
        private C1.Win.C1Ribbon.RibbonButton btnReProductos;
        private C1.Win.C1Ribbon.RibbonButton btnReVentas;
        private C1.Win.C1Ribbon.RibbonButton btnAdEmpleados;
    }
}