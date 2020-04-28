namespace LVAReciclajeTPDA
{
    partial class frmEmpleado
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
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.cbmCiudad = new MetroFramework.Controls.MetroComboBox();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.cbmLugarNacimiento = new MetroFramework.Controls.MetroComboBox();
            this.lblLugarNacimiento = new MetroFramework.Controls.MetroLabel();
            this.lblCiudad = new MetroFramework.Controls.MetroLabel();
            this.txtNumeroCalle = new MetroFramework.Controls.MetroTextBox();
            this.lblNumeroCalle = new MetroFramework.Controls.MetroLabel();
            this.txtCodigoPotal = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigoPostal = new MetroFramework.Controls.MetroLabel();
            this.txtAdress = new MetroFramework.Controls.MetroTextBox();
            this.lblAdress = new MetroFramework.Controls.MetroLabel();
            this.lblSeguroSocial = new MetroFramework.Controls.MetroLabel();
            this.lblEstadoCivil = new MetroFramework.Controls.MetroLabel();
            this.lblGenero = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtNumberPhone = new MetroFramework.Controls.MetroTextBox();
            this.lblTelefono = new MetroFramework.Controls.MetroLabel();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.lblNombreCompleto = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.cmbGenero = new MetroFramework.Controls.MetroComboBox();
            this.cmbEstadoCivil = new MetroFramework.Controls.MetroComboBox();
            this.cmbSeguroSocial = new MetroFramework.Controls.MetroComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthInsuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoGenerateColumns = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.Silver;
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.numberPhoneDataGridViewTextBoxColumn,
            this.contactEmailDataGridViewTextBoxColumn,
            this.contrasenaDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.streetNumberDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.placeOfBirthDataGridViewTextBoxColumn,
            this.healthInsuranceDataGridViewTextBoxColumn,
            this.salesDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.employeeBindingSource;
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
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdDatos.Location = new System.Drawing.Point(23, 61);
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
            this.grdDatos.Size = new System.Drawing.Size(255, 297);
            this.grdDatos.TabIndex = 4;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.Green;
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.cmbSeguroSocial);
            this.pnlDatos.Controls.Add(this.cmbEstadoCivil);
            this.pnlDatos.Controls.Add(this.cmbGenero);
            this.pnlDatos.Controls.Add(this.cbmCiudad);
            this.pnlDatos.Controls.Add(this.pctFoto);
            this.pnlDatos.Controls.Add(this.cbmLugarNacimiento);
            this.pnlDatos.Controls.Add(this.lblLugarNacimiento);
            this.pnlDatos.Controls.Add(this.lblCiudad);
            this.pnlDatos.Controls.Add(this.txtNumeroCalle);
            this.pnlDatos.Controls.Add(this.lblNumeroCalle);
            this.pnlDatos.Controls.Add(this.txtCodigoPotal);
            this.pnlDatos.Controls.Add(this.lblCodigoPostal);
            this.pnlDatos.Controls.Add(this.txtAdress);
            this.pnlDatos.Controls.Add(this.lblAdress);
            this.pnlDatos.Controls.Add(this.lblSeguroSocial);
            this.pnlDatos.Controls.Add(this.lblEstadoCivil);
            this.pnlDatos.Controls.Add(this.lblGenero);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.lblEmail);
            this.pnlDatos.Controls.Add(this.txtNumberPhone);
            this.pnlDatos.Controls.Add(this.lblTelefono);
            this.pnlDatos.Controls.Add(this.txtFullName);
            this.pnlDatos.Controls.Add(this.lblNombreCompleto);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.ForeColor = System.Drawing.Color.Lime;
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(284, 38);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(758, 274);
            this.pnlDatos.TabIndex = 5;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // cbmCiudad
            // 
            this.cbmCiudad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "City", true));
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
            this.cbmCiudad.Location = new System.Drawing.Point(334, 120);
            this.cbmCiudad.Name = "cbmCiudad";
            this.cbmCiudad.Size = new System.Drawing.Size(419, 29);
            this.cbmCiudad.TabIndex = 42;
            this.cbmCiudad.UseSelectable = true;
            // 
            // pctFoto
            // 
            this.pctFoto.BackColor = System.Drawing.Color.White;
            this.pctFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeeBindingSource, "ImageUrl", true));
            this.pctFoto.Location = new System.Drawing.Point(6, 3);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(207, 125);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFoto.TabIndex = 43;
            this.pctFoto.TabStop = false;
            // 
            // cbmLugarNacimiento
            // 
            this.cbmLugarNacimiento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "PlaceOfBirth", true));
            this.cbmLugarNacimiento.FormattingEnabled = true;
            this.cbmLugarNacimiento.ItemHeight = 23;
            this.cbmLugarNacimiento.Items.AddRange(new object[] {
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
            this.cbmLugarNacimiento.Location = new System.Drawing.Point(334, 155);
            this.cbmLugarNacimiento.Name = "cbmLugarNacimiento";
            this.cbmLugarNacimiento.Size = new System.Drawing.Size(419, 29);
            this.cbmLugarNacimiento.TabIndex = 41;
            this.cbmLugarNacimiento.UseSelectable = true;
            // 
            // lblLugarNacimiento
            // 
            this.lblLugarNacimiento.AutoSize = true;
            this.lblLugarNacimiento.Location = new System.Drawing.Point(219, 156);
            this.lblLugarNacimiento.Name = "lblLugarNacimiento";
            this.lblLugarNacimiento.Size = new System.Drawing.Size(113, 19);
            this.lblLugarNacimiento.TabIndex = 22;
            this.lblLugarNacimiento.Text = "Lugar Nacimiento";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(225, 134);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 19);
            this.lblCiudad.TabIndex = 33;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtNumeroCalle
            // 
            // 
            // 
            // 
            this.txtNumeroCalle.CustomButton.Image = null;
            this.txtNumeroCalle.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtNumeroCalle.CustomButton.Name = "";
            this.txtNumeroCalle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumeroCalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroCalle.CustomButton.TabIndex = 1;
            this.txtNumeroCalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumeroCalle.CustomButton.UseSelectable = true;
            this.txtNumeroCalle.CustomButton.Visible = false;
            this.txtNumeroCalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "StreetNumber", true));
            this.txtNumeroCalle.Lines = new string[0];
            this.txtNumeroCalle.Location = new System.Drawing.Point(334, 62);
            this.txtNumeroCalle.MaxLength = 32767;
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.PasswordChar = '\0';
            this.txtNumeroCalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroCalle.SelectedText = "";
            this.txtNumeroCalle.SelectionLength = 0;
            this.txtNumeroCalle.SelectionStart = 0;
            this.txtNumeroCalle.ShortcutsEnabled = true;
            this.txtNumeroCalle.Size = new System.Drawing.Size(419, 23);
            this.txtNumeroCalle.TabIndex = 32;
            this.txtNumeroCalle.UseSelectable = true;
            this.txtNumeroCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumeroCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNumeroCalle
            // 
            this.lblNumeroCalle.AutoSize = true;
            this.lblNumeroCalle.Location = new System.Drawing.Point(225, 70);
            this.lblNumeroCalle.Name = "lblNumeroCalle";
            this.lblNumeroCalle.Size = new System.Drawing.Size(91, 19);
            this.lblNumeroCalle.TabIndex = 31;
            this.lblNumeroCalle.Text = "Número Calle";
            // 
            // txtCodigoPotal
            // 
            // 
            // 
            // 
            this.txtCodigoPotal.CustomButton.Image = null;
            this.txtCodigoPotal.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.txtCodigoPotal.CustomButton.Name = "";
            this.txtCodigoPotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigoPotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoPotal.CustomButton.TabIndex = 1;
            this.txtCodigoPotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoPotal.CustomButton.UseSelectable = true;
            this.txtCodigoPotal.CustomButton.Visible = false;
            this.txtCodigoPotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ZipCode", true));
            this.txtCodigoPotal.Lines = new string[0];
            this.txtCodigoPotal.Location = new System.Drawing.Point(334, 33);
            this.txtCodigoPotal.MaxLength = 32767;
            this.txtCodigoPotal.Name = "txtCodigoPotal";
            this.txtCodigoPotal.PasswordChar = '\0';
            this.txtCodigoPotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoPotal.SelectedText = "";
            this.txtCodigoPotal.SelectionLength = 0;
            this.txtCodigoPotal.SelectionStart = 0;
            this.txtCodigoPotal.ShortcutsEnabled = true;
            this.txtCodigoPotal.Size = new System.Drawing.Size(419, 23);
            this.txtCodigoPotal.TabIndex = 30;
            this.txtCodigoPotal.UseSelectable = true;
            this.txtCodigoPotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoPotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(225, 37);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(91, 19);
            this.lblCodigoPostal.TabIndex = 29;
            this.lblCodigoPostal.Text = "Codigo Postal";
            // 
            // txtAdress
            // 
            // 
            // 
            // 
            this.txtAdress.CustomButton.Image = null;
            this.txtAdress.CustomButton.Location = new System.Drawing.Point(396, 1);
            this.txtAdress.CustomButton.Name = "";
            this.txtAdress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdress.CustomButton.TabIndex = 1;
            this.txtAdress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdress.CustomButton.UseSelectable = true;
            this.txtAdress.CustomButton.Visible = false;
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address", true));
            this.txtAdress.Lines = new string[0];
            this.txtAdress.Location = new System.Drawing.Point(335, 91);
            this.txtAdress.MaxLength = 32767;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdress.SelectedText = "";
            this.txtAdress.SelectionLength = 0;
            this.txtAdress.SelectionStart = 0;
            this.txtAdress.ShortcutsEnabled = true;
            this.txtAdress.Size = new System.Drawing.Size(418, 23);
            this.txtAdress.TabIndex = 28;
            this.txtAdress.UseSelectable = true;
            this.txtAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(225, 99);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(63, 19);
            this.lblAdress.TabIndex = 27;
            this.lblAdress.Text = "Dirección";
            // 
            // lblSeguroSocial
            // 
            this.lblSeguroSocial.Location = new System.Drawing.Point(225, 233);
            this.lblSeguroSocial.Name = "lblSeguroSocial";
            this.lblSeguroSocial.Size = new System.Drawing.Size(97, 18);
            this.lblSeguroSocial.TabIndex = 24;
            this.lblSeguroSocial.Text = "Seguro Social\r\n";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(225, 194);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(76, 19);
            this.lblEstadoCivil.TabIndex = 20;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(8, 226);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 19);
            this.lblGenero.TabIndex = 18;
            this.lblGenero.Text = "Género";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(396, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ContactEmail", true));
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(335, 4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(418, 23);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(235, 8);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // txtNumberPhone
            // 
            // 
            // 
            // 
            this.txtNumberPhone.CustomButton.Image = null;
            this.txtNumberPhone.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtNumberPhone.CustomButton.Name = "";
            this.txtNumberPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumberPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumberPhone.CustomButton.TabIndex = 1;
            this.txtNumberPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumberPhone.CustomButton.UseSelectable = true;
            this.txtNumberPhone.CustomButton.Visible = false;
            this.txtNumberPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "NumberPhone", true));
            this.txtNumberPhone.Lines = new string[0];
            this.txtNumberPhone.Location = new System.Drawing.Point(81, 197);
            this.txtNumberPhone.MaxLength = 32767;
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.PasswordChar = '\0';
            this.txtNumberPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumberPhone.SelectedText = "";
            this.txtNumberPhone.SelectionLength = 0;
            this.txtNumberPhone.SelectionStart = 0;
            this.txtNumberPhone.ShortcutsEnabled = true;
            this.txtNumberPhone.Size = new System.Drawing.Size(132, 23);
            this.txtNumberPhone.TabIndex = 7;
            this.txtNumberPhone.UseSelectable = true;
            this.txtNumberPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumberPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(8, 201);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 19);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.CustomButton.Image = null;
            this.txtFullName.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtFullName.CustomButton.Name = "";
            this.txtFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullName.CustomButton.TabIndex = 1;
            this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullName.CustomButton.UseSelectable = true;
            this.txtFullName.CustomButton.Visible = false;
            this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FullName", true));
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(81, 163);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(132, 23);
            this.txtFullName.TabIndex = 5;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(7, 172);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(59, 19);
            this.lblNombreCompleto.TabIndex = 4;
            this.lblNombreCompleto.Text = "Nombre";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(81, 134);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(132, 23);
            this.txtId.TabIndex = 3;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(8, 138);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Maroon;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar.Location = new System.Drawing.Point(675, 320);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 38);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(548, 320);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 38);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(293, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 38);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscar.Location = new System.Drawing.Point(422, 320);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 38);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(806, 322);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 38);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(932, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 38);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "Gender", true));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.ItemHeight = 23;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(81, 226);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(132, 29);
            this.cmbGenero.TabIndex = 44;
            this.cmbGenero.UseSelectable = true;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "MaritalStatus", true));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.ItemHeight = 23;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(335, 190);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(418, 29);
            this.cmbEstadoCivil.TabIndex = 45;
            this.cmbEstadoCivil.UseSelectable = true;
            // 
            // cmbSeguroSocial
            // 
            this.cmbSeguroSocial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "HealthInsurance", true));
            this.cmbSeguroSocial.FormattingEnabled = true;
            this.cmbSeguroSocial.ItemHeight = 23;
            this.cmbSeguroSocial.Items.AddRange(new object[] {
            "IMSS",
            "ISSSTE"});
            this.cmbSeguroSocial.Location = new System.Drawing.Point(335, 225);
            this.cmbSeguroSocial.Name = "cmbSeguroSocial";
            this.cmbSeguroSocial.Size = new System.Drawing.Size(418, 29);
            this.cmbSeguroSocial.TabIndex = 46;
            this.cmbSeguroSocial.UseSelectable = true;
            // 
            // employeeBindingSource
            // 
