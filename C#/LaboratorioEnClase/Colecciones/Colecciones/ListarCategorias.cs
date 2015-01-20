using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Colecciones.BR;

namespace Colecciones
{
    public partial class ListarCategorias : Form
    {
        // ******************************************* Constructor *****************************************
        public ListarCategorias()
        {
            InitializeComponent();
        }

        // ******************************************* Load ************************************************
        private void ListarCategorias_Load(object sender, EventArgs e)
        {
            AdmCategorias admCat = new AdmCategorias();

            grillaCategorias.DataSource = admCat.ConsultarCategorias();
        }

        // ******************************************* Métodos *********************************************
        // Click al botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
