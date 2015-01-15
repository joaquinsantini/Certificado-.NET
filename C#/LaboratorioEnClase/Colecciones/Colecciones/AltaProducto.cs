using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Colecciones.BR;
using Entidades;

namespace Colecciones
{
    public partial class AltaProducto : Form
    {
        // ******************************************* Constructor *******************************************
        public AltaProducto()
        {
            InitializeComponent();
        }

        // ******************************************* Load **************************************************
        private void AltaProducto_Load(object sender, EventArgs e)
        {
            margen.Text = Convert.ToString(Configuracion.Margen);
            margen.ReadOnly = true;
            txtDescripcion.Select();
        }

        // ******************************************* Métodos ***********************************************
        // Click al botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecioCompra.Text = "";
        }

        // Click al botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click al botón Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Valido que el margen no sea nulo
            if (Convert.ToInt32(margen.Text) == 0)
            {
                MessageBox.Show("El margen no puede ser cero. Ingrese en menú Productos -> Configuración para asignarle un valor entero mayor a cero.");
                return;
            }

            // Valido que los 3 campos hayan sido ingresados
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtPrecioCompra.Text == "")
            {
                MessageBox.Show("Debe ingresar los 3 valores como dato. Por favor ingrese el/los valor/es faltantes.");

                if (txtCodigo.Text == "")
                {
                    txtCodigo.Select();
                    return;
                }

                if (txtDescripcion.Text == "")
                {
                    txtDescripcion.Select();
                    return;
                }

                if (txtPrecioCompra.Text == "")
                {
                    txtPrecioCompra.Select();
                    return;
                }
            }
            
            // Valido que el código de producto ingresado sea único
            if (Colecciones.BR.Colecciones.Productos.Find(x => x.Codigo == Convert.ToInt32(txtCodigo.Text)) != null)
            {
                MessageBox.Show("Ya existe un producto con el código ingresado. Por favor ingrese otro código de producto para continuar.");
                txtCodigo.Select();
                txtCodigo.SelectAll();
                return;
            }

            // Instancia de producto
            Producto producto = new Producto();

            // Asignación de variables
            producto.Codigo = Convert.ToInt32(txtCodigo.Text);
            producto.Descripcion = txtDescripcion.Text;
            producto.PrecioCompra = Convert.ToInt32(txtPrecioCompra.Text);

            // Doy de alta el producto
            AdmStock.altaProducto(producto);

            // Informo el alta de producto
            MessageBox.Show("Producto " + producto.Descripcion + " dado de alta con éxito.");

            // Actualizo la grilla
            labelInformacion.Visible = false;
            Grilla1.DataSource = null;
            Grilla1.DataSource = Colecciones.BR.Colecciones.Productos;

            // Limpio campos
            txtPrecioCompra.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";

            // Selecciono campo descripción como nuevo cursor
            txtDescripcion.Select();
        }
    }
}
