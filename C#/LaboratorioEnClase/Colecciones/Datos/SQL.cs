using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class SQL
    {
        // ******************************************* Atributos *********************************************
        private string connectionString = "Data Source=ALUMNO-1907;Initial Catalog=Central;Integrated Security=True";

        // ******************************************* Métodos ***********************************************
        /// <summary>
        /// Da de alta una categoría en la base de datos.
        /// </summary>
        /// <param name="categoria">
        /// Objeto categoria inicializado.
        /// </param>
        public void AltaCategoria(Entidades.Categorias categoria)
        {
            // Variables conexion y comando
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand("Categorias_A", conexion);

            // Asigno variables al comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255).Value = categoria.Categoria;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
                comando.Dispose();
            }
        }

        /// <summary>
        /// Crea una lista con las categorías de la BBDD y la devuelve para asignar a un DagaGridView.
        /// </summary>
        /// <returns></returns>
        public List<Entidades.Categorias> MostrarCategorias()
        {
            // Variables conexion y comando
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand("Categorias_L", conexion);

            // Variable categorias a devolver
            List<Entidades.Categorias> categorias = new List<Entidades.Categorias>();

            // Asigno variables al comando
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                // Abro la conexión
                conexion.Open();

                // Ejecuto SP
                SqlDataReader dataReader = comando.ExecuteReader();

                // Mientras lea registros voy sumando cada categoría a la lista
                while (dataReader.Read())
                {
                    // Nueva categoría
                    Entidades.Categorias categoria = new Entidades.Categorias();

                    // Asigno valores
                    categoria.Id = Convert.ToInt32(dataReader["Código de Categoría"]);
                    categoria.Categoria = dataReader["Descripción"].ToString();

                    // Inserto ítem en la lista
                    categorias.Add(categoria);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
                comando.Dispose();
            }

            // Devuelvo la lista de categorías
            return categorias;
        }

        public List<Entidades.Producto> MostrarProductos()
        {
            // Variables conexion y comando
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand("Productos_L", conexion);

            // Variable categorias a devolver
            List<Entidades.Producto> productos = new List<Entidades.Producto>();

            // Asigno variables al comando
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                // Abro la conexión
                conexion.Open();

                // Ejecuto SP
                SqlDataReader dataReader = comando.ExecuteReader();

                // Mientras lea registros voy sumando cada categoría a la lista
                while (dataReader.Read())
                {
                    // Nueva categoría
                    Entidades.Producto producto = new Entidades.Producto();

                    // Asigno valores
                    producto.Codigo = Convert.ToInt32(dataReader["ProductoId"]);
                    producto.Categoria = dataReader["Categoria"].ToString();
                    producto.Descripcion = dataReader["Descripcion"].ToString();
                    producto.PrecioCompra = Convert.ToDouble(dataReader["PrecioCompra"]);
                    producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);

                    // Inserto ítem en la lista
                    productos.Add(producto);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
                comando.Dispose();
            }

            // Devuelvo la lista de categorías
            return productos;
        }
    }
}
