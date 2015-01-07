using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancias de objetos
            Producto Producto1 = new Producto("Manzana", "1 Kg de Manzanas", 5.00, 0.4, 0.21, "El bolita", "Alimentos", "Frutas y Verduras");
            ClienteEmpresa ClienteEmpresa1 = new ClienteEmpresa("Mc Donals", "20-12345678-8", "Ronald", "ronaldmacdonalds@hotmail.com", "4999-2500", "Corrientes 498");
            ClienteIndividuo ClienteIndividuo1 = new ClienteIndividuo("Roman", "Riquelme", "20-87654321-8", "romancapo@hotmail.com", "4000-0123", "La bombonera");
            Factura Factura1 = new Factura("A", "00000001", Convert.ToDateTime("01/01/2015"), "Roman Riquelme", "La bombonera", "Inscripto", "Consumidor Final", "2 Kg de manzanas", Producto1.PrecioVenta * 2);
            Proveedor Proveedor1 = new Proveedor("El bolita", "20-11111111-8", "Luis", "elbol_2015@hotmail.com", "4552-2001", "El mercado central, al lado");
            Remito Remito1 = new Remito("00000001", Convert.ToDateTime("01/01/2015"), Proveedor1.Nombre, Proveedor1.Direccion, "Inscripto", "Consumidor Final", "2 Kg de manzanas", Convert.ToDateTime("02/01/2015"), Factura1.Total);
            Vendedor Vendedor1 = new Vendedor("Beto", "Alfonso", "32111000", "elbetodealmagro@hotmail.com", "4987-6543", "Corrientes 49");

            // Variable para almacenar comando ingresado por usuario
            string comando = "";

            // Begin consola
            MostrarTextoBienvenida();
            while (comando != "Salir" || comando != "salir")
            {
                MostrarCursorConsola();
                comando = Console.ReadLine();
                switch (comando)
                {
                    case "Producto":
                    case "producto":
                        MostrarProducto(Producto1);
                        break;
                    case "Empresa":
                    case "empresa":
                        MostrarClienteEmpresa(ClienteEmpresa1);
                        break;
                    case "Individuo":
                    case "individuo":
                        MostrarClienteIndividuo(ClienteIndividuo1);
                        break;
                    case "Factura":
                    case "factura":
                        MostrarFactura(Factura1);
                        break;
                    case "Proveedor":
                    case "proveedor":
                        MostrarProveedor(Proveedor1);
                        break;
                    case "Remito":
                    case "remito":
                        MostrarRemito(Remito1);
                        break;
                    case "Vendedor":
                    case "vendedor":
                        MostrarVendedor(Vendedor1);
                        break;
                    case "Salir":
                    case "salir":
                        return;
                    default:
                        Console.WriteLine("El comando ingresado no se reconoce como válido.");
                        MostrarComandosValidos();
                        break;
                }
            }
        }

        // Método para mostrar texto de bienvenida a la consola
        private static void MostrarTextoBienvenida()
        {
            Console.WriteLine("---------------- Consola para visualizar objetos instanciados ----------------");
            MostrarComandosValidos();
        }

        // Método para mostrar comandos válidos
        private static void MostrarComandosValidos()
        {
            Console.WriteLine("Comandos válidos (no son case sensitive):");
            Console.WriteLine("\tProducto -> Muestra datos de producto.");
            Console.WriteLine("\tEmpresa -> Muestra datos del cliente empresa.");
            Console.WriteLine("\tIndividuo -> Muestra datos del cliente individuo.");
            Console.WriteLine("\tFactura -> Muestra datos de la factura.");
            Console.WriteLine("\tProveedor -> Muestra datos del proveedor.");
            Console.WriteLine("\tRemito -> Muestra datos del remito.");
            Console.WriteLine("\tVendedor -> Muestra datos del vendedor.");
            Console.WriteLine("\tSalir -> Para salir del sistema.");
        }

        // Método para mostrar cursor
        private static void MostrarCursorConsola()
        {
            Console.Write("-> ");
        }

        // Método para mostrar datos de producto
        private static void MostrarProducto(Producto prod)
        {
            Console.WriteLine("Producto");
            Console.WriteLine();
            Console.WriteLine("Nombre: " + prod.Nombre);
            Console.WriteLine("Descripción: " + prod.Descripcion);
            Console.WriteLine("Precio de costo: $" + Convert.ToString(prod.PrecioCosto));
            Console.WriteLine("Margen: %" + Convert.ToString(prod.Margen * 100));
            Console.WriteLine("I.V.A.: %" + Convert.ToString(prod.IVA * 100));
            Console.WriteLine("Precio bruto: $" + Convert.ToString(prod.PrecioBruto));
            Console.WriteLine("Precio venta: $" + Convert.ToString(prod.PrecioVenta));
            Console.WriteLine("Categoría: " + prod.Categoria);
            Console.WriteLine("Sub-Categoría: " + prod.SubCategoria);
            Console.WriteLine();
            Console.WriteLine();
        }

        // Método para mostrar datos de factura
        private static void MostrarFactura(Factura fact)
        {
            Console.WriteLine("Factura");
            Console.WriteLine();
            Console.WriteLine("Tipo: " + fact.Tipo);
            Console.WriteLine("Número: " + fact.Numero);
            Console.WriteLine("Fecha: " + Convert.ToString(fact.Fecha));
            Console.WriteLine("Cliente: " + fact.Cliente);
            Console.WriteLine("Dirección: " + fact.Direccion);
            Console.WriteLine("Condición I.V.A.: " + fact.CondicionIVA);
            Console.WriteLine("Condición venta: " + fact.CondicionVenta);
            Console.WriteLine("Detalle: " + fact.Detalle);
            Console.WriteLine("Total: $" + Convert.ToString(fact.Total));
            Console.WriteLine();
            Console.WriteLine();
        }

        // Método para mostrar datos de cliente empresa
        private static void MostrarClienteEmpresa(ClienteEmpresa cliemp)
        {
            Console.WriteLine("Cliente Empresa");
            Console.WriteLine();
            Console.WriteLine("Nombre: " + cliemp.Nombre);
            Console.WriteLine("C.U.I.T.: " + cliemp.CUIT);
            Console.WriteLine("Contacto: " + cliemp.Contacto);
            Console.WriteLine("Email: " + cliemp.Email);
            Console.WriteLine("Teléfono: " + cliemp.Telefono);
            Console.WriteLine("Dirección: " + cliemp.Direccion);
            Console.WriteLine();
            Console.WriteLine();
        }

        // Método para mostrar datos de cliente individuo
        private static void MostrarClienteIndividuo(ClienteIndividuo cliind)
        {
            Console.WriteLine("Cliente Individuo");
            Console.WriteLine();
            Console.WriteLine("Nombre: " + cliind.Nombre);
            Console.WriteLine("Apellido: " + cliind.Apellido);
            Console.WriteLine("C.U.I.T.: " + cliind.CUIT);
            Console.WriteLine("Email: " + cliind.Email);
            Console.WriteLine("Teléfono: " + cliind.Telefono);
            Console.WriteLine("Dirección: " + cliind.Direccion);
            Console.WriteLine();
            Console.WriteLine();
        }

        // Método para mostrar datos de proveedor
        private static void MostrarProveedor(Proveedor prov)
        {
            Console.WriteLine("Proveedor");
            Console.WriteLine();
            Console.WriteLine("Nombre: " + prov.Nombre);
            Console.WriteLine("C.U.I.T.: " + prov.CUIT);
            Console.WriteLine("Contacto: " + prov.Contacto);
            Console.WriteLine("Email: " + prov.Email);
            Console.WriteLine("Teléfono: " + prov.Telefono);
            Console.WriteLine("Dirección: " + prov.Direccion);
            Console.WriteLine();
            Console.WriteLine();
        }

        // Método para mostrar datos de remito
        private static void MostrarRemito(Remito rem)
        {
            Console.WriteLine("Remito");
            Console.WriteLine();
            Console.WriteLine("Número: " + rem.Numero);
            Console.WriteLine("Fecha: " + Convert.ToString(rem.Fecha));
            Console.WriteLine("Cliente: " + rem.Cliente);
            Console.WriteLine("Dirección: " + rem.Direccion);
            Console.WriteLine("Condición I.V.A.: " + rem.CondicionIVA);
            Console.WriteLine("Condición venta: " + rem.CondicionVenta);
            Console.WriteLine("Detalle: " + rem.Detalle);
            Console.WriteLine("Fecha entrega: " + Convert.ToString(rem.FechaEntrega));
            Console.WriteLine("Total: $" + Convert.ToString(rem.Total));
            Console.WriteLine();
            Console.WriteLine();
        }

        // Método para mostrar datos de vendedor
        private static void MostrarVendedor(Vendedor vend)
        {
            Console.WriteLine("Vendedor");
            Console.WriteLine();
            Console.WriteLine("Nombre: " + vend.Nombre);
            Console.WriteLine("Apellido: " + vend.Apellido);
            Console.WriteLine("D.N.I.: " + vend.DNI);
            Console.WriteLine("Email: " + vend.Email);
            Console.WriteLine("Teléfono: " + vend.Telefono);
            Console.WriteLine("Dirección: " + vend.Direccion);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
