using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria1;

namespace Incidencias
{
    public partial class frmBajaEmpleado : Form
    {
        int distintivo;
        public frmBajaEmpleado(int d)
        {
            InitializeComponent();
            distintivo = d;
        }
        
        private void frmBajaEmpleado_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            entrar();            
        }
        private string checaExistencia(string cons)
        {
            string band = "";
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }
            SqlDataReader lector = null;
            string strComandoSQL = cons;
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                conn.Close();
                return band;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    band = lector.GetValue(0).ToString();
                }
            }
            conn.Close();
            return band;
        }

        private void entrar()
        {
            
            if (distintivo == 1)
            {
                string clave = checaExistencia("Select id from empleado where id=" + textBox1.Text.ToString() + "");
                if (clave == "")
                {
                    MessageBox.Show("Empleado no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBajaCambioEmpleado bce = new frmBajaCambioEmpleado(distintivo, clave);
                bce.ShowDialog();
                textBox1.Text = "";
            }
            if (distintivo == 2)
            {
                string clave = checaExistencia("Select id from empleado where id=" + textBox1.Text.ToString() + "");
                if (clave == "")
                {
                    MessageBox.Show("Empleado no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBajaCambioEmpleado bce = new frmBajaCambioEmpleado(distintivo, clave);
                bce.ShowDialog();
                textBox1.Text = "";
            }
            if (distintivo == 3)
            {
                string clave = checaExistencia("Select id from Tecnico where id=" + textBox1.Text.ToString() + "");
                if (clave == "")
                {
                    MessageBox.Show("Técnico no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBajaCambioTecnico bct = new frmBajaCambioTecnico(distintivo, clave);
                bct.ShowDialog();
                textBox1.Text = "";
            }
            if (distintivo == 4)
            {
                string clave = checaExistencia("Select id from Tecnico where id=" + textBox1.Text.ToString() + "");
                if (clave == "")
                {
                    MessageBox.Show("Técnico no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBajaCambioTecnico bct = new frmBajaCambioTecnico(distintivo, clave);
                bct.ShowDialog();
                textBox1.Text = "";
            }
            if (distintivo == 5)
            {
                string clave = checaExistencia("Select id from Equipo where id=" + textBox1.Text.ToString() + "");
                if (clave == "")
                {
                    MessageBox.Show("Equipo no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBajaCambioEquipo bce = new frmBajaCambioEquipo(distintivo, clave);
                bce.ShowDialog();
            }
            if (distintivo == 6)
            {
                string clave = checaExistencia("Select id from Equipo where id=" + textBox1.Text.ToString() + "");
                if (clave == "")
                {
                    MessageBox.Show("Equipo no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBajaCambioEquipo bce = new frmBajaCambioEquipo(distintivo, clave);
                bce.ShowDialog();
                textBox1.Text = "";
            }
            if (distintivo == 7)
            {
                string clave = checaExistencia("Select id from departamento where id=" + textBox1.Text.ToString() + "");
                if (clave == "")
                {
                    MessageBox.Show("Departamento no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBajaCambioDepartamento bcd = new frmBajaCambioDepartamento(distintivo, clave);
                bcd.ShowDialog();
                textBox1.Text = "";
            }
            if (distintivo == 8)
            {
                string clave = checaExistencia("Select id from departamento where id=" + textBox1.Text.ToString() + "");
                if (clave == "")
                {
                    MessageBox.Show("Departamento no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBajaCambioDepartamento bcd = new frmBajaCambioDepartamento(distintivo, clave);
                bcd.ShowDialog();
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                entrar();
            }
        }
    }
}
