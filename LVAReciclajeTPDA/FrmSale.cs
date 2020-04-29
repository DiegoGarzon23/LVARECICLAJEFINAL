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
    public partial class FrmSale : MetroFramework.Forms.MetroForm
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                sale sale =
                saleBindingSource.Current as sale;
                if (sale != null)
                {
                    if (dataContext.Entry<Sale>(sale).State == EntityState.Detached)
                        dataContext.Set<Sale>().Attach(sale);
                    if (sale.Id == 0)
                        dataContext.Entry<Sale>(sale).State = EntityState.Added;
                    else
                        dataContext.Entry<Sale>(sale).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Vendedor guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Sale sale =
                saleBindingSource.Current as Sale;
                if (client != null)
                {
                    if (dataContext.Entry<Sale>(sale).State == EntityState.Detached)
                        dataContext.Set<Sale>().Attach(sale);
                    if (sale.Id == 0)
                        dataContext.Entry<Sale>(sale).State = EntityState.Added;
                    else
                        dataContext.Entry<Sale>(sale).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Vendedor guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctFoto.Image = null;
            saleBindingSource.Add(new Sale());
            saleBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtName.Focus();
            Sale sale =
                saleBindingSource.Current as Sale;
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
                    if (client != null)
                    {
                        if (dataContext.Entry<Sale>(sale).State == EntityState.Detached)
                            dataContext.Set<Sale>().Attach(sale);
                        dataContext.Entry<Sale>(sale).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Vendedor eliminado");
                        saleBindingSource.RemoveCurrent();
                        pctFoto.Image = null;
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }
    }
}
