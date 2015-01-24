using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Colecciones.BR;

namespace Colecciones
{
    public partial class ImportarArchivo : Form
    {
        // ******************************************* Constructor *******************************************
        public ImportarArchivo()
        {
            InitializeComponent();
        }

        // ******************************************* Load **************************************************
        private void ImportarArchivo_Load(object sender, EventArgs e)
        {
            // Asigno texto default en el TextBox
            txtArchivo.Text = "Seleccione archivo...";

            btnSeleccionarArchivo.Select();
        }

        // ******************************************* Métodos ***********************************************
        // Click al botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        // Click al botón Seleccionar Archivo
        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            // Variables a utilizar
            OpenFileDialog frmDialog = new OpenFileDialog();

            // Asigno variables
            frmDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            frmDialog.InitialDirectory = "C:";
            frmDialog.Title = "Seleccione un archivo de texto";

            // Variable para almacenar el resultado de abrir el frmDialog
            DialogResult result = frmDialog.ShowDialog();

            // Pregunto resultado de ejecución para asignar la variable archivo
            if (result == DialogResult.OK)
            {
                txtArchivo.Text = frmDialog.FileName;
	        }
        }

        // Click al botón Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(txtArchivo.Text))
            {
                // Variables para leer las lineas del archivo
                string linea;
                
                // Variables a utilizar en el parseo del archivo
                string _especie = "";
                string _fecha = "";
                string _cotizacion = "";
                string _dia = "";
                string _mes = "";
                string _anio = "";

                // Loop para el parseo cada linea del archivo
                while ((linea = reader.ReadLine()) != null)
                {
                    // Valores separados de la linea
                    string[] valores = linea.Split('|');
                    
                    // Asigno valores
                    _especie = valores[0].Replace('"', Convert.ToChar(" "));
                    _fecha = valores[1].Replace('"', Convert.ToChar(" "));
                    _cotizacion = valores[2].Replace('"', Convert.ToChar(" "));
                    _dia = _fecha.Substring(0, 2);
                    _mes = _fecha.Substring(3, 2);
                    _anio = _fecha.Substring(6, 4);
                    DateTime fecha = new DateTime(Convert.ToInt32(_anio), Convert.ToInt32(_mes), Convert.ToInt32(_dia));

                    // Doy de alta la cotización
                    AdmCotizaciones.AltaCotizaciones(_especie, fecha, Convert.ToDecimal(_cotizacion));
                }


                // Informo la importación exitosa
                MessageBox.Show("La importación se realizó con éxito.");
            }
        }
    }
}
