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
    public partial class frmBajaCambioTecnico : Form
    {
        int distintivo;
        string clave;

        string[] especializaciones = { "REDES", "PROGRAMACION JAVA", "PROGRAMACION C++", "REPARACION HARDWARE", "REPARACION SOFTWARE", "DESARROLLO WEB", "CCNA 1", "CCNA2", "CCNA3", "CCNA4", "OTRO" };
        public frmBajaCambioTecnico(int d, string c)
        {
            InitializeComponent();
            distintivo = d;
            clave = c;
        }
        private void decide()
        {
            if (distintivo == 3)
            {
                btnEliminar.Visible = true;
                btnActualizar.Visible = false;
                btnLimpiar.Visible = false;
                llenaDatos();
            }
            else
            {
                btnEliminar.Visible = false;
                btnActualizar.Visible = true;
                btnLimpiar.Visible = true;
                llenaComboEspecializacion();
                llenaDatos();
            }
        }
        private void frmBajaCambioTecnico_Load(object sender, EventArgs e)
        {
            decide();
        }
        private int checaIncidencia()
        {
            int band = 0;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }

            SqlDataReader lector = null;
            string con = "select incidenciasAsignadas from tecnico where id="+clave+"";
            lector = UsoBD.Consulta(con, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta combo");
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
            string con = "select t.id,concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno),t.especializacion,t.certificaciones from tecnico t inner join empleado e on e.id=t.idEmpleado";
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
                    cmbId.Text = lector.GetValue(0).ToString();
                    cmbNombre.Text = lector.GetValue(1).ToString();
                    cmbEspecializacion.Text = lector.GetValue(2).ToString();
                    txtCertificacion.Text = lector.GetValue(3).ToString();
                }
            }
            conn.Close();
        }
        private void llenaComboEspecializacion()
        {
            cmbEspecializacion.Enabled = true;
            txtCertificacion.Enabled = true;
            for (int i = 0; i < especializaciones.Length; i++)
            {
                cmbEspecializacion.Items.Add(especializaciones[i]);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (checaIncidencia()!=0)
            {
                MessageBox.Show("El Técnico tiene incidencias Asignadas","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            string strComandoSQL = "delete from tecnico where id=@id";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@id", clave);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Técnico eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            if (cmbEspecializacion.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbEspecializacion.SelectedItem.ToString()))
            {
                MessageBox.Show("Ingrese información faltante","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string espe = cmbEspecializacion.SelectedItem.ToString();
            string cert = txtCertificacion.Text;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            string strComandoSQL = "update tecnico set especializacion=@es,certificaciones=@ce where id=@id";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@es", espe);
            cmd.Parameters.AddWithValue("@ce", cert);
            cmd.Parameters.AddWithValue("@id", clave);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Técnico actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            decide();
        }
        private void limpiar()
        {
            txtCertificacion.Clear();
            cmbEspecializacion.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
