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
    public partial class FrmClient : MetroFramework.Forms.MetroForm
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                clientBindingSource.DataSource =
                dataContext.Client.ToList();
            }
            pnlDatos.Enabled = false;
            Client client = clientBindingSource.Current as Client;
            if (client != null && client.ImageUrl != null)
                pctFoto.Image = Image.FromFile(client.ImageUrl);
            else
                pctFoto.Image = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Client client =
                clientBindingSource.Current as Client;
                if (client != null)
                {
                    if (dataContext.Entry<Client>(client).State == EntityState.Detached)
                        dataContext.Set<Client>().Attach(client);
                    if (client.Id == 0)
                        dataContext.Entry<Client>(client).State = EntityState.Added;
                    else
                        dataContext.Entry<Client>(client).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Cliente guardado");
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
                    Client client =
                        clientBindingSource.Current as Client;
                    if (client != null)
                        client.ImageUrl = ofd.FileName;

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctFoto.Image = null;
            clientBindingSource.Add(new Client());
            clientBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtName.Focus();
            Client client =
                clientBindingSource.Current as Client;
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
                    Client client =
                        clientBindingSource.Current as Client;
                    if (client != null)
                    {
                        if (dataContext.Entry<Client>(client).State == EntityState.Detached)
                            dataContext.Set<Client>().Attach(client);
                        dataContext.Entry<Client>(client).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Cliente eliminado");
                        clientBindingSource.RemoveCurrent();
                        pctFoto.Image = null;
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            clientBindingSource.ResetBindings(false);
            FrmClient_Load(sender, e);

        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Client client = clientBindingSource.Current as Client;
            if (client != null && client.ImageUrl != null)
                pctFoto.Image = Image.FromFile(client.ImageUrl);
            else
                pctFoto.Image = null;
        }
    }
}
