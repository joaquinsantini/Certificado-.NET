using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Colecciones.BR;

namespace ConsultaWeb
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Load
        private void Form1_Load(object sender, EventArgs e)
        {
            AdmCategorias admCat = new AdmCategorias();
            cmbCategoria.DataSource = admCat.ConsultarCategorias();
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Categoria";
        }

        // Metodos
        // Click al botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        // Click al botón Consultar Productos
        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            WBRef.WSSoapClient ws = new WBRef.WSSoapClient();
            grillaProductos.DataSource = ws.traerProductosPorCategoria(Convert.ToInt32(cmbCategoria.SelectedValue)).Tables[0];
        }
    }
}
