namespace LVAReciclajeTPDA
{
    partial class FrmSaleDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.saleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameSellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameBuyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtLd = new MetroFramework.Controls.MetroTextBox();
            this.lblDateTime = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.lblDescription = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailBindingSource)).BeginInit();
            this.pnlDatos.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameSellerDataGridViewTextBoxColumn,
            this.sellerPhoneDataGridViewTextBoxColumn,
            this.sellerEmailDataGridViewTextBoxColumn,
            this.buyerNameDataGridViewTextBoxColumn,
            this.fullNameBuyerDataGridViewTextBoxColumn,
            this.buyerPhoneDataGridViewTextBoxColumn,
            this.buyerEmailDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.saleDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.saleDetailBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(5, 63);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(240, 150);
            this.grdDatos.TabIndex = 0;
            // 
            // saleDetailBindingSource
            // 
            this.saleDetailBindingSource.DataSource = typeof(LVAReciclajeTPDA.Data.SaleDetail);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameSellerDataGridViewTextBoxColumn
            // 
            this.fullNameSellerDataGridViewTextBoxColumn.DataPropertyName = "FullNameSeller";
            this.fullNameSellerDataGridViewTextBoxColumn.HeaderText = "FullNameSeller";
            this.fullNameSellerDataGridViewTextBoxColumn.Name = "fullNameSellerDataGridViewTextBoxColumn";
            // 
            // sellerPhoneDataGridViewTextBoxColumn
            // 
            this.sellerPhoneDataGridViewTextBoxColumn.DataPropertyName = "SellerPhone";
            this.sellerPhoneDataGridViewTextBoxColumn.HeaderText = "SellerPhone";
            this.sellerPhoneDataGridViewTextBoxColumn.Name = "sellerPhoneDataGridViewTextBoxColumn";
            // 
            // sellerEmailDataGridViewTextBoxColumn
            // 
            this.sellerEmailDataGridViewTextBoxColumn.DataPropertyName = "SellerEmail";
            this.sellerEmailDataGridViewTextBoxColumn.HeaderText = "SellerEmail";
            this.sellerEmailDataGridViewTextBoxColumn.Name = "sellerEmailDataGridViewTextBoxColumn";
            // 
            // buyerNameDataGridViewTextBoxColumn
            // 
            this.buyerNameDataGridViewTextBoxColumn.DataPropertyName = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.HeaderText = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.Name = "buyerNameDataGridViewTextBoxColumn";
            // 
            // fullNameBuyerDataGridViewTextBoxColumn
            // 
            this.fullNameBuyerDataGridViewTextBoxColumn.DataPropertyName = "FullNameBuyer";
            this.fullNameBuyerDataGridViewTextBoxColumn.HeaderText = "FullNameBuyer";
            this.fullNameBuyerDataGridViewTextBoxColumn.Name = "fullNameBuyerDataGridViewTextBoxColumn";
            // 
            // buyerPhoneDataGridViewTextBoxColumn
            // 
            this.buyerPhoneDataGridViewTextBoxColumn.DataPropertyName = "BuyerPhone";
            this.buyerPhoneDataGridViewTextBoxColumn.HeaderText = "BuyerPhone";
            this.buyerPhoneDataGridViewTextBoxColumn.Name = "buyerPhoneDataGridViewTextBoxColumn";
            // 
            // buyerEmailDataGridViewTextBoxColumn
            // 
            this.buyerEmailDataGridViewTextBoxColumn.DataPropertyName = "BuyerEmail";
            this.buyerEmailDataGridViewTextBoxColumn.HeaderText = "BuyerEmail";
            this.buyerEmailDataGridViewTextBoxColumn.Name = "buyerEmailDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // saleDataGridViewTextBoxColumn
            // 
            this.saleDataGridViewTextBoxColumn.DataPropertyName = "Sale";
            this.saleDataGridViewTextBoxColumn.HeaderText = "Sale";
            this.saleDataGridViewTextBoxColumn.Name = "saleDataGridViewTextBoxColumn";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.txtDescription);
            this.pnlDatos.Controls.Add(this.lblDescription);
            this.pnlDatos.Controls.Add(this.metroDateTime2);
            this.pnlDatos.Controls.Add(this.lblDate);
            this.pnlDatos.Controls.Add(this.metroDateTime1);
            this.pnlDatos.Controls.Add(this.lblDateTime);
            this.pnlDatos.Controls.Add(this.txtLd);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(251, 63);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(441, 179);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Ld";
            // 
            // txtLd
            // 
            // 
            // 
            // 
            this.txtLd.CustomButton.Image = null;
            this.txtLd.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtLd.CustomButton.Name = "";
            this.txtLd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLd.CustomButton.TabIndex = 1;
            this.txtLd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLd.CustomButton.UseSelectable = true;
            this.txtLd.CustomButton.Visible = false;
            this.txtLd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleDetailBindingSource, "Id", true));
            this.txtLd.Lines = new string[0];
            this.txtLd.Location = new System.Drawing.Point(132, 10);
            this.txtLd.MaxLength = 32767;
            this.txtLd.Name = "txtLd";
            this.txtLd.PasswordChar = '\0';
            this.txtLd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLd.SelectedText = "";
            this.txtLd.SelectionLength = 0;
            this.txtLd.SelectionStart = 0;
            this.txtLd.ShortcutsEnabled = true;
            this.txtLd.Size = new System.Drawing.Size(200, 23);
            this.txtLd.TabIndex = 3;
            this.txtLd.UseSelectable = true;
            this.txtLd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(12, 45);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(110, 19);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "Fecha Asignación";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(132, 45);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 87);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(114, 19);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Fecha Finalización";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(132, 87);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 122);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 19);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Descripción";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(132, 122);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(200, 23);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmSaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Name = "FrmSaleDetail";
            this.Text = "Detalle Venta";
            this.Load += new System.EventHandler(this.FrmSaleDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameSellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameBuyerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource saleDetailBindingSource;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroLabel lblDateTime;
        private MetroFramework.Controls.MetroTextBox txtLd;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel lblDescription;
    }
}