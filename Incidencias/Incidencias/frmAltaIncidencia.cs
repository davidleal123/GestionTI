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
using Metodos;

namespace Incidencias
{
    public partial class frmAltaIncidencia : Form
    {
        string usuario = "";
        public frmAltaIncidencia(string c)
        {
            InitializeComponent();
            usuario = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ActualizaCombo(ComboBox combo, string con)
        {
            combo.Items.Clear();
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            SqlDataReader lector = null;
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
                    combo.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }

        private void frmAltaIncidencia_Load(object sender, EventArgs e)
        {
            ActualizaCombo(cmbDepartamento, "select nombre from departamento");
            cmbEquipo.Enabled = false;
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbDepartamento.SelectedIndex >= 0)
            {
                ActualizaCombo(cmbEquipo, "select equipo from equipo e inner join departamento d on e.departamento=d.id");
                cmbEquipo.Enabled = true;
            }
            else
            {
                cmbEquipo.SelectedIndex = -1;
                cmbEquipo.Enabled = false;
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string departamento = cmbDepartamento.SelectedItem.ToString();
                string descripcion = txtDescripcion.Text;
                string tipo = "";
                if (rdbHardware.Checked == true)
                {
                    tipo = "Hardware";
                }
                else
                {
                    tipo = "Software";
                }

                if (cmbEquipo.SelectedIndex==-1 || string.IsNullOrWhiteSpace(departamento) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(tipo))
                {
                    MessageBox.Show("Información Faltante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
                SqlConnection conn = UsoBD.ConectaBD(strCon);
                if (conn == null)
                {
                    MessageBox.Show("Imposible Conectar con BD");
                    return;
                }
                string estatus = "Pendiente";
                int idDep = RegresaID("Select id from departamento where nombre='" +  departamento+ "'");
                int idEqui = RegresaID("Select id from equipo where equipo='" +cmbEquipo.SelectedItem.ToString() + "'");
                string prioridad = RegresaPrioridad(departamento);


                string strComandoSQL = "insert into incidencia(equipo,departamento,descripcion,tipo,empleado,prioridad,estatus)";
                strComandoSQL += " values(@equipo,@dep,@des,@tipo,@emp,@pri,@est)";
                SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
                cmd.Parameters.AddWithValue("@equipo", idEqui);
                cmd.Parameters.AddWithValue("@dep", idDep);
                cmd.Parameters.AddWithValue("@des", descripcion);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@emp", usuario);
                cmd.Parameters.AddWithValue("@pri", prioridad);
                cmd.Parameters.AddWithValue("@est", estatus);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Incidencia dada de Alta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
               
            }
            Limpia();
                
        }
        private string RegresaPrioridad(string Departamento)
        {
            string band = "";
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "Select prioridad from departamento where nombre='" + Departamento + "'";
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta clavedepa");
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
        private int RegresaID(string consulta)
        {
            int band = -1;
            string equi = cmbEquipo.SelectedItem.ToString();
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }
            SqlDataReader lector = null;
            string strComandoSQL = consulta;
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta clavedepa");
                conn.Close();
                return band;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    band = Convert.ToInt32(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
            return band;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }

        private void Limpia()
        {
            txtDescripcion.Clear();
            cmbDepartamento.SelectedIndex = -1;
            rdbHardware.Checked = false;
            rdbSoftware.Checked = false;
            cmbDepartamento.Focus();
            cmbEquipo.Items.Clear();
            cmbEquipo.SelectedIndex = -1;
            
        }
    }
}
