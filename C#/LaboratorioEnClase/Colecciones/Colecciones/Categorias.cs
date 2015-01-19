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
    public partial class Categorias : Form
    {
        // ******************************************* Constructor *******************************************
        public Categorias()
        {
            InitializeComponent();
        }

        // ******************************************* Métodos ***********************************************
        // Click al botón Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Instancia de categoria
            Entidades.Categorias categoria = new Entidades.Categorias();

            // Asigno valores
            categoria.Categoria = txtCategoria.Text;
            categoria.Id = 0;

            // Doy de alta la categoría
            AdmCategorias admCat = new AdmCategorias();
            admCat.AltaCategoria(categoria);

            // Informo el alta de categoría
            MessageBox.Show("Categoría " + categoria.Categoria + " dada de alta con éxito.");

            // Limpio valor
            txtCategoria.Text = "";
            txtCategoria.Select();
        }

        // Click al botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
