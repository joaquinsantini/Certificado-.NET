using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colecciones
{
    public partial class MenuPrincipal : Form
    {
        // ******************************************* Constructor *******************************************
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // ******************************************* Métodos ***********************************************
        // Click en ítem de menú Listar Productos
        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarProductos formListarProductos = new ListarProductos();

            formListarProductos.ShowDialog();
        }

        // Click en ítem de menú Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Click en ítem de menú Configuración
        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracion formConfiguracion = new FrmConfiguracion();

            formConfiguracion.ShowDialog();
        }

        // Click en ítem de menú Alta Producto
        private void altaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProducto formAltaProducto = new AltaProducto();

            formAltaProducto.ShowDialog();
        }

        // Click en ítem de menú Alta Categoría
        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias formCategorias = new Categorias();

            formCategorias.ShowDialog();
        }

        // Click en ítem de menú Listar Categorías
        private void listarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCategorias formListarCategorias = new ListarCategorias();

            formListarCategorias.ShowDialog();
        }

        // Click en ítem de menú Listar Productos por Categoría
        private void listarProductosPorCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarProductosPorCategoria formListarProductosPorCategoria = new ListarProductosPorCategoria();

            formListarProductosPorCategoria.ShowDialog();
        }

        // Click en ítem de menú Importar Archivo
        private void importarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarArchivo formImportarArchivo = new ImportarArchivo();

            formImportarArchivo.ShowDialog();
        }

        // Click en ítem de menú Analisis
        private void analisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analisis formAnalisis = new Analisis();

            formAnalisis.ShowDialog();
        }

        // Click en ítem de menú Listados
        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listados formListados = new Listados();

            formListados.ShowDialog();
        }
    }
}
