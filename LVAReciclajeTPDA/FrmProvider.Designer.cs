namespace LVAReciclajeTPDA
{
    partial class FrmProvider
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.cbmCiudad = new MetroFramework.Controls.MetroComboBox();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.txtWeb = new MetroFramework.Controls.MetroTextBox();
            this.lblWeb = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.txtCodee = new MetroFramework.Controls.MetroTextBox();
            this.lblCodee = new MetroFramework.Controls.MetroLabel();
            this.lblCiudad = new MetroFramework.Controls.MetroLabel();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.lblEnterpriseName = new MetroFramework.Controls.MetroLabel();
            this.txtAdress = new MetroFramework.Controls.MetroTextBox();
            this.lblAdress = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.cbmCiudad);
            this.pnlDatos.Controls.Add(this.pctFoto);
            this.pnlDatos.Controls.Add(this.txtWeb);
            this.pnlDatos.Controls.Add(this.lblWeb);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.lblEmail);
            this.pnlDatos.Controls.Add(this.txtPhone);
            this.pnlDatos.Controls.Add(this.lblPhone);
            this.pnlDatos.Controls.Add(this.txtCodee);
            this.pnlDatos.Controls.Add(this.lblCodee);
            this.pnlDatos.Controls.Add(this.lblCiudad);
            this.pnlDatos.Controls.Add(this.txtMarca);
            this.pnlDatos.Controls.Add(this.txtNombreEmpresa);
            this.pnlDatos.Controls.Add(this.lblMarca);
            this.pnlDatos.Controls.Add(this.lblEnterpriseName);
            this.pnlDatos.Controls.Add(this.txtAdress);
            this.pnlDatos.Controls.Add(this.lblAdress);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(259, 63);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(615, 204);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // cbmCiudad
            // 
            this.cbmCiudad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.providerBindingSource, "City", true));
            this.cbmCiudad.FormattingEnabled = true;
            this.cbmCiudad.ItemHeight = 23;
            this.cbmCiudad.Items.AddRange(new object[] {
            "Acatlán de Osorio",
            "Amozoc",
            "Atlixco",
            "Ciudad Serdán",
            "Cuautlancingo",
            "Huauchinango",
            "Izúcar de Matamoros",
            "Puebla (Heroica Puebla)",
            "San Andrés Cholula",
            "San Martín Texmelucan de Labastida",
            "San Pedro Cholula",
            "Tecamachalco",
            "Tehuacan",
            "Tepeaca",
            "Teziutlan",
            "Xicotepec",
            "Zacatlán"});
            this.cbmCiudad.Location = new System.Drawing.Point(333, 30);
            this.cbmCiudad.Name = "cbmCiudad";
            this.cbmCiudad.Size = new System.Drawing.Size(259, 29);
            this.cbmCiudad.TabIndex = 43;
            this.cbmCiudad.UseSelectable = true;
            // 
            // pctFoto
            // 
            this.pctFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.providerBindingSource, "ImageUrl", true));
            this.pctFoto.Location = new System.Drawing.Point(3, 7);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(234, 79);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFoto.TabIndex = 38;
            this.pctFoto.TabStop = false;
            // 
            // txtWeb
            // 
            // 
            // 
            // 
            this.txtWeb.CustomButton.Image = null;
            this.txtWeb.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.txtWeb.CustomButton.Name = "";
            this.txtWeb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWeb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWeb.CustomButton.TabIndex = 1;
            this.txtWeb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeb.CustomButton.UseSelectable = true;
            this.txtWeb.CustomButton.Visible = false;
            this.txtWeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Web", true));
            this.txtWeb.Lines = new string[0];
            this.txtWeb.Location = new System.Drawing.Point(333, 155);
            this.txtWeb.MaxLength = 32767;
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.PasswordChar = '\0';
            this.txtWeb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeb.SelectedText = "";
            this.txtWeb.SelectionLength = 0;
            this.txtWeb.SelectionStart = 0;
            this.txtWeb.ShortcutsEnabled = true;
            this.txtWeb.Size = new System.Drawing.Size(259, 23);
            this.txtWeb.TabIndex = 37;
            this.txtWeb.UseSelectable = true;
            this.txtWeb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(241, 159);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(36, 19);
            this.lblWeb.TabIndex = 36;
            this.lblWeb.Text = "Web";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Mail", true));
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(333, 126);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(259, 23);
            this.txtEmail.TabIndex = 35;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(243, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "PhoneNumber", true));
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(333, 97);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(259, 23);
            this.txtPhone.TabIndex = 33;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(243, 101);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 19);
            this.lblPhone.TabIndex = 32;
            this.lblPhone.Text = "Teléfono";
            // 
            // txtCodee
            // 
            // 
            // 
            // 
            this.txtCodee.CustomButton.Image = null;
            this.txtCodee.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.txtCodee.CustomButton.Name = "";
            this.txtCodee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodee.CustomButton.TabIndex = 1;
            this.txtCodee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodee.CustomButton.UseSelectable = true;
            this.txtCodee.CustomButton.Visible = false;
            this.txtCodee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "PostalCode", true));
            this.txtCodee.Lines = new string[0];
            this.txtCodee.Location = new System.Drawing.Point(333, 65);
            this.txtCodee.MaxLength = 32767;
            this.txtCodee.Name = "txtCodee";
            this.txtCodee.PasswordChar = '\0';
            this.txtCodee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodee.SelectedText = "";
            this.txtCodee.SelectionLength = 0;
            this.txtCodee.SelectionStart = 0;
            this.txtCodee.ShortcutsEnabled = true;
            this.txtCodee.Size = new System.Drawing.Size(259, 23);
            this.txtCodee.TabIndex = 31;
            this.txtCodee.UseSelectable = true;
            this.txtCodee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCodee
            // 
            this.lblCodee.AutoSize = true;
            this.lblCodee.Location = new System.Drawing.Point(241, 63);
            this.lblCodee.Name = "lblCodee";
            this.lblCodee.Size = new System.Drawing.Size(91, 19);
            this.lblCodee.TabIndex = 30;
            this.lblCodee.Text = "Codigo Postal";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(243, 34);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 19);
            this.lblCiudad.TabIndex = 28;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtMarca
            // 
            // 
            // 
            // 
            this.txtMarca.CustomButton.Image = null;
            this.txtMarca.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtMarca.CustomButton.Name = "";
            this.txtMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarca.CustomButton.TabIndex = 1;
            this.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarca.CustomButton.UseSelectable = true;
            this.txtMarca.CustomButton.Visible = false;
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Brand", true));
            this.txtMarca.Lines = new string[0];
            this.txtMarca.Location = new System.Drawing.Point(75, 156);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(160, 23);
            this.txtMarca.TabIndex = 25;
            this.txtMarca.UseSelectable = true;
            this.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreEmpresa
            // 
            // 
            // 
            // 
            this.txtNombreEmpresa.CustomButton.Image = null;
            this.txtNombreEmpresa.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtNombreEmpresa.CustomButton.Name = "";
            this.txtNombreEmpresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreEmpresa.CustomButton.TabIndex = 1;
            this.txtNombreEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreEmpresa.CustomButton.UseSelectable = true;
            this.txtNombreEmpresa.CustomButton.Visible = false;
            this.txtNombreEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "EnterpriseName", true));
            this.txtNombreEmpresa.Lines = new string[0];
            this.txtNombreEmpresa.Location = new System.Drawing.Point(75, 123);
            this.txtNombreEmpresa.MaxLength = 32767;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.PasswordChar = '\0';
            this.txtNombreEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreEmpresa.SelectedText = "";
            this.txtNombreEmpresa.SelectionLength = 0;
            this.txtNombreEmpresa.SelectionStart = 0;
            this.txtNombreEmpresa.ShortcutsEnabled = true;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(160, 23);
            this.txtNombreEmpresa.TabIndex = 23;
            this.txtNombreEmpresa.UseSelectable = true;
            this.txtNombreEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(3, 156);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca";
            // 
            // lblEnterpriseName
            // 
            this.lblEnterpriseName.AutoSize = true;
            this.lblEnterpriseName.Location = new System.Drawing.Point(3, 127);
            this.lblEnterpriseName.Name = "lblEnterpriseName";
            this.lblEnterpriseName.Size = new System.Drawing.Size(60, 19);
            this.lblEnterpriseName.TabIndex = 22;
            this.lblEnterpriseName.Text = "Empresa";
            // 
            // txtAdress
            // 
            // 
            // 
            // 
            this.txtAdress.CustomButton.Image = null;
            this.txtAdress.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.txtAdress.CustomButton.Name = "";
            this.txtAdress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdress.CustomButton.TabIndex = 1;
            this.txtAdress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdress.CustomButton.UseSelectable = true;
            this.txtAdress.CustomButton.Visible = false;
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Address", true));
            this.txtAdress.Lines = new string[0];
            this.txtAdress.Location = new System.Drawing.Point(333, 3);
            this.txtAdress.MaxLength = 32767;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdress.SelectedText = "";
            this.txtAdress.SelectionLength = 0;
            this.txtAdress.SelectionStart = 0;
            this.txtAdress.ShortcutsEnabled = true;
            this.txtAdress.Size = new System.Drawing.Size(259, 23);
            this.txtAdress.TabIndex = 27;
            this.txtAdress.UseSelectable = true;
            this.txtAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(243, 3);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(63, 19);
            this.lblAdress.TabIndex = 26;
            this.lblAdress.Text = "Dirección";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(75, 94);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(160, 23);
            this.txtId.TabIndex = 5;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 95);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(797, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 38);
            this.btnSalir.TabIndex = 60;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(692, 273);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 38);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscar.Location = new System.Drawing.Point(372, 273);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 38);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Maroon;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar.Location = new System.Drawing.Point(592, 273);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 38);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(482, 273);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 38);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(259, 273);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 38);
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoGenerateColumns = false;
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
            this.grdDatos.DataSource = this.providerBindingSource;
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
            this.grdDatos.Location = new System.Drawing.Point(13, 63);
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
            this.grdDatos.Size = new System.Drawing.Size(240, 204);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
            // 
            // FrmProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 364);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Name = "FrmProvider";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.FrmProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterpriseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroTextBox txtNombreEmpresa;
        private MetroFramework.Controls.MetroLabel lblEnterpriseName;
        private MetroFramework.Controls.MetroTextBox txtMarca;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private MetroFramework.Controls.MetroTextBox txtAdress;
        private MetroFramework.Controls.MetroLabel lblAdress;
        private MetroFramework.Controls.MetroLabel lblCiudad;
        private MetroFramework.Controls.MetroTextBox txtCodee;
        private MetroFramework.Controls.MetroLabel lblCodee;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtWeb;
        private MetroFramework.Controls.MetroLabel lblWeb;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private System.Windows.Forms.PictureBox pctFoto;
        private MetroFramework.Controls.MetroComboBox cbmCiudad;
        private MetroFramework.Controls.MetroGrid grdDatos;
    }
}