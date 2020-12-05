using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//llamar la libreria o referencia de mysql
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    class CConexion
    {
        MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;database=base;password=12345678");

        //crear un metodo de conexion
        public MySqlConnection conexion()
        {
            try
            {
                con.Open();//abre la conexión con la bd
            }
            catch
            {

            }
            return con;
        }

    }
}
