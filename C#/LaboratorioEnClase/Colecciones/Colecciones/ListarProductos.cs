using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Colecciones.BR;

namespace Colecciones
{
    public partial class ListarProductos : Form
    {
        // ******************************************* Atributos *******************************************
        int codigoProductoSeleccionado;

        // ******************************************* Constructor *****************************************
        public ListarProductos()
        {
            InitializeComponent();
        }

        // ******************************************* Load ************************************************
        private void ListarProductos_Load(object sender, EventArgs e)
        {
            AdmStock admSt = new AdmStock();
            AdmCategorias admCat = new AdmCategorias();

            GrillaProductos.DataSource = admSt.GetAllProducts(0);
            GrillaProductos.Columns.Remove("Categoria");
            GrillaProductos.Columns[2].HeaderText = "Categoria";
            GrillaProductos.Columns[3].HeaderText = "Precio de Compra";
            GrillaProductos.Columns[4].HeaderText = "Precio de Venta";
            GrillaProductos.Columns[5].HeaderText = "Fecha de Alta";

            cmbCategoria.DataSource = admCat.ConsultarCategorias();
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Categoria";
            cmbCategoria.Text = "-";
        }

        // ******************************************* Métodos *********************************************
        // Click al botón Cerrar
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click a la grilla
        private void GrillaProductos_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow currentfila = GrillaProductos.SelectedRows[0];
                Entidades.Producto prod = new Producto();
                codigoProductoSeleccionado = Convert.ToInt32(currentfila.Cells[0].Value.ToString());
                txtDescripcion.Text = currentfila.Cells[1].Value.ToString();
                cmbCategoria.Text = currentfila.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        // Click al botón Guardar Cambios
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            AdmStock admSt = new AdmStock();
            Entidades.Producto prod = new Entidades.Producto();

            prod.Codigo = codigoProductoSeleccionado;
            prod.Descripcion = txtDescripcion.Text;
            prod.Categoria = Convert.ToInt32(cmbCategoria.SelectedValue);

            admSt.modificarProducto(prod);

            MessageBox.Show("Producto " + prod.Descripcion + " actualizado con éxito.");

            GrillaProductos.DataSource = null;
            GrillaProductos.DataSource = admSt.GetAllProducts(0);
            GrillaProductos.Columns.Remove("Categoria");
            GrillaProductos.Columns[2].HeaderText = "Categoria";
            GrillaProductos.Columns[3].HeaderText = "Precio de Compra";
            GrillaProductos.Columns[4].HeaderText = "Precio de Venta";
            GrillaProductos.Columns[5].HeaderText = "Fecha de Alta";
        }
    }
}