//            this.employeeBindingSource.DataSource = typeof(LVAReciclajeTPDA.Data.Employee);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // numberPhoneDataGridViewTextBoxColumn
            // 
            this.numberPhoneDataGridViewTextBoxColumn.DataPropertyName = "NumberPhone";
            this.numberPhoneDataGridViewTextBoxColumn.HeaderText = "NumberPhone";
            this.numberPhoneDataGridViewTextBoxColumn.Name = "numberPhoneDataGridViewTextBoxColumn";
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            this.contactEmailDataGridViewTextBoxColumn.DataPropertyName = "ContactEmail";
            this.contactEmailDataGridViewTextBoxColumn.HeaderText = "ContactEmail";
            this.contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            // 
            // contrasenaDataGridViewTextBoxColumn
            // 
            this.contrasenaDataGridViewTextBoxColumn.DataPropertyName = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.HeaderText = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.Name = "contrasenaDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            this.streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.HeaderText = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            // 
            // placeOfBirthDataGridViewTextBoxColumn
            // 
            this.placeOfBirthDataGridViewTextBoxColumn.DataPropertyName = "PlaceOfBirth";
            this.placeOfBirthDataGridViewTextBoxColumn.HeaderText = "PlaceOfBirth";
            this.placeOfBirthDataGridViewTextBoxColumn.Name = "placeOfBirthDataGridViewTextBoxColumn";
            // 
            // healthInsuranceDataGridViewTextBoxColumn
            // 
            this.healthInsuranceDataGridViewTextBoxColumn.DataPropertyName = "HealthInsurance";
            this.healthInsuranceDataGridViewTextBoxColumn.HeaderText = "HealthInsurance";
            this.healthInsuranceDataGridViewTextBoxColumn.Name = "healthInsuranceDataGridViewTextBoxColumn";
            // 
            // salesDataGridViewTextBoxColumn
            // 
            this.salesDataGridViewTextBoxColumn.DataPropertyName = "Sales";
            this.salesDataGridViewTextBoxColumn.HeaderText = "Sales";
            this.salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1065, 388);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnGuardar);
            this.ForeColor = System.Drawing.Color.SpringGreen;
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthInsuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroComboBox cbmCiudad;
        private MetroFramework.Controls.MetroComboBox cbmLugarNacimiento;
        private MetroFramework.Controls.MetroLabel lblCiudad;
        private MetroFramework.Controls.MetroTextBox txtNumeroCalle;
        private MetroFramework.Controls.MetroLabel lblNumeroCalle;
        private MetroFramework.Controls.MetroTextBox txtCodigoPotal;
        private MetroFramework.Controls.MetroLabel lblCodigoPostal;
        private MetroFramework.Controls.MetroTextBox txtAdress;
        private MetroFramework.Controls.MetroLabel lblAdress;
        private MetroFramework.Controls.MetroLabel lblSeguroSocial;
        private MetroFramework.Controls.MetroLabel lblLugarNacimiento;
        private MetroFramework.Controls.MetroLabel lblEstadoCivil;
        private MetroFramework.Controls.MetroLabel lblGenero;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtNumberPhone;
        private MetroFramework.Controls.MetroLabel lblTelefono;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private MetroFramework.Controls.MetroLabel lblNombreCompleto;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private System.Windows.Forms.PictureBox pctFoto;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroComboBox cmbSeguroSocial;
        private MetroFramework.Controls.MetroComboBox cmbEstadoCivil;
        private MetroFramework.Controls.MetroComboBox cmbGenero;
    }
}