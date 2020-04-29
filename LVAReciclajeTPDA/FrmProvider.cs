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
    public partial class FrmProvider : MetroFramework.Forms.MetroForm
    {
        public FrmProvider()
        {
            InitializeComponent();
        }

        private void FrmProvider_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                providerBindingSource.DataSource =
                    dataContext.Providers.ToList();
            }
            pnlDatos.Enabled = false;
            Provider provider = providerBindingSource.Current as Provider;
            if (provider != null && provider.ImageUrl != null)
                pctFoto.Image = Image.FromFile(provider.ImageUrl);
            else
                pctFoto.Image = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Provider provider =
                   providerBindingSource.Current as Provider;
                if (provider != null)
                {
                    if (dataContext.Entry<Provider>(provider).State == EntityState.Detached)
                        dataContext.Set<Provider>().Attach(provider);
                    if (provider.Id == 0)
                        dataContext.Entry<Provider>(provider).State = EntityState.Added;
                    else
                        dataContext.Entry<Provider>(provider).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Proveedor guardado");
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
                    pctFoto.Image = Image.FromFile(ofd.FileName);
                    Provider provider =
                        providerBindingSource.Current as Provider;
                    if (provider != null)
                        provider.ImageUrl = ofd.FileName;

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctFoto.Image = null;
            providerBindingSource.Add(new Provider());
            providerBindingSource.MoveLast();
            txtNombreEmpresa.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtNombreEmpresa.Focus();
            Provider provider =
                providerBindingSource.Current as Provider;
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
                    Provider provider =
                        providerBindingSource.Current as Provider;
                    if (provider != null)
                    {
                        if (dataContext.Entry<Provider>(provider).State == EntityState.Detached)
                            dataContext.Set<Provider>().Attach(provider);
                        dataContext.Entry<Provider>(provider).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Proveedor eliminado");
                        providerBindingSource.RemoveCurrent();
                        pctFoto.Image = null;
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            providerBindingSource.ResetBindings(false);
            FrmProvider_Load(sender, e);
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Provider provider = providerBindingSource.Current as Provider;
            if (provider != null && provider.ImageUrl != null)
                pctFoto.Image = Image.FromFile(provider.ImageUrl);
            else
                pctFoto.Image = null;
        }

        private void providerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }
    }
}
