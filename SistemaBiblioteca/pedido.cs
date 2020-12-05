using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SistemaBiblioteca
{
    public partial class pedido : Form
    {
        public pedido()
        {
            InitializeComponent();
        }
        CConexion co = new CConexion();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pedido_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //crear la variable de la sentencia
                MySqlCommand sql = new MySqlCommand("INSERT INTO `pedido` (`idPedido`, `idProducto`, `dniCliente`, `CantPedido`, `Fecha`,`idEmpleado`) VALUES (?,?,?,?,?,?);", co.conexion());
                //añadir los parametros de la consulta
                sql.Parameters.Add("@idPedido", MySqlDbType.VarChar, 8).Value = txt_idPedido.Text;
                sql.Parameters.Add("@idProducto", MySqlDbType.VarChar, 8).Value = cbx_idProducto.Text;
                sql.Parameters.Add("@dniCliente", MySqlDbType.VarChar, 8).Value = txt_dniCli.Text;
                sql.Parameters.Add("@CantPedido", MySqlDbType.Int32,10).Value = num_Cantidad.Text;
                sql.Parameters.Add("@Fecha", MySqlDbType.Date).Value = date_Fecha.Value;
                sql.Parameters.Add("@idEmpleado", MySqlDbType.VarChar, 8).Value = txt_idEmpleado.Text;
                sql.ExecuteNonQuery();
                //mensaje de salida
                MessageBox.Show("Producto guardado correctamente.");
            }
            catch (Exception)
            {

                throw;
            }
            //cerrar la conexión
            co.conexion().Close();
        }

        private void cbx_idProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public void cargarUsuarios()
        {   //creando la sentencia SQL
            MySqlCommand comando = new MySqlCommand("SELECT idProducto FROM `producto` ", co.conexion());
            //leer el resultado
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cbx_idProducto.Refresh();//actualiza el cbx
                //rellena los datos con el resultado de la consulta
                cbx_idProducto.Items.Add(leer.GetValue(0).ToString());
            }
            //cerrar conexcion
            co.conexion().Close();

        }

    }
}
