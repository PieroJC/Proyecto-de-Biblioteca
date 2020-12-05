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
using Microsoft.VisualBasic;

namespace SistemaBiblioteca
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        CConexion co = new CConexion();
        private void Producto_Load(object sender, EventArgs e)
        {
            cargaridProveedor();
        }
        public void mostrarProducto(DataGridView datos)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM producto;", co.conexion());
            try
            {
                MySqlDataAdapter selec = new MySqlDataAdapter("SELECT * FROM producto;", co.conexion());
                selec.SelectCommand = comando;
                DataTable datosTabla = new DataTable();//crear la tabla
                selec.Fill(datosTabla);//rellena la tabla
                BindingSource form = new BindingSource();
                form.DataSource = datosTabla;
                datos.DataSource = form;
                selec.Update(datosTabla);//
            }
            catch (Exception)
            {
                throw;
            }
            co.conexion().Close();//cerrar la conexión
        }
        private void btn_verProd_Click(object sender, EventArgs e)
        {
            mostrarProducto(dgv_producto);
        }

        private void dgv_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//SI EL DATAGRID ESTA CONTENIDO
            {
                DataGridViewRow fila = this.dgv_producto.Rows[e.RowIndex];
                //pasando los datos del DG a los textBox
                txt_idProd.Text = fila.Cells["idProducto"].Value.ToString();
                txt_nomProd.Text = fila.Cells["NomProducto"].Value.ToString();
                txt_precProd.Text = fila.Cells["PrecioProducto"].Value.ToString();
                num_CantidadProducto.Text = fila.Cells["CantidadProducto"].Value.ToString();
                cbx_idProveedor.Text = fila.Cells["idProveedor"].Value.ToString();

            }
            co.conexion().Close();//cerrar la conexión
        }

        private void cbx_idProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void cargaridProveedor()
        {   //creando la sentencia SQL
            MySqlCommand comando = new MySqlCommand("SELECT idProveedor FROM `proveedor` ", co.conexion());
            //leer el resultado
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cbx_idProveedor.Refresh();//actualiza el cbx
                //rellena los datos con el resultado de la consulta
                cbx_idProveedor.Items.Add(leer.GetValue(0).ToString());
            }
            //cerrar conexcion
            co.conexion().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //crear la variable de la sentencia
                MySqlCommand sql = new MySqlCommand("INSERT INTO `producto` (`idProducto`, `NomProducto`, `PrecioProducto`, `CantidadProducto`, `idProveedor`) VALUES (?,?,?,?,?);", co.conexion());
                //añadir los parametros de la consulta
                sql.Parameters.Add("@idProducto", MySqlDbType.VarChar, 6).Value = txt_idProd.Text;
                sql.Parameters.Add("@NomProducto", MySqlDbType.VarChar, 30).Value = txt_nomProd.Text;
                sql.Parameters.Add("@PrecioProducto", MySqlDbType.VarChar, 30).Value = txt_precProd.Text;
                sql.Parameters.Add("@CantidadProducto", MySqlDbType.VarChar, 40).Value = num_CantidadProducto.Text;
                sql.Parameters.Add("@idProveedor", MySqlDbType.VarChar, 30).Value = cbx_idProveedor.Text;
                sql.ExecuteNonQuery();
                //mensaje de salida
                MessageBox.Show("Lector guardado correctamente.");
            }
            catch (Exception)
            {

                throw;
            }
            //cerrar la conexión
            co.conexion().Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_idProd.Text = "";
            txt_nomProd.Text="";
            txt_precProd.Text="";
            num_CantidadProducto.Text="";
            cbx_idProveedor.Text = "";

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //la sentencia sql de buscar segun código
            MySqlCommand sql = new MySqlCommand("SELECT * FROM `producto` WHERE idProducto ='" + txt_idProd.Text + "';", co.conexion());
            //ejecutar el comando
            MySqlDataReader leer1 = sql.ExecuteReader();//leer el resultado de la sentencia sql
            //si leer tiene filas
            if (leer1.HasRows)//si leer tiene filas
            {
                while (leer1.Read()) //leer resultado de la sentencia
                {
                    leer1.Read();
                    txt_idProd.Text = leer1["idProveedor"].ToString();
                    txt_nomProd.Text = leer1["NomProducto"].ToString();
                    txt_precProd.Text = leer1["PrecioProducto"].ToString();
                    num_CantidadProducto.Text = leer1["CantidadProducto"].ToString();
                    cbx_idProveedor.Text = leer1["idProveedor"].ToString();


                }

            }

            btn_guardar.Enabled = false;
            co.conexion().Close();
        }
        //varibles a utilizar
        public string nom;
        public int can;
        public double pre;
        public double imp;
        //codigo
        public int id;
        public Factura fb = new Factura();
        //pasar datos con felegados
        // de los datos que vas a enviar al otro formulario
        public delegate void pasar(String nom, int cant, double prec, double total, double totalPago, int id );
        //crear un evento
        public event pasar pasado;
        //varible es para q acumule el pago total
        public double totalPagar = 0;

        private void btn_enviar2_Click(object sender, EventArgs e)
        {
            //los txt de ambos formuarios deben estar en PUBLIC
            nom = txt_nomProd.Text;
            //convirtiendo el texto del inputbx a entero
            can = Int32.Parse(Interaction.InputBox("Ingresar Cantidad", "VENTANA CANTIDAD"));
            pre = Int32.Parse(txt_precProd.Text);
            imp = pre * can;
            
            //---restar de la bd la cantidad---
            //capturar el id
            int id = Convert.ToInt32(txt_idProd.Text);
            MySqlCommand comando = new MySqlCommand("UPDATE producto set CantidadProducto=CantidadProducto'" + can + "' where idProducto='" + id + "'", co.conexion());
            comando.ExecuteNonQuery();//ejecutar comando
            //-------cantidad-----------
            //acumular el pagototal
            totalPagar = totalPagar + imp;
            //enviar datos con el delegado a la Boleta
            pasado(nom, can, pre, imp, totalPagar,id);
            //para el total a pagar          

        }
    }
}
