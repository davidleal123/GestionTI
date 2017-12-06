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
    public partial class frmBajaCambioDepartamento : Form
    {
        int distintivo;
        string clave;
        public frmBajaCambioDepartamento(int d,string c)
        {
            InitializeComponent();
            distintivo = d;
            clave = c;
        }
        string[] prioridad = { "ALTA", "MEDIA", "BAJA" };
        private void llenaCombo()
        {
            for (int i = 0; i < prioridad.Length; i++)
            {
                comboBox1.Items.Add(prioridad[i]);
            }
        }
        private void frmBajaCambioDepartamento_Load(object sender, EventArgs e)
        {
            decide();
        }
        private void decide()
        {
            if (distintivo == 7)
            {
                btnActualizar.Visible = false;
                btnEliminar.Visible = true;
                textBox1.Enabled = false;
                comboBox1.Enabled = false;
                btnLimpiar.Visible = false;
            }
            else
            {
                llenaCombo();
                btnActualizar.Visible = true;
                btnEliminar.Visible = false;
                textBox1.Enabled = true;
                comboBox1.Enabled = true;
                btnLimpiar.Visible = true;
            }
            llenaDatos();
        }
        private void llenaDatos()
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            SqlDataReader lector = null;
            string con = "select nombre,prioridad from departamento where id=" + clave + "";
            lector = UsoBD.Consulta(con, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta combo");
                conn.Close();
                return;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    textBox1.Text = lector.GetValue(0).ToString();
                    comboBox1.Text = lector.GetValue(1).ToString();
                }
            }
            conn.Close();
        }
        private void limpiar()
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string prio = comboBox1.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(nom) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese información faltante","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            string strComandoSQL = "update departamento set nombre=@nom,prioridad=@prio where id=@id";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prio", prio);
            cmd.Parameters.AddWithValue("@id", clave);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Departamento actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            decide();
        }
        private bool checaIncidencias()
        {
            bool band = false;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }

            SqlDataReader lector = null;
            string con = "select * from incidencia where departamento="+clave+"";
            lector = UsoBD.Consulta(con, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta combo");
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
        private bool checaEmpleados()
        {
            bool band = false;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }

            SqlDataReader lector = null;
            string con = "select * from empleado where departamento=" + clave+"";
            lector = UsoBD.Consulta(con, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta combo");
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            if (checaEmpleados())
            {
                MessageBox.Show("El departamento tiene Empleados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checaIncidencias())
            {
                MessageBox.Show("El departamento tiene Registro de incidencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string strComandoSQL = "delete from departamento where id=@id";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@id", clave);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Departamento eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Metodos.ValidaTexto(e,textBox1,errorProvider1);
        }
    }
}
