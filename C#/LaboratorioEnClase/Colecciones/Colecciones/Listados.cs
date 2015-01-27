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
    public partial class Listados : Form
    {
        // ******************************************* Constructor *******************************************
        public Listados()
        {
            InitializeComponent();
        }

        // ******************************************* Load **************************************************
        private void Listados_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }

        // ******************************************* Métodos ***********************************************
        // Click al botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        // Click al botón Cargar Reporte
        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            // Lista donde se cargan los productos
            List<Producto> productos = new List<Producto>();

            // Cargo la lista
            AdmStock admSt = new AdmStock();
            productos = admSt.GetAllProducts(0);

            // Limpio el reporte
            reportViewer1.LocalReport.DataSources.Clear();
            
            // Asigno el recurso al reporte
            reportViewer1.LocalReport.ReportEmbeddedResource = "Colecciones.Reporte1.rdlc";

            // Creo dataset de reporte
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", productos);
            
            // Asigno dataset al reporte
            reportViewer1.LocalReport.DataSources.Add(dataset);
            
            // Asigno el recurso al dataset
            dataset.Value = productos;

            // Actualizo el reporte
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
