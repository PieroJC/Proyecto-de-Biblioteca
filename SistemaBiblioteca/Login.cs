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
    public partial class Login : Form
    {
        public static Boolean accessed;
        public static int dniCli;
        public static String contraseña;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
        CConexion co = new CConexion();

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            ingresarSistema();
        }
        public void ingresarSistema()
        {
            //creando la sentencia SQL
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `empleado`where idEmpleado='" + cbx_idEmp.Text + "' and contraseña='" + txt_contraseña.Text + "'", co.conexion());
            //que lee la salida o respuesta de la consulta
            MySqlDataReader leer = comando.ExecuteReader();
            //la condición para ingresar
            if (leer.Read())//si hay respuesta
            {
                MessageBox.Show("Adelante");
                

                
                this.Hide();

            }
            else
            {
                MessageBox.Show("Intentelo de Nuevo.");
            }
            co.conexion().Close();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            accessed = false;
            Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void cargarUsuarios()
        {   //creando la sentencia SQL
            MySqlCommand comando = new MySqlCommand("SELECT idEmpleado FROM `empleado` ", co.conexion());
            //leer el resultado
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cbx_idEmp.Refresh();//actualiza el cbx
                //rellena los datos con el resultado de la consulta
                cbx_idEmp.Items.Add(leer.GetValue(0).ToString());
            }
            //cerrar conexcion
            co.conexion().Close();

        }

    }
}


