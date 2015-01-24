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
    public partial class Analisis : Form
    {
        // Constructor
        public Analisis()
        {
            InitializeComponent();
        }

        // Load
        private void Analisis_Load(object sender, EventArgs e)
        {
            grillaCotizaciones.DataSource = AdmCotizaciones.Analisis().Tables[0];
            txtMaximo.Text = AdmCotizaciones.Analisis().Tables[1].Rows[0][0].ToString();
            txtMinimo.Text = AdmCotizaciones.Analisis().Tables[2].Rows[0][0].ToString();
        }

        // Métodos
        // Click al botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
