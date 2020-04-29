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
    public partial class FrmSale : MetroFramework.Forms.MetroForm
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                saleBindingSource.DataSource =
                    dataContext.Sales.ToList();
            }
            pnlDatos.Enabled = false;
            Sale sale = saleBindingSource.Current as Sale;
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Sale sale =
                saleBindingSource.Current as Sale;
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

      
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            saleBindingSource.Add(new Sale());
            saleBindingSource.MoveLast();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtCompany.Focus();
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

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sale client = saleBindingSource.Current as Sale;
         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            saleBindingSource.ResetBindings(false);
            FrmSale_Load(sender, e);
        }

       
    }
}


