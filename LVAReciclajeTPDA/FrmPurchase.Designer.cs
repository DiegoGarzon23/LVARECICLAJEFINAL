﻿namespace LVAReciclajeTPDA
{
    partial class FrmPurchase
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
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.lblDescription = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.lblQuantity = new MetroFramework.Controls.MetroLabel();
            this.txtBilling = new MetroFramework.Controls.MetroTextBox();
            this.lblBilling = new MetroFramework.Controls.MetroLabel();
            this.cbmCity = new MetroFramework.Controls.MetroComboBox();
            this.txtWeb = new MetroFramework.Controls.MetroTextBox();
            this.lblWeb = new MetroFramework.Controls.MetroLabel();
            this.txtContactEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblContactEmail = new MetroFramework.Controls.MetroLabel();
            this.txtNumberPhone = new MetroFramework.Controls.MetroTextBox();
            this.lblNumberPhone = new MetroFramework.Controls.MetroLabel();
            this.lblCity = new MetroFramework.Controls.MetroLabel();
            this.txtFullNameBuyer = new MetroFramework.Controls.MetroTextBox();
            this.lblFullNameBuyer = new MetroFramework.Controls.MetroLabel();
            this.txtAdress = new MetroFramework.Controls.MetroTextBox();
            this.lblAdress = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalir.Location = new System.Drawing.Point(498, 416);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 38);
            this.btnSalir.TabIndex = 60;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(414, 416);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 38);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Maroon;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscar.Location = new System.Drawing.Point(146, 416);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 38);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Maroon;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar.Location = new System.Drawing.Point(336, 416);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 38);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(247, 416);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 38);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(42, 416);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 38);
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.txtDescription);
            this.pnlDatos.Controls.Add(this.lblDescription);
            this.pnlDatos.Controls.Add(this.txtQuantity);
            this.pnlDatos.Controls.Add(this.lblQuantity);
            this.pnlDatos.Controls.Add(this.txtBilling);
            this.pnlDatos.Controls.Add(this.lblBilling);
            this.pnlDatos.Controls.Add(this.cbmCity);
            this.pnlDatos.Controls.Add(this.txtWeb);
            this.pnlDatos.Controls.Add(this.lblWeb);
            this.pnlDatos.Controls.Add(this.txtContactEmail);
            this.pnlDatos.Controls.Add(this.lblContactEmail);
            this.pnlDatos.Controls.Add(this.txtNumberPhone);
            this.pnlDatos.Controls.Add(this.lblNumberPhone);
            this.pnlDatos.Controls.Add(this.lblCity);
            this.pnlDatos.Controls.Add(this.txtFullNameBuyer);
            this.pnlDatos.Controls.Add(this.lblFullNameBuyer);
            this.pnlDatos.Controls.Add(this.txtAdress);
            this.pnlDatos.Controls.Add(this.lblAdress);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(23, 72);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(649, 324);
            this.pnlDatos.TabIndex = 61;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDatos_Paint);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(458, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(131, 221);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(480, 23);
            this.txtDescription.TabIndex = 71;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(19, 221);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(74, 19);
            this.lblDescription.TabIndex = 70;
            this.lblDescription.Text = "Description";
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(451, 74);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(160, 23);
            this.txtQuantity.TabIndex = 69;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(379, 78);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 19);
            this.lblQuantity.TabIndex = 68;
            this.lblQuantity.Text = "Cantidad";
            // 
            // txtBilling
            // 
            // 
            // 
            // 
            this.txtBilling.CustomButton.Image = null;
            this.txtBilling.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtBilling.CustomButton.Name = "";
            this.txtBilling.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBilling.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBilling.CustomButton.TabIndex = 1;
            this.txtBilling.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBilling.CustomButton.UseSelectable = true;
            this.txtBilling.CustomButton.Visible = false;
            this.txtBilling.Lines = new string[0];
            this.txtBilling.Location = new System.Drawing.Point(451, 41);
            this.txtBilling.MaxLength = 32767;
            this.txtBilling.Name = "txtBilling";
            this.txtBilling.PasswordChar = '\0';
            this.txtBilling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBilling.SelectedText = "";
            this.txtBilling.SelectionLength = 0;
            this.txtBilling.SelectionStart = 0;
            this.txtBilling.ShortcutsEnabled = true;
            this.txtBilling.Size = new System.Drawing.Size(160, 23);
            this.txtBilling.TabIndex = 67;
            this.txtBilling.UseSelectable = true;
            this.txtBilling.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBilling.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.Location = new System.Drawing.Point(379, 45);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(44, 19);
            this.lblBilling.TabIndex = 66;
            this.lblBilling.Text = "Billing";
            // 
            // cbmCity
            // 
            this.cbmCity.FormattingEnabled = true;
            this.cbmCity.ItemHeight = 23;
            this.cbmCity.Items.AddRange(new object[] {
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
            this.cbmCity.Location = new System.Drawing.Point(197, 136);
            this.cbmCity.Name = "cbmCity";
            this.cbmCity.Size = new System.Drawing.Size(160, 29);
            this.cbmCity.TabIndex = 65;
            this.cbmCity.UseSelectable = true;
            // 
            // txtWeb
            // 
            // 
            // 
            // 
            this.txtWeb.CustomButton.Image = null;
            this.txtWeb.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtWeb.CustomButton.Name = "";
            this.txtWeb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWeb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWeb.CustomButton.TabIndex = 1;
            this.txtWeb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWeb.CustomButton.UseSelectable = true;
            this.txtWeb.CustomButton.Visible = false;
            this.txtWeb.Lines = new string[0];
            this.txtWeb.Location = new System.Drawing.Point(451, 166);
            this.txtWeb.MaxLength = 32767;
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.PasswordChar = '\0';
            this.txtWeb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeb.SelectedText = "";
            this.txtWeb.SelectionLength = 0;
            this.txtWeb.SelectionStart = 0;
            this.txtWeb.ShortcutsEnabled = true;
            this.txtWeb.Size = new System.Drawing.Size(160, 23);
            this.txtWeb.TabIndex = 64;
            this.txtWeb.UseSelectable = true;
            this.txtWeb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWeb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(391, 170);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(36, 19);
            this.lblWeb.TabIndex = 63;
            this.lblWeb.Text = "Web";
            // 
            // txtContactEmail
            // 
            // 
            // 
            // 
            this.txtContactEmail.CustomButton.Image = null;
            this.txtContactEmail.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtContactEmail.CustomButton.Name = "";
            this.txtContactEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContactEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContactEmail.CustomButton.TabIndex = 1;
            this.txtContactEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContactEmail.CustomButton.UseSelectable = true;
            this.txtContactEmail.CustomButton.Visible = false;
            this.txtContactEmail.Lines = new string[0];
            this.txtContactEmail.Location = new System.Drawing.Point(451, 136);
            this.txtContactEmail.MaxLength = 32767;
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.PasswordChar = '\0';
            this.txtContactEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactEmail.SelectedText = "";
            this.txtContactEmail.SelectionLength = 0;
            this.txtContactEmail.SelectionStart = 0;
            this.txtContactEmail.ShortcutsEnabled = true;
            this.txtContactEmail.Size = new System.Drawing.Size(160, 23);
            this.txtContactEmail.TabIndex = 62;
            this.txtContactEmail.UseSelectable = true;
            this.txtContactEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContactEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Location = new System.Drawing.Point(391, 140);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(41, 19);
            this.lblContactEmail.TabIndex = 61;
            this.lblContactEmail.Text = "Email";
            // 
            // txtNumberPhone
            // 
            // 
            // 
            // 
            this.txtNumberPhone.CustomButton.Image = null;
            this.txtNumberPhone.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtNumberPhone.CustomButton.Name = "";
            this.txtNumberPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumberPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumberPhone.CustomButton.TabIndex = 1;
            this.txtNumberPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumberPhone.CustomButton.UseSelectable = true;
            this.txtNumberPhone.CustomButton.Visible = false;
            this.txtNumberPhone.Lines = new string[0];
            this.txtNumberPhone.Location = new System.Drawing.Point(451, 107);
            this.txtNumberPhone.MaxLength = 32767;
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.PasswordChar = '\0';
            this.txtNumberPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumberPhone.SelectedText = "";
            this.txtNumberPhone.SelectionLength = 0;
            this.txtNumberPhone.SelectionStart = 0;
            this.txtNumberPhone.ShortcutsEnabled = true;
            this.txtNumberPhone.Size = new System.Drawing.Size(160, 23);
            this.txtNumberPhone.TabIndex = 60;
            this.txtNumberPhone.UseSelectable = true;
            this.txtNumberPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumberPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNumberPhone
            // 
            this.lblNumberPhone.AutoSize = true;
            this.lblNumberPhone.Location = new System.Drawing.Point(379, 112);
            this.lblNumberPhone.Name = "lblNumberPhone";
            this.lblNumberPhone.Size = new System.Drawing.Size(58, 19);
            this.lblNumberPhone.TabIndex = 59;
            this.lblNumberPhone.Text = "Teléfono";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(123, 146);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(51, 19);
            this.lblCity.TabIndex = 56;
            this.lblCity.Text = "Ciudad";
            // 
            // txtFullNameBuyer
            // 
            // 
            // 
            // 
            this.txtFullNameBuyer.CustomButton.Image = null;
            this.txtFullNameBuyer.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtFullNameBuyer.CustomButton.Name = "";
            this.txtFullNameBuyer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFullNameBuyer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullNameBuyer.CustomButton.TabIndex = 1;
            this.txtFullNameBuyer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullNameBuyer.CustomButton.UseSelectable = true;
            this.txtFullNameBuyer.CustomButton.Visible = false;
            this.txtFullNameBuyer.Lines = new string[0];
            this.txtFullNameBuyer.Location = new System.Drawing.Point(197, 78);
            this.txtFullNameBuyer.MaxLength = 32767;
            this.txtFullNameBuyer.Name = "txtFullNameBuyer";
            this.txtFullNameBuyer.PasswordChar = '\0';
            this.txtFullNameBuyer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullNameBuyer.SelectedText = "";
            this.txtFullNameBuyer.SelectionLength = 0;
            this.txtFullNameBuyer.SelectionStart = 0;
            this.txtFullNameBuyer.ShortcutsEnabled = true;
            this.txtFullNameBuyer.Size = new System.Drawing.Size(160, 23);
            this.txtFullNameBuyer.TabIndex = 53;
            this.txtFullNameBuyer.UseSelectable = true;
            this.txtFullNameBuyer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullNameBuyer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblFullNameBuyer
            // 
            this.lblFullNameBuyer.AutoSize = true;
            this.lblFullNameBuyer.Location = new System.Drawing.Point(11, 78);
            this.lblFullNameBuyer.Name = "lblFullNameBuyer";
            this.lblFullNameBuyer.Size = new System.Drawing.Size(155, 19);
            this.lblFullNameBuyer.TabIndex = 52;
            this.lblFullNameBuyer.Text = "Nombre del Comprador";
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
            this.txtAdress.Location = new System.Drawing.Point(197, 107);
            this.txtAdress.MaxLength = 32767;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdress.SelectedText = "";
            this.txtAdress.SelectionLength = 0;
            this.txtAdress.SelectionStart = 0;
            this.txtAdress.ShortcutsEnabled = true;
            this.txtAdress.Size = new System.Drawing.Size(160, 23);
            this.txtAdress.TabIndex = 55;
            this.txtAdress.UseSelectable = true;
            this.txtAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(103, 114);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(63, 19);
            this.lblAdress.TabIndex = 54;
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
            this.txtId.Location = new System.Drawing.Point(197, 49);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(160, 23);
            this.txtId.TabIndex = 51;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(146, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 50;
            this.lblId.Text = "Id";
            // 
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 532);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmPurchase";
            this.Text = "FrmPurchase";
            this.Load += new System.EventHandler(this.FrmPurchase_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel lblDescription;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel lblQuantity;
        private MetroFramework.Controls.MetroTextBox txtBilling;
        private MetroFramework.Controls.MetroLabel lblBilling;
        private MetroFramework.Controls.MetroComboBox cbmCity;
        private MetroFramework.Controls.MetroTextBox txtWeb;
        private MetroFramework.Controls.MetroLabel lblWeb;
        private MetroFramework.Controls.MetroTextBox txtContactEmail;
        private MetroFramework.Controls.MetroLabel lblContactEmail;
        private MetroFramework.Controls.MetroTextBox txtNumberPhone;
        private MetroFramework.Controls.MetroLabel lblNumberPhone;
        private MetroFramework.Controls.MetroLabel lblCity;
        private MetroFramework.Controls.MetroTextBox txtFullNameBuyer;
        private MetroFramework.Controls.MetroLabel lblFullNameBuyer;
        private MetroFramework.Controls.MetroTextBox txtAdress;
        private MetroFramework.Controls.MetroLabel lblAdress;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
    }
}