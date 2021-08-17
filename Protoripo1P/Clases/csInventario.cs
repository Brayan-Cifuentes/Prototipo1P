using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protoripo1P.Clases
{
    public class csInventario
    {
        String ordenExistencia;
        String codigoBodega;
        String codigoProducto;
        String existencia;

        public csInventario()
        {

        }

        public csInventario(String ordenExistencia, String codigoBodega, String codigoProducto, String existencia)
        {
            this.OrdenExistencia = ordenExistencia;
            this.CodigoBodega = codigoBodega;
            this.CodigoProducto = codigoProducto;
            this.Existencia = existencia;
        }

        public string OrdenExistencia { get => ordenExistencia; set => ordenExistencia = value; }
        public string CodigoBodega { get => codigoBodega; set => codigoBodega = value; }
        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public string Existencia { get => existencia; set => existencia = value; }



        //Métodos
        //consultar
        public List<Object> consulta(String dato)
        {
            MySqlDataReader reader = null;
            List<Object> lista = new List<Object>();
            String sql;

            if (dato == null)
            {
                sql = "SELECT * FROM existencias";
            }
            else
            {
                sql = "SELECT * FROM existencias WHERE ordenExistencia LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarPaqueteE = new MySqlCommand(sql, conexionBD);
                reader = buscarPaqueteE.ExecuteReader();


                while (reader.Read())
                {

                    csInventario inventario = new csInventario();

                    inventario.OrdenExistencia = reader.GetString("ordenExistencia");
                    inventario.CodigoBodega = reader.GetString("codigo_bodega");

                    inventario.CodigoProducto = reader.GetString("codigo_producto");

                    inventario.Existencia = reader.GetString("saldo_existencia");

                    lista.Add(inventario);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }


        public void cargarCombobox(ComboBox combobox, String tabla, String id, String nombre)
        {
            combobox.DataSource = null;
            combobox.Items.Clear();

            String sql = "SELECT * FROM " + tabla;
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand cargarCombobox = new MySqlCommand(sql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(cargarCombobox);
                DataTable dt = new DataTable();
                data.Fill(dt);

                combobox.ValueMember = id;
                combobox.DisplayMember = nombre;
                combobox.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar datos del combobox " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }



        public void funInsertar()
        {
            String psql = "INSERT INTO existencias (ordenExistencia,codigo_bodega,codigo_producto,saldo_existencia)" +
                " VALUES ('" + ordenExistencia + "' , '" + codigoBodega + "' , '" + codigoProducto + "' , '"
                + Existencia + "')";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand insertar = new MySqlCommand(psql, conexionBD);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

       

        public void obtenerNombreB(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombre_bodega from bodegas WHERE codigo_bodega='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombre_bodega");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        public void obtenerNombreP(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombre_producto from productos WHERE codigo_producto='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombre_producto");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        public void funModificar(String idModificar)
        {
            
            String pSqlModificar = "UPDATE existencias SET codigo_bodega='" + codigoBodega + "', codigo_producto='" + codigoProducto + "', saldo_existencia='" + existencia + "' WHERE ordenExistencia='" + idModificar + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand modificarEmpleado = new MySqlCommand(pSqlModificar, conexionBD);
                modificarEmpleado.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void funEliminar(String idEliminar)
        {

            string sql = "DELETE FROM existencias WHERE ordenExistencia='" + idEliminar + "'";


            MySqlConnection conexioBD = Conexion.conexion();
            conexioBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexioBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
            finally
            {
                conexioBD.Close();
            }
        }
    }
}
