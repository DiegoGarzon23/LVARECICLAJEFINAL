namespace LVAReciclajeTPDA
{
    partial class FrmPurchaseDetail
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
            this.purchaseDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseDetailBindingSource
            // 
            this.purchaseDetailBindingSource.DataSource = typeof(LVAReciclajeTPDA.Data.PurchaseDetail);
            // 
            // FrmPurchaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmPurchaseDetail";
            this.Text = "FrmPurchaseDetail";
            this.Load += new System.EventHandler(this.FrmPurchaseDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource purchaseDetailBindingSource;
    }
}