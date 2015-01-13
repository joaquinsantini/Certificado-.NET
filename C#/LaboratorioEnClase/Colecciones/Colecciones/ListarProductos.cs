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
        public ListarProductos()
        {
            InitializeComponent();

            AdmStock adminStock = new AdmStock();

            GrillaProductos.DataSource = adminStock.GetAllProducts();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
