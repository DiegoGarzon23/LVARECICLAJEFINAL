using LVAReciclajeTPDA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVAReciclajeTPDA
{
    public partial class FrmPurchaseDetail : MetroFramework.Forms.MetroForm
    {
        public FrmPurchaseDetail()
        {
            InitializeComponent();
        }

        private void FrmPurchaseDetail_Load(object sender, EventArgs e)
        {

            using (DataContext dataContext = new DataContext())
            {
                purchaseDetailBindingSource1.DataSource =
                    dataContext.PurchaseDetails.ToList();
            }
            pnlDatos.Enabled = false;
            PurchaseDetail purchaseDetail = purchaseDetailBindingSource1.Current as PurchaseDetail;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                PurchaseDetail purchaseDetail =
                    purchaseDetailBindingSource1.Current as PurchaseDetail;
                if (purchaseDetail != null)
                {
                    if (dataContext.Entry<PurchaseDetail>(purchaseDetail).State == EntityState.Detached)
                        dataContext.Set<PurchaseDetail>().Attach(purchaseDetail);
                    if (purchaseDetail.Id == 0)
                        dataContext.Entry<PurchaseDetail>(purchaseDetail).State = EntityState.Added;
                    else
                        dataContext.Entry<PurchaseDetail>(purchaseDetail).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Detalle de compra guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            purchaseDetailBindingSource1.Add(new PurchaseDetail());
            purchaseDetailBindingSource1.MoveLast();
            txtName.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtName.Focus();
            PurchaseDetail purchaseDetail =
                purchaseDetailBindingSource1.Current as PurchaseDetail;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "¿Quieres eliminar el registro?",
                "Eliminar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    PurchaseDetail purchaseDetail =
                        purchaseDetailBindingSource1.Current as PurchaseDetail;
                    if (purchaseDetail != null)
                    {
                        if (dataContext.Entry<PurchaseDetail>(purchaseDetail).State == EntityState.Detached)
                            dataContext.Set<PurchaseDetail>().Attach(purchaseDetail);
                        dataContext.Entry<PurchaseDetail>(purchaseDetail).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Detalle de compra eliminado");
                        purchaseDetailBindingSource1.RemoveCurrent();
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            purchaseDetailBindingSource1.ResetBindings(false);
            FrmPurchaseDetail_Load(sender, e);
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseDetail purchaseDetail = purchaseDetailBindingSource1.Current as PurchaseDetail;
        }
    }
}
