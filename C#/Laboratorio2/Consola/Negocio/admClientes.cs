using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Entidades;

namespace Negocio
{
    public class admClientes
    {
        // Atributos
        private List<ClienteIndividuo> clientes = new List<ClienteIndividuo>();
        private List<Empresa> empresas = new List<Empresa>();

        // Métodos
        public List<ClienteIndividuo> ListarClienteIndividuo()
        {
            return clientes;
        }

        public ClienteIndividuo ListarClienteIndividuo(string cuit)
        {
            ClienteIndividuo cliente;

            cliente = clientes.Find(x => x.CUIT == cuit);
            
            return cliente;
        }

        public List<Empresa> ListarClienteEmpresa()
        {
            return empresas;
        }

        public Empresa ListarClienteEmpresa(string cuit)
        {
            Empresa empresa;

            empresa = empresas.Find(x => x.CUIT == cuit);
            
            return empresa;
        }
    }
}
