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
                    categoria.Id = Convert.ToInt32(dataReader["CategoriaId"]);
                    categoria.Categoria = dataReader["Descripcion"].ToString();

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

        /// <summary>
        /// Devuelve la lista de productos.
        /// </summary>
        /// <returns></returns>
        public List<Entidades.Producto> MostrarProductos(int cat)
        {
            // Variables conexion y comando
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand("Productos_L", conexion);

            // Variable categorias a devolver
            List<Entidades.Producto> productos = new List<Entidades.Producto>();

            // Asigno variables al comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = cat;
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
                    producto.CategoriaDescripcion = dataReader["Categoria"].ToString();
                    producto.Descripcion = dataReader["Descripcion"].ToString();
                    producto.PrecioCompra = Convert.ToDouble(dataReader["PrecioCompra"]);
                    producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                    producto.FechaAlta = Convert.ToDateTime(dataReader["FechaAlta"]);

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

        /// <summary>
        /// Da de alta un producto.
        /// </summary>
        /// <param name="prod">
        /// Objeto de clase Producto inicializado.
        /// </param>
        public void AltaProducto(Entidades.Producto prod)
        {
            // Variables conexion y comando
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand("Productos_A", conexion);

            // Asigno variables al comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@ProductoId", SqlDbType.Int).Value = prod.Codigo;
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255).Value = prod.Descripcion;
            comando.Parameters.Add("@PrecioCompra", SqlDbType.Float).Value = prod.PrecioCompra;
            comando.Parameters.Add("@PrecioVenta", SqlDbType.Float).Value = prod.PrecioVenta;
            comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = prod.Categoria;
            comando.Parameters.Add("@FechaAlta", SqlDbType.DateTime).Value = prod.FechaAlta;

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
        /// Modifica o elimina un producto existente en la base.
        /// </summary>
        /// <param name="codigo">
        /// Código del producto a modificar o eliminar
        /// </param>
        public void ModificarProducto(Entidades.Producto prod, int flagBaja)
        {
            // Variables conexion y comando
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando;

            if (flagBaja == 0)
            {
                comando = new SqlCommand("Productos_M", conexion);
            }
            else
            {
                comando = new SqlCommand("Productos_B", conexion);
            }

            // Asigno variables al comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@ProductoId", SqlDbType.Int).Value = prod.Codigo;

            if (flagBaja == 0)
            {
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255).Value = prod.Descripcion;
                comando.Parameters.Add("@PrecioCompra", SqlDbType.Float).Value = prod.PrecioCompra;
                comando.Parameters.Add("@PrecioVenta", SqlDbType.Float).Value = prod.PrecioVenta;
                comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = prod.Categoria;
            }

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
        /// Devuelve la lista de productos.
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        public DataSet MostrarProductos2(int cat)
        {
            // Variables a utilizar
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet oDs = new DataSet();
            SqlCommand cmd = new SqlCommand("Productos_L", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Parameters.Add("@Categoria", SqlDbType.Int).Value = cat;

            da.SelectCommand = cmd;

            try
            {
                da.Fill(oDs);

            }
            catch (SqlException ex)
            {
                throw new Exception("Error en base de datos" + ex.Message);

            }
            finally
            {
                cnn.Dispose();
                cmd.Dispose();
            }

            return oDs;
        }

        /// <summary>
        /// Da de alta una cotización.
        /// </summary>
        /// <param name="especie"></param>
        /// <param name="fecha"></param>
        /// <param name="cotizacion"></param>
        public void AltaCotizaciones(string especie, DateTime fecha, decimal cotizacion)
        {
            // Variables conexion y comando
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand("Cotizaciones_A", conexion);

            // Asigno variables al comando
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@Especie", SqlDbType.VarChar, 50).Value = especie;
            comando.Parameters.Add("@Fecha", SqlDbType.SmallDateTime).Value = fecha;
            comando.Parameters.Add("@Cotizacion", SqlDbType.Decimal).Value = cotizacion;

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

        public DataSet Analisis()
        {
            // Variables a utilizar
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet oDs = new DataSet();
            SqlCommand cmd = new SqlCommand("Analisis_L", cnn);

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            try
            {
                da.Fill(oDs);

            }
            catch (SqlException ex)
            {
                throw new Exception("Error en base de datos" + ex.Message);

            }
            finally
            {
                cnn.Dispose();
                cmd.Dispose();
            }

            return oDs;
        }
    }
}
