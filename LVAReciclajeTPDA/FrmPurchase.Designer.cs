namespace LVAReciclajeTPDA
{
    partial class FrmCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.txtTipoDeProducto = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreDelProveedor = new MetroFramework.Controls.MetroTextBox();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioUnitario = new MetroFramework.Controls.MetroLabel();
            this.lblCantidad = new MetroFramework.Controls.MetroLabel();
            this.lblNombreProv = new MetroFramework.Controls.MetroLabel();
            this.lblTipoDeProducto = new MetroFramework.Controls.MetroLabel();
            this.txtPrecioUnitario = new MetroFramework.Controls.MetroTextBox();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.lblDescripcionDelProducto = new MetroFramework.Controls.MetroLabel();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.metroTextBox1);
            this.pnlDatos.Controls.Add(this.lblDescripcionDelProducto);
            this.pnlDatos.Controls.Add(this.btnSalir);
            this.pnlDatos.Controls.Add(this.btnEliminar);
            this.pnlDatos.Controls.Add(this.btnBuscar);
            this.pnlDatos.Controls.Add(this.btnEditar);
            this.pnlDatos.Controls.Add(this.btnAgregar);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.grdDatos);
            this.pnlDatos.Controls.Add(this.txtPrecioUnitario);
            this.pnlDatos.Controls.Add(this.lblTipoDeProducto);
            this.pnlDatos.Controls.Add(this.lblNombreProv);
            this.pnlDatos.Controls.Add(this.lblCantidad);
            this.pnlDatos.Controls.Add(this.lblPrecioUnitario);
            this.pnlDatos.Controls.Add(this.lblCodigo);
            this.pnlDatos.Controls.Add(this.txtCantidad);
            this.pnlDatos.Controls.Add(this.txtNombreDelProveedor);
            this.pnlDatos.Controls.Add(this.txtTipoDeProducto);
            this.pnlDatos.Controls.Add(this.txtCodigo);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(23, 75);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(824, 428);
            this.pnlDatos.TabIndex = 0;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(201, 55);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(209, 23);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTipoDeProducto
            // 
            // 
            // 
            // 
            this.txtTipoDeProducto.CustomButton.Image = null;
            this.txtTipoDeProducto.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtTipoDeProducto.CustomButton.Name = "";
            this.txtTipoDeProducto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTipoDeProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTipoDeProducto.CustomButton.TabIndex = 1;
            this.txtTipoDeProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTipoDeProducto.CustomButton.UseSelectable = true;
            this.txtTipoDeProducto.CustomButton.Visible = false;
            this.txtTipoDeProducto.Lines = new string[0];
            this.txtTipoDeProducto.Location = new System.Drawing.Point(201, 96);
            this.txtTipoDeProducto.MaxLength = 32767;
            this.txtTipoDeProducto.Name = "txtTipoDeProducto";
            this.txtTipoDeProducto.PasswordChar = '\0';
            this.txtTipoDeProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTipoDeProducto.SelectedText = "";
            this.txtTipoDeProducto.SelectionLength = 0;
            this.txtTipoDeProducto.SelectionStart = 0;
            this.txtTipoDeProducto.ShortcutsEnabled = true;
            this.txtTipoDeProducto.Size = new System.Drawing.Size(209, 23);
            this.txtTipoDeProducto.TabIndex = 3;
            this.txtTipoDeProducto.UseSelectable = true;
            this.txtTipoDeProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTipoDeProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreDelProveedor
            // 
            // 
            // 
            // 
            this.txtNombreDelProveedor.CustomButton.Image = null;
            this.txtNombreDelProveedor.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtNombreDelProveedor.CustomButton.Name = "";
            this.txtNombreDelProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreDelProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreDelProveedor.CustomButton.TabIndex = 1;
            this.txtNombreDelProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreDelProveedor.CustomButton.UseSelectable = true;
            this.txtNombreDelProveedor.CustomButton.Visible = false;
            this.txtNombreDelProveedor.Lines = new string[0];
            this.txtNombreDelProveedor.Location = new System.Drawing.Point(201, 137);
            this.txtNombreDelProveedor.MaxLength = 32767;
            this.txtNombreDelProveedor.Name = "txtNombreDelProveedor";
            this.txtNombreDelProveedor.PasswordChar = '\0';
            this.txtNombreDelProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreDelProveedor.SelectedText = "";
            this.txtNombreDelProveedor.SelectionLength = 0;
            this.txtNombreDelProveedor.SelectionStart = 0;
            this.txtNombreDelProveedor.ShortcutsEnabled = true;
            this.txtNombreDelProveedor.Size = new System.Drawing.Size(209, 23);
            this.txtNombreDelProveedor.TabIndex = 4;
            this.txtNombreDelProveedor.UseSelectable = true;
            this.txtNombreDelProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreDelProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.CustomButton.Image = null;
            this.txtCantidad.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtCantidad.CustomButton.Name = "";
            this.txtCantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidad.CustomButton.TabIndex = 1;
            this.txtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidad.CustomButton.UseSelectable = true;
            this.txtCantidad.CustomButton.Visible = false;
            this.txtCantidad.Lines = new string[0];
            this.txtCantidad.Location = new System.Drawing.Point(201, 183);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(209, 23);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.UseSelectable = true;
            this.txtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(45, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 19);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(45, 240);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(96, 19);
            this.lblPrecioUnitario.TabIndex = 7;
            this.lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(45, 187);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 19);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblNombreProv
            // 
            this.lblNombreProv.AutoSize = true;
            this.lblNombreProv.Location = new System.Drawing.Point(45, 137);
            this.lblNombreProv.Name = "lblNombreProv";
            this.lblNombreProv.Size = new System.Drawing.Size(147, 19);
            this.lblNombreProv.TabIndex = 9;
            this.lblNombreProv.Text = "Nombre del Proveedor";
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.AutoSize = true;
            this.lblTipoDeProducto.Location = new System.Drawing.Point(45, 96);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(112, 19);
            this.lblTipoDeProducto.TabIndex = 10;
            this.lblTipoDeProducto.Text = "Tipo de Producto";
            // 
            // txtPrecioUnitario
            // 
            // 
            // 
            // 
            this.txtPrecioUnitario.CustomButton.Image = null;
            this.txtPrecioUnitario.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtPrecioUnitario.CustomButton.Name = "";
            this.txtPrecioUnitario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioUnitario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioUnitario.CustomButton.TabIndex = 1;
            this.txtPrecioUnitario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioUnitario.CustomButton.UseSelectable = true;
            this.txtPrecioUnitario.CustomButton.Visible = false;
            this.txtPrecioUnitario.Lines = new string[0];
            this.txtPrecioUnitario.Location = new System.Drawing.Point(201, 236);
            this.txtPrecioUnitario.MaxLength = 32767;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.PasswordChar = '\0';
            this.txtPrecioUnitario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioUnitario.SelectedText = "";
            this.txtPrecioUnitario.SelectionLength = 0;
            this.txtPrecioUnitario.SelectionStart = 0;
            this.txtPrecioUnitario.ShortcutsEnabled = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(209, 23);
            this.txtPrecioUnitario.TabIndex = 11;
            this.txtPrecioUnitario.UseSelectable = true;
            this.txtPrecioUnitario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioUnitario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(462, 55);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(326, 215);
            this.grdDatos.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(666, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 38);
            this.btnSalir.TabIndex = 66;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(561, 370);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 38);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscar.Location = new System.Drawing.Point(241, 370);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 38);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Maroon;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar.Location = new System.Drawing.Point(461, 370);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 38);
            this.btnEditar.TabIndex = 63;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(351, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 38);
            this.btnAgregar.TabIndex = 62;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(128, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 38);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(530, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(236, 315);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(552, 23);
            this.metroTextBox1.TabIndex = 68;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescripcionDelProducto
            // 
            this.lblDescripcionDelProducto.AutoSize = true;
            this.lblDescripcionDelProducto.Location = new System.Drawing.Point(45, 315);
            this.lblDescripcionDelProducto.Name = "lblDescripcionDelProducto";
            this.lblDescripcionDelProducto.Size = new System.Drawing.Size(156, 19);
            this.lblDescripcionDelProducto.TabIndex = 67;
            this.lblDescripcionDelProducto.Text = "Descripcion del producto";
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 490);
            this.Controls.Add(this.pnlDatos);
            this.Name = "FrmCompra";
            this.Text = "FrmCompra";
            this.Load += new System.EventHandler(this.FrmPurchase_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroTextBox txtNombreDelProveedor;
        private MetroFramework.Controls.MetroTextBox txtTipoDeProducto;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroTextBox txtPrecioUnitario;
        private MetroFramework.Controls.MetroLabel lblTipoDeProducto;
        private MetroFramework.Controls.MetroLabel lblNombreProv;
        private MetroFramework.Controls.MetroLabel lblCantidad;
        private MetroFramework.Controls.MetroLabel lblPrecioUnitario;
        private MetroFramework.Controls.MetroGrid grdDatos;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel lblDescripcionDelProducto;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnGuardar;
    }
}