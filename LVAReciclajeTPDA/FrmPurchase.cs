using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVAReciclajeTPDA
{
    public partial class FrmCompra : MetroFramework.Forms.MetroForm
    {
        public FrmCompra()
        {
            InitializeComponent();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
            //Esto es el de guardar
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
                    MetroFramework.MetroMessageBox.Show(this, "Compra guardada");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void btnBuscarPurchase_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd =
               new OpenFileDialog()
               {
                   Filter = "archivos GIF|*.gif|archivos JPEG|*.jpg|archivos PNG|*.png|Todos los archivos|*.*"
               })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctFoto.Image = Image.FromFile(ofd.FileName);
                    Purchase purchase =
                        purchaseBindingSource.Current as Client;
                    if (purchase != null)
                        purchase.ImageUrl = ofd.FileName;

                }
            }
        }

        private void btnAgregarPurchase_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctPurchase.Image = null;
            purchaseBindingSource.Add(new Client());
            purchaseBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnEditarPurchase_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtName.Focus();
            Purchase purchase =
                purchaseBindingSource.Current as Purchase;
        }

        private void btnEliminarPurchase_Click(object sender, EventArgs e)
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
                        MetroFramework.MetroMessageBox.Show(this, "Cliente eliminado");
                        purchaseBindingSource.RemoveCurrent();
                        pctPurchase.Image = null;
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void btnSalirPurchase_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            purchaseBindingSource.ResetBindings(false);
            FrmPurchase_Load(sender, e);
        }
    }
}
