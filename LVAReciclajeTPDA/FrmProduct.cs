﻿using LVAReciclajeTPDA.Data;
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
    public partial class FrmProduct : MetroFramework.Forms.MetroForm
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                productBindingSource.DataSource =
                    dataContext.Products.ToList();
            }
            pnlDatos.Enabled = false;
            Product product = productBindingSource.Current as Product;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Product product =
                    productBindingSource.Current as Product;
                if (product != null)
                {
                    if (dataContext.Entry<Product>(product).State == EntityState.Detached)
                        dataContext.Set<Product>().Attach(product);
                    if (product.Id == 0)
                        dataContext.Entry<Product>(product).State = EntityState.Added;
                    else
                        dataContext.Entry<Product>(product).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Producto guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            productBindingSource.Add(new Product());
            productBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtName.Focus();
            Product product =
                productBindingSource.Current as Product;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
             "¿Quieres eliminar el producto?",
             "Eliminar",
             MessageBoxButtons.OKCancel,
             MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Product product =
                        productBindingSource.Current as Product;
                    if (product != null)
                    {
                        if (dataContext.Entry<Product>(product).State == EntityState.Detached)
                            dataContext.Set<Product>().Attach(product);
                        dataContext.Entry<Product>(product).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Producto eliminado");
                        productBindingSource.RemoveCurrent();
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

      

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product product = productBindingSource.Current as Product;
            
        }

        private void btnSalirr_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            productBindingSource.ResetBindings(false);
            FrmProduct_Load(sender, e);
        }
    }
}
