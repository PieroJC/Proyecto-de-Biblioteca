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
    public partial class Factura : Form
    {
        CConexion co = new CConexion();
        public Factura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.pasarcliente += new Form1.pasarC(ejecuta);//para recibir los datos
            f1.ShowDialog();
        }
        public void ejecuta(String dniCli, String nomCli, String apeCli, String dirCli, String telCli)
        {
            //AÑADIR LOS PRODUCTOS AL DATAGRIDVIEW
            txt_nomCli.Text = nomCli + " " + apeCli;
            txt_dniCli.Text = dniCli;
            txt_dirCli.Text = dirCli;
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto Producto = new Producto();//form prod
            Producto.pasado += new Producto.pasar(ejecutar);//para recibir los datos
            Producto.ShowDialog();
        }
        //crear el metodo EJECUTAR
        public int ID;//enviando el codigo
        public int cantidad;
        public double precio;
        //------//
        public void ejecutar(String nom, int cant, double prec, double total, double totalPago, int id)
        {
            //AÑADIR LOS PRODUCTOS AL DATAGRIDVIEW
            dgv_venta.Rows.Add(nom, cant, prec, total, id);
            //coloque el total en el txt del total a pagar
            txt_totPagar.Text = totalPago.ToString();
            //recibir la variable codigo
            ID = id;
            cantidad = cant;
            precio = prec;
        }
    }
}
