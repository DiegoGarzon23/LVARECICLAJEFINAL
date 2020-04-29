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
    public partial class FrmSaleDetail : MetroFramework.Forms.MetroForm
    {
        public FrmSaleDetail()
        {
            InitializeComponent();
        }

        private void FrmSaleDetail_Load(object sender, EventArgs e)
        {

            using (DataContext dataContext = new DataContext())
            {
                saleDetailBindingSource.DataSource =
                    dataContext.SaleDetails.ToList();
            }
            pnlDatos.Enabled = false;
            SaleDetail saleDetail = saleDetailBindingSource.Current as SaleDetail;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                SaleDetail saleDetail =
                    saleDetailBindingSource.Current as SaleDetail;
                if (saleDetail != null)
                {
                    if (dataContext.Entry<SaleDetail>(saleDetail).State == EntityState.Detached)
                        dataContext.Set<SaleDetail>().Attach(saleDetail);
                    if (saleDetail.Id == 0)
                        dataContext.Entry<SaleDetail>(saleDetail).State = EntityState.Added;
                    else
                        dataContext.Entry<SaleDetail>(saleDetail).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Detalle de venta guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            saleDetailBindingSource.Add(new SaleDetail());
            saleDetailBindingSource.MoveLast();
            txtName.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtName.Focus();
            SaleDetail saleDetail =
                saleDetailBindingSource.Current as SaleDetail;
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
                    SaleDetail saleDetail =
                        saleDetailBindingSource.Current as SaleDetail;
                    if (saleDetail != null)
                    {
                        if (dataContext.Entry<SaleDetail>(saleDetail).State == EntityState.Detached)
                            dataContext.Set<SaleDetail>().Attach(saleDetail);
                        dataContext.Entry<SaleDetail>(saleDetail).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Detalle de venta eliminado");
                        saleDetailBindingSource.RemoveCurrent();
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            saleDetailBindingSource.ResetBindings(false);
            FrmSaleDetail_Load(sender, e);
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SaleDetail saleDetail = saleDetailBindingSource.Current as SaleDetail;

        }
    }
}
