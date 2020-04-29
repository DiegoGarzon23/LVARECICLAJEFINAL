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
    public partial class FrmPurchase : MetroFramework.Forms.MetroForm
    {
        public FrmPurchase()
        {
            InitializeComponent();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                purchaseBindingSource.DataSource =
                    dataContext.Purchases.ToList();
            }
            pnlDatos.Enabled = false;
            Purchase purchase = purchaseBindingSource.Current as Purchase;

        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Purchase purchase =
                purchaseBindingSource.Current as Purchase;
                if (purchase != null)
                {
                    if (dataContext.Entry<Purchase>(purchase).State == EntityState.Detached)
                        dataContext.Set<Purchase>().Attach(purchase);
                    if (purchase.Id == 0)
                        dataContext.Entry<Purchase>(purchase).State = EntityState.Added;
                    else
                        dataContext.Entry<Purchase>(purchase).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Compra  guardada exitosamente");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

    

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            purchaseBindingSource.Add(new Purchase());
            purchaseBindingSource.MoveLast();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtFullNameBuyer.Focus();
            Purchase purchase =
                purchaseBindingSource.Current as Purchase;
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
                    Purchase purchase =
                        purchaseBindingSource.Current as Purchase;
                    if (purchase != null)
                    {
                        if (dataContext.Entry<Purchase>(purchase).State == EntityState.Detached)
                            dataContext.Set<Purchase>().Attach(purchase);
                        dataContext.Entry<Purchase>(purchase).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Compra eliminada");
                        purchaseBindingSource.RemoveCurrent();
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            purchaseBindingSource.ResetBindings(false);
            FrmPurchase_Load(sender, e);
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Purchase purchase = purchaseBindingSource.Current as Purchase;

        }

       
    }
}
