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

            GrillaProductos.DataSource = admSt.GetAllProducts();
        }

        // ******************************************* Métodos *********************************************
        // Click al botón Cerrar
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
