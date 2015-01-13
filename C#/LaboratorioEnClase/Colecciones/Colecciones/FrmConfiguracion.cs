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
    public partial class FrmConfiguracion : Form
    {
        // ******************************************* Constructor *******************************************
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        // ******************************************* Load **************************************************
        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            margen.Text = Convert.ToString(Configuracion.Margen);

            margen.Select();
        }

        // ******************************************* Métodos ***********************************************
        // Click en botón Guardar Cambios
        private void button1_Click(object sender, EventArgs e)
        {
            int esNumerico;

            Int32.TryParse(Convert.ToString(margen.Text), out esNumerico);

            if (esNumerico == 0)
            {
                MessageBox.Show("El valor del margen debe ser numérico.");

                margen.Select();

                return;
            }

            Configuracion.Margen = Convert.ToInt32(margen.Text);

            this.Close();
        }
    }
}
