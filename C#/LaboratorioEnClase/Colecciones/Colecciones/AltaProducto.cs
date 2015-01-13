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
        }
    }
}
