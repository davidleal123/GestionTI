using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria1;
using Metodos;

namespace Incidencias
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entrar();
        }

        public void entrar()
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Información Faltante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!BuscaUsuario(usuario, contraseña))
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             string cargo = BuscaCargo(usuario,contraseña);
             frmMenu menu = new frmMenu(cargo,usuario);
             menu.ShowDialog();
             this.Hide();
        }
       
        public string BuscaCargo(string usuario, string clave)
        {
            string band = "";
            string strCon = "Data Source=DAVIDLEALFLEF4C;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }
            string comando = "Select cargo from empleado where id= " + usuario + "and contraseña=" + clave;
            SqlDataReader lector = null;
            lector = UsoBD.Consulta(comando, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta");
                conn.Close();
                return band;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    band = (string)lector.GetValue(0).ToString();
                }
            }
            conn.Close();
            return band;
        }

        public bool BuscaUsuario(string usuario, string clave)
        {
            bool band = false;
            string strCon = "Data Source=DAVIDLEALFLEF4C;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }
            string comando = "Select * from empleado where id= " + usuario +"and contraseña="+clave;
            SqlDataReader lector = null;
            lector = UsoBD.Consulta(comando, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta");
                conn.Close();
                return band;
            }
            if (lector.HasRows)
            {
                band = true;
            }
            conn.Close();
            return band;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                entrar();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                txtContraseña.Focus();
            }
        }
    }
}
