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
        // ******************************************* Constructor *****************************************
        public ListarProductos()
        {
            InitializeComponent();
        }

        // ******************************************* Load ************************************************
        private void ListarProductos_Load(object sender, EventArgs e)
        {
            AdmStock admSt = new AdmStock();

            GrillaProductos.DataSource = admSt.GetAllProducts(0);
            GrillaProductos.Columns.Remove("Categoria");
            GrillaProductos.Columns[2].HeaderText = "Categoria";
            GrillaProductos.Columns[3].HeaderText = "Precio de Compra";
            GrillaProductos.Columns[4].HeaderText = "Precio de Venta";
            GrillaProductos.Columns[5].HeaderText = "Fecha de Alta";
        }

        // ******************************************* Métodos *********************************************
        // Click al botón Cerrar
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
