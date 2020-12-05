using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar la libreria mysql
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //crear el objeto de conexión
        CConexion co = new CConexion();

        //crear los métodos del formulario
        //1er - método de guardar
        public void guardarLector()
        {
            try
            {
                //crear la variable de la sentencia
                MySqlCommand sql = new MySqlCommand("INSERT INTO `cliente` (`dniCliente`, `NomCliente`, `ApeCliente`, `DirCliente`, `TlfCliente`) VALUES (?,?,?,?,?);", co.conexion());
                //añadir los parametros de la consulta
                sql.Parameters.Add("@dniCliente", MySqlDbType.VarChar, 6).Value = txt_dniCli.Text;
                sql.Parameters.Add("@NomCliente", MySqlDbType.VarChar, 30).Value = txt_apeCli.Text;
                sql.Parameters.Add("@ApeCliente", MySqlDbType.VarChar, 30).Value = txt_nomCli.Text;
                sql.Parameters.Add("@DirCliente", MySqlDbType.VarChar, 40).Value = txt_dirCli.Text;
                sql.Parameters.Add("@TlfCliente", MySqlDbType.VarChar, 30).Value = txt_telCli.Text;
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
        //crear el metodo de buscar lector
        //select 
        public void buscarLector()
        {
            //la sentencia sql de buscar segun código
            MySqlCommand sql = new MySqlCommand("SELECT * FROM `cliente` WHERE dniCliente= '" + txt_dniCli.Text + "';", co.conexion());
            //ejecutar el comando
            MySqlDataReader leer1 = sql.ExecuteReader();//leer el resultado de la sentencia sql
            //si leer tiene filas
            if (leer1.HasRows)//si leer tiene filas
            {
                while (leer1.Read()) //leer resultado de la sentencia
                {
                    leer1.Read();
                    txt_dniCli.Text = leer1["dniCliente"].ToString();
                    txt_nomCli.Text = leer1["NomCliente"].ToString();
                    txt_apeCli.Text = leer1["ApeCliente"].ToString();
                    txt_dirCli.Text = leer1["DirCliente"].ToString();
                    txt_telCli.Text = leer1["TlfCliente"].ToString();


                }

            }

            btn_guardar.Enabled = false;
            co.conexion().Close();
        }

        //metodo de buscar lectores por nombre
        public void buscarLecxNombre(DataGridView datos)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `cliente` WHERE NomCliente ='" + txt_buscarNombre.Text + "'", co.conexion());
            try
            {
                MySqlDataAdapter selec = new MySqlDataAdapter("SELECT * FROM `cliente` WHERE NomCliente ='" + txt_buscarNombre.Text + "'", co.conexion());
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

        public void buscarLecxNombreTipiados(DataGridView datos)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `cliente` WHERE NomCliente LIKE '%" + txt_buscarNombre.Text + "%';", co.conexion());
            try
            {
                MySqlDataAdapter selec = new MySqlDataAdapter("SELECT * FROM `cliente` WHERE NomCliente LIKE '%" + txt_buscarNombre.Text + "%';", co.conexion());
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

        private void button1_Click(object sender, EventArgs e)
        {
            guardarLector();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscarLector();
        }
        //2do - método de nuevo
        //3er - método de salir

        //METODO PARA MOSTRAR LOS DATOS EN UN DATAGRIDVIEW
        public void mostrarLectores(DataGridView datos)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM cliente;", co.conexion());
            try
            {
                MySqlDataAdapter selec = new MySqlDataAdapter("SELECT * FROM cliente;", co.conexion());
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

        private void btn_CargarLector_Click(object sender, EventArgs e)
        {
            mostrarLectores(dgv_lectores);
        }

        private void dgv_lectores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//SI EL DATAGRID ESTA CONTENIDO
            {
                DataGridViewRow fila = this.dgv_lectores.Rows[e.RowIndex];
                //pasando los datos del DG a los textBox
                txt_dniCli.Text = fila.Cells["dniCliente"].Value.ToString();
                txt_nomCli.Text = fila.Cells["NomCliente"].Value.ToString();
                txt_apeCli.Text = fila.Cells["ApeCliente"].Value.ToString();
                txt_dirCli.Text = fila.Cells["DirCliente"].Value.ToString();
                txt_telCli.Text = fila.Cells["TlfCliente"].Value.ToString();

            }
            co.conexion().Close();//cerrar la conexión


        }



        private void btn_buscarNombre_Click(object sender, EventArgs e)
        {
            buscarLecxNombre(dgv_lectores);
        }

        private void txt_buscarNombre_TextChanged(object sender, EventArgs e)
        {
            buscarLecxNombreTipiados(dgv_lectores);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            MySqlCommand sql = new MySqlCommand("UPDATE cliente SET dniCliente='" + txt_dniCli.Text + "',NomCliente='" + txt_nomCli.Text + "',ApeCliente='" + txt_apeCli.Text + "',DirCliente='" + txt_dirCli.Text + "',TlfCliente='" + txt_telCli.Text + "' WHERE dniCliente='" + txt_dniCli.Text + "'", co.conexion());



            sql.ExecuteNonQuery();

            co.conexion().Close();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            MySqlCommand sql = new MySqlCommand("DELETE FROM cliente WHERE dniCliente ='" + txt_dniCli.Text + "'", co.conexion());
            //ejecutar el comando
            MySqlDataReader eliminar = sql.ExecuteReader();//eliminar el resultado de la sentencia SQL(la de arriba)
            //cerrar la conexion
            co.conexion().Close();
            MessageBox.Show("Eliminado Correctamente");
            

      

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            guardarLector();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_dniCli.Text = "";
            txt_nomCli.Text = "";
            txt_apeCli.Text = "";
            txt_dirCli.Text = "";
            txt_telCli.Text = "";
           
        }
        //PRA ENVIAR DATOS DEL FORM DELEGADO
        //varibles a utilizar
        public string dni;
        public string nom;
        public string ape;
        public string dir;
        public string tel;
        //para el codigo
        public string cod;
        public Factura fb = new Factura();
        //pasar datos con delegados
        // de los datos que vas a enviar al otro formulario
        public delegate void pasarC(String dniCli, String nomCli, String apeCli, String dirCli,string telCli);
        //crear un evento
        public event pasarC pasarcliente;

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            //los txt de ambos formuarios deben estar en PUBLIC
            nom = txt_nomCli.Text;
            ape = txt_apeCli.Text;
            dni = txt_dniCli.Text;
            dir = txt_dirCli.Text;
           
            cod = txt_dniCli.Text;
            tel = txt_telCli.Text;
            //enviar datos con el delegado a la Boleta
            pasarcliente(nom, ape, dni, dir,tel);
            //cerrar la ventana
            MessageBox.Show("Cliente: " + nom + " enviado");
            this.Close();
        }
    }
}
