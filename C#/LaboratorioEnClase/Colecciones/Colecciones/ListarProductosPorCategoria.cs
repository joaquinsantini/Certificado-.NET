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
    public partial class ListarProductosPorCategoria : Form
    {
        // ******************************************* Constructor *******************************************
        public ListarProductosPorCategoria()
        {
            InitializeComponent();
        }

        // ******************************************* Load **************************************************
        private void ListarProductosPorCategoria_Load(object sender, EventArgs e)
        {
            AdmCategorias admCat = new AdmCategorias();
            Entidades.Categorias categoria = new Entidades.Categorias();

            cmbCategoria.DataSource = admCat.ConsultarCategorias();
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Categoria";
        }

        // ******************************************* Métodos ***********************************************
        // Click al botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        // Cambio de valor en ComboBox de categorías
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue.GetType().ToString() == "System.Int32")
            {
                AdmStock admSt = new AdmStock();
                DataSet ds;

                int cat = Convert.ToInt32(cmbCategoria.SelectedValue);

                grillaProductos.DataSource = null;
                ds = admSt.GetAllProducts2(cat);
                grillaProductos.DataSource = ds.Tables[0];
            }
        }
    }
}
