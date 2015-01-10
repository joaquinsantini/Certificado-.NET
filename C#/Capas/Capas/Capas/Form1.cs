using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using System.Collections;

namespace Capas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedores oProv = new Proveedores();

            ArrayList oArl = oProv.TraerTodos();
            
            GrillaPr.DataSource = oArl;


        }
    }
}
