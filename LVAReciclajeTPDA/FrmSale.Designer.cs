namespace LVAReciclajeTPDA
{
    partial class FrmSale
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
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.cbmCiudad = new MetroFramework.Controls.MetroComboBox();
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
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.cbmCiudad);
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
            this.pnlDatos.Location = new System.Drawing.Point(419, 43);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(610, 176);
            this.pnlDatos.TabIndex = 2;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // cbmCiudad
            // 
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
            this.cbmCiudad.Location = new System.Drawing.Point(333, 3);
            this.cbmCiudad.Name = "cbmCiudad";
            this.cbmCiudad.Size = new System.Drawing.Size(259, 29);
            this.cbmCiudad.TabIndex = 43;
            this.cbmCiudad.UseSelectable = true;
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
            this.txtWeb.Lines = new string[0];
            this.txtWeb.Location = new System.Drawing.Point(333, 128);
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
            this.lblWeb.Location = new System.Drawing.Point(241, 132);
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
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(333, 99);
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
            this.lblEmail.Location = new System.Drawing.Point(243, 103);
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
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(333, 70);
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
            this.lblPhone.Location = new System.Drawing.Point(243, 74);
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
            this.txtCodee.Lines = new string[0];
            this.txtCodee.Location = new System.Drawing.Point(333, 38);
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
            this.lblCodee.Location = new System.Drawing.Point(241, 36);
            this.lblCodee.Name = "lblCodee";
            this.lblCodee.Size = new System.Drawing.Size(91, 19);
            this.lblCodee.TabIndex = 30;
            this.lblCodee.Text = "Codigo Postal";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(243, 7);
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
            this.txtMarca.Lines = new string[0];
            this.txtMarca.Location = new System.Drawing.Point(75, 68);
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
            this.txtNombreEmpresa.Lines = new string[0];
            this.txtNombreEmpresa.Location = new System.Drawing.Point(75, 35);
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
            this.lblMarca.Location = new System.Drawing.Point(3, 68);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca";
            // 
            // lblEnterpriseName
            // 
            this.lblEnterpriseName.AutoSize = true;
            this.lblEnterpriseName.Location = new System.Drawing.Point(3, 39);
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
            this.txtAdress.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtAdress.CustomButton.Name = "";
            this.txtAdress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdress.CustomButton.TabIndex = 1;
            this.txtAdress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdress.CustomButton.UseSelectable = true;
            this.txtAdress.CustomButton.Visible = false;
            this.txtAdress.Lines = new string[0];
            this.txtAdress.Location = new System.Drawing.Point(75, 97);
            this.txtAdress.MaxLength = 32767;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdress.SelectedText = "";
            this.txtAdress.SelectionLength = 0;
            this.txtAdress.SelectionStart = 0;
            this.txtAdress.ShortcutsEnabled = true;
            this.txtAdress.Size = new System.Drawing.Size(160, 23);
            this.txtAdress.TabIndex = 27;
            this.txtAdress.UseSelectable = true;
            this.txtAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(0, 97);
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
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(75, 6);
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
            this.lblId.Location = new System.Drawing.Point(3, 7);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 63);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(240, 150);
            this.metroGrid1.TabIndex = 3;
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.pnlDatos);
            this.Name = "FrmSale";
            this.Text = "FrmSale";
            this.Load += new System.EventHandler(this.FrmSale_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroComboBox cbmCiudad;
        private MetroFramework.Controls.MetroTextBox txtWeb;
        private MetroFramework.Controls.MetroLabel lblWeb;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroTextBox txtCodee;
        private MetroFramework.Controls.MetroLabel lblCodee;
        private MetroFramework.Controls.MetroLabel lblCiudad;
        private MetroFramework.Controls.MetroTextBox txtMarca;
        private MetroFramework.Controls.MetroTextBox txtNombreEmpresa;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private MetroFramework.Controls.MetroLabel lblEnterpriseName;
        private MetroFramework.Controls.MetroTextBox txtAdress;
        private MetroFramework.Controls.MetroLabel lblAdress;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameSellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameBuyerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}