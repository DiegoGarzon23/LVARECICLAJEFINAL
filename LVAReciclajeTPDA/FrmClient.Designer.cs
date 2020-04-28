namespace LVAReciclajeTPDA
{
    partial class FrmClient
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtAdress = new MetroFramework.Controls.MetroTextBox();
            this.lblAdress = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.txtCurp = new MetroFramework.Controls.MetroTextBox();
            this.lblCurp = new MetroFramework.Controls.MetroLabel();
            this.txtRfc = new MetroFramework.Controls.MetroTextBox();
            this.lblRfc = new MetroFramework.Controls.MetroLabel();
            this.txtSurName = new MetroFramework.Controls.MetroTextBox();
            this.lblSurName = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtCodee = new MetroFramework.Controls.MetroTextBox();
            this.lblCodee = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
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
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnamesDataGridViewTextBoxColumn,
            this.rfcDataGridViewTextBoxColumn,
            this.curpDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.employeesDataGridViewTextBoxColumn,
            this.salesDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.clientBindingSource;
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
            this.grdDatos.Location = new System.Drawing.Point(7, 63);
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
            this.grdDatos.Size = new System.Drawing.Size(249, 301);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnamesDataGridViewTextBoxColumn
            // 
            this.surnamesDataGridViewTextBoxColumn.DataPropertyName = "Surnames";
            this.surnamesDataGridViewTextBoxColumn.HeaderText = "Surnames";
            this.surnamesDataGridViewTextBoxColumn.Name = "surnamesDataGridViewTextBoxColumn";
            // 
            // rfcDataGridViewTextBoxColumn
            // 
            this.rfcDataGridViewTextBoxColumn.DataPropertyName = "Rfc";
            this.rfcDataGridViewTextBoxColumn.HeaderText = "Rfc";
            this.rfcDataGridViewTextBoxColumn.Name = "rfcDataGridViewTextBoxColumn";
            // 
            // curpDataGridViewTextBoxColumn
            // 
            this.curpDataGridViewTextBoxColumn.DataPropertyName = "Curp";
            this.curpDataGridViewTextBoxColumn.HeaderText = "Curp";
            this.curpDataGridViewTextBoxColumn.Name = "curpDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // employeesDataGridViewTextBoxColumn
            // 
            this.employeesDataGridViewTextBoxColumn.DataPropertyName = "Employees";
            this.employeesDataGridViewTextBoxColumn.HeaderText = "Employees";
            this.employeesDataGridViewTextBoxColumn.Name = "employeesDataGridViewTextBoxColumn";
            // 
            // salesDataGridViewTextBoxColumn
            // 
            this.salesDataGridViewTextBoxColumn.DataPropertyName = "Sales";
            this.salesDataGridViewTextBoxColumn.HeaderText = "Sales";
            this.salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            //this.clientBindingSource.DataSource = typeof(LVAReciclajeTPDA.Data.Client);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.txtCodee);
            this.pnlDatos.Controls.Add(this.lblCodee);
            this.pnlDatos.Controls.Add(this.pctFoto);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.txtAdress);
            this.pnlDatos.Controls.Add(this.lblAdress);
            this.pnlDatos.Controls.Add(this.lblEmail);
            this.pnlDatos.Controls.Add(this.txtPhone);
            this.pnlDatos.Controls.Add(this.lblPhone);
            this.pnlDatos.Controls.Add(this.txtCurp);
            this.pnlDatos.Controls.Add(this.lblCurp);
            this.pnlDatos.Controls.Add(this.txtRfc);
            this.pnlDatos.Controls.Add(this.lblRfc);
            this.pnlDatos.Controls.Add(this.txtSurName);
            this.pnlDatos.Controls.Add(this.lblSurName);
            this.pnlDatos.Controls.Add(this.txtName);
            this.pnlDatos.Controls.Add(this.lblName);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(262, 63);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(533, 247);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // pctFoto
            // 
            this.pctFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clientBindingSource, "ImageUrl", true));
            this.pctFoto.Location = new System.Drawing.Point(12, 11);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(185, 132);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFoto.TabIndex = 20;
            this.pctFoto.TabStop = false;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Contact", true));
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(294, 125);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(221, 23);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdress
            // 
            // 
            // 
            // 
            this.txtAdress.CustomButton.Image = null;
            this.txtAdress.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtAdress.CustomButton.Name = "";
            this.txtAdress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdress.CustomButton.TabIndex = 1;
            this.txtAdress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdress.CustomButton.UseSelectable = true;
            this.txtAdress.CustomButton.Visible = false;
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Address", true));
            this.txtAdress.Lines = new string[0];
            this.txtAdress.Location = new System.Drawing.Point(294, 96);
            this.txtAdress.MaxLength = 32767;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdress.SelectedText = "";
            this.txtAdress.SelectionLength = 0;
            this.txtAdress.SelectionStart = 0;
            this.txtAdress.ShortcutsEnabled = true;
            this.txtAdress.Size = new System.Drawing.Size(221, 23);
            this.txtAdress.TabIndex = 15;
            this.txtAdress.UseSelectable = true;
            this.txtAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(214, 96);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(63, 19);
            this.lblAdress.TabIndex = 14;
            this.lblAdress.Text = "Dirección";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(212, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Phone", true));
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(294, 67);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(221, 23);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(214, 67);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 19);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Teléfono";
            // 
            // txtCurp
            // 
            // 
            // 
            // 
            this.txtCurp.CustomButton.Image = null;
            this.txtCurp.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtCurp.CustomButton.Name = "";
            this.txtCurp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCurp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurp.CustomButton.TabIndex = 1;
            this.txtCurp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurp.CustomButton.UseSelectable = true;
            this.txtCurp.CustomButton.Visible = false;
            this.txtCurp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Curp", true));
            this.txtCurp.Lines = new string[0];
            this.txtCurp.Location = new System.Drawing.Point(294, 36);
            this.txtCurp.MaxLength = 32767;
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.PasswordChar = '\0';
            this.txtCurp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurp.SelectedText = "";
            this.txtCurp.SelectionLength = 0;
            this.txtCurp.SelectionStart = 0;
            this.txtCurp.ShortcutsEnabled = true;
            this.txtCurp.Size = new System.Drawing.Size(221, 23);
            this.txtCurp.TabIndex = 11;
            this.txtCurp.UseSelectable = true;
            this.txtCurp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Location = new System.Drawing.Point(214, 36);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(43, 19);
            this.lblCurp.TabIndex = 10;
            this.lblCurp.Text = "CURP";
            // 
            // txtRfc
            // 
            // 
            // 
            // 
            this.txtRfc.CustomButton.Image = null;
            this.txtRfc.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtRfc.CustomButton.Name = "";
            this.txtRfc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRfc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRfc.CustomButton.TabIndex = 1;
            this.txtRfc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRfc.CustomButton.UseSelectable = true;
            this.txtRfc.CustomButton.Visible = false;
            this.txtRfc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Rfc", true));
            this.txtRfc.Lines = new string[0];
            this.txtRfc.Location = new System.Drawing.Point(294, 7);
            this.txtRfc.MaxLength = 32767;
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.PasswordChar = '\0';
            this.txtRfc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRfc.SelectedText = "";
            this.txtRfc.SelectionLength = 0;
            this.txtRfc.SelectionStart = 0;
            this.txtRfc.ShortcutsEnabled = true;
            this.txtRfc.Size = new System.Drawing.Size(221, 23);
            this.txtRfc.TabIndex = 9;
            this.txtRfc.UseSelectable = true;
            this.txtRfc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRfc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Location = new System.Drawing.Point(214, 11);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(33, 19);
            this.lblRfc.TabIndex = 8;
            this.lblRfc.Text = "RFC";
            // 
            // txtSurName
            // 
            // 
            // 
            // 
            this.txtSurName.CustomButton.Image = null;
            this.txtSurName.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.txtSurName.CustomButton.Name = "";
            this.txtSurName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSurName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSurName.CustomButton.TabIndex = 1;
            this.txtSurName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSurName.CustomButton.UseSelectable = true;
            this.txtSurName.CustomButton.Visible = false;
            this.txtSurName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Surnames", true));
            this.txtSurName.Lines = new string[0];
            this.txtSurName.Location = new System.Drawing.Point(77, 216);
            this.txtSurName.MaxLength = 32767;
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.PasswordChar = '\0';
            this.txtSurName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSurName.SelectedText = "";
            this.txtSurName.SelectionLength = 0;
            this.txtSurName.SelectionStart = 0;
            this.txtSurName.ShortcutsEnabled = true;
            this.txtSurName.Size = new System.Drawing.Size(438, 23);
            this.txtSurName.TabIndex = 7;
            this.txtSurName.UseSelectable = true;
            this.txtSurName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSurName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(12, 216);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(63, 19);
            this.lblSurName.TabIndex = 6;
            this.lblSurName.Text = "Apellidos";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Name", true));
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(77, 182);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(438, 23);
            this.txtName.TabIndex = 5;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 186);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(77, 153);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(120, 23);
            this.txtId.TabIndex = 3;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 157);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PostalCode", true));
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(120, 139);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(107, 23);
            this.txtCode.TabIndex = 17;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(7, 143);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(91, 19);
            this.lblCode.TabIndex = 16;
            this.lblCode.Text = "Codigo Postal";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(718, 326);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 38);
            this.btnSalir.TabIndex = 54;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(634, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 38);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscar.Location = new System.Drawing.Point(366, 326);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 38);
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Maroon;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar.Location = new System.Drawing.Point(556, 326);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 38);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(467, 326);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 38);
            this.btnAgregar.TabIndex = 50;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(262, 326);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 38);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodee
            // 
            // 
            // 
            // 
            this.txtCodee.CustomButton.Image = null;
            this.txtCodee.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtCodee.CustomButton.Name = "";
            this.txtCodee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodee.CustomButton.TabIndex = 1;
            this.txtCodee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodee.CustomButton.UseSelectable = true;
            this.txtCodee.CustomButton.Visible = false;
            this.txtCodee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PostalCode", true));
            this.txtCodee.Lines = new string[0];
            this.txtCodee.Location = new System.Drawing.Point(294, 154);
            this.txtCodee.MaxLength = 32767;
            this.txtCodee.Name = "txtCodee";
            this.txtCodee.PasswordChar = '\0';
            this.txtCodee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodee.SelectedText = "";
            this.txtCodee.SelectionLength = 0;
            this.txtCodee.SelectionStart = 0;
            this.txtCodee.ShortcutsEnabled = true;
            this.txtCodee.Size = new System.Drawing.Size(221, 23);
            this.txtCodee.TabIndex = 22;
            this.txtCodee.UseSelectable = true;
            this.txtCodee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCodee
            // 
            this.lblCodee.AutoSize = true;
            this.lblCodee.Location = new System.Drawing.Point(205, 153);
            this.lblCodee.Name = "lblCodee";
            this.lblCodee.Size = new System.Drawing.Size(91, 19);
            this.lblCodee.TabIndex = 21;
            this.lblCodee.Text = "Codigo Postal";
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 387);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Name = "FrmClient";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroTextBox txtSurName;
        private MetroFramework.Controls.MetroLabel lblSurName;
        private MetroFramework.Controls.MetroTextBox txtRfc;
        private MetroFramework.Controls.MetroLabel lblRfc;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroTextBox txtCurp;
        private MetroFramework.Controls.MetroLabel lblCurp;
        private MetroFramework.Controls.MetroTextBox txtAdress;
        private MetroFramework.Controls.MetroLabel lblAdress;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel lblCode;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private System.Windows.Forms.PictureBox pctFoto;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txtCodee;
        private MetroFramework.Controls.MetroLabel lblCodee;
    }
}