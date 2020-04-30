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
    public partial class FrmPurchase : MetroFramework.Forms.MetroForm
    {
        public FrmPurchase()
        {
            InitializeComponent();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
        {

        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {

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
                    MetroFramework.MetroMessageBox.Show(this, "Vendedor guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd =
               new OpenFileDialog()
               {
                   Filter = "archivos GIF|*.gif|archivos JPEG|*.jpg|archivos PNG|*.png|Todos los archivos|*.*"
               })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                   Purchase client =
                        purchaseBindingSource.Current as Purchase;
                    if (purchase != null)
                        client.ImageUrl = ofd.FileName;

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
            txtCompany.Focus();
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
                    Sale sale =
                        saleBindingSource.Current as Sale;
                    if (sale != null)
                    {
                        if (dataContext.Entry<Sale>(sale).State == EntityState.Detached)
                            dataContext.Set<Sale>().Attach(sale);
                        dataContext.Entry<Sale>(sale).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Vendedor eliminado");
                        saleBindingSource.RemoveCurrent();
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            saleBindingSource.ResetBindings(false);
            FrmSale_Load(sender, e);
        }
    }
}
