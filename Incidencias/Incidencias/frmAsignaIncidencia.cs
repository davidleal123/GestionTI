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
    public partial class frmAsignaIncidencia : Form
    {
        string cargo;
        string usuario;
        public frmAsignaIncidencia(string c, string u)
        {
            InitializeComponent();
            cargo = c;
            usuario = u;
        }
        string[] atencion = {"1","2","3","4","5","6","7","8" };
        string[] solucion = {"30 minutos","1-2 horas","3-5 horas","1 día","1-3 días","1 semana","2-3 semanas","1 mes"};
        private void frmAsignaIncidencia_Load(object sender, EventArgs e)
        {
            autorizacion();
        }
        private void autorizacion()
        {
            if (cargo == "ADMINISTRADOR")
            {
                cmbIncidencia.Enabled = true;
                cmbTiempoAtencion.Enabled=true;
                cmbTecnicos.Enabled = true;
                cmbTiempoSolucion.Enabled=false;
                cargaDataAdmin();
                cargaComboAdmin();
                cargaTecnicos();
            }
            else
            {
                cmbIncidencia.Enabled = true;
                cmbTiempoAtencion.Enabled = false;
                cmbTecnicos.Enabled = false;
                cmbTiempoSolucion.Enabled = true;
                cargaDataTecnico();
                cargaComboTecnico();
            }
        }
        private void cargaTecnicos()
        {
            dataGridView2.Rows.Clear();
            cmbTecnicos.Items.Clear();
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            SqlDataReader lector = null;
            string consulta = "select e.nombre, especializacion,incidenciasAsignadas from tecnico INNER JOIN EMPLEADO E ON E.ID=TECNICO.IDEMPleado ";
            lector = UsoBD.Consulta(consulta, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta clavedepa");
                conn.Close();
                return;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    dataGridView2.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString());
                    cmbTecnicos.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }

        private void cargaComboTecnico()
        {
            cmbTiempoSolucion.Items.Clear();
            for (int i = 0; i < solucion.Length; i++)
            {
                cmbTiempoSolucion.Items.Add(solucion[i]);
            }
        }
        private void cargaComboAdmin()
        {
            cmbTiempoAtencion.Items.Clear();
            for (int i = 0; i < atencion.Length; i++)
            {
                cmbTiempoAtencion.Items.Add(atencion[i]);
            }
        }
        private void cargaDataTecnico()
        {
            dataGridView1.Rows.Clear();
            cmbIncidencia.Items.Clear();
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "Select i.id,e.equipo,i.descripcion,d.prioridad from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento where i.tecnico is not NULL  and i.tecnico='"+usuario+"'";
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta clavedepa");
                conn.Close();
                return;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    dataGridView1.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString());
                    cmbIncidencia.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }
      
        private void cargaDataAdmin()
        {
            dataGridView1.Rows.Clear();
            cmbIncidencia.Items.Clear();
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "Select i.id,e.equipo,i.descripcion,d.prioridad from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento where i.tecnico is NULL ";
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta clavedepa");
                conn.Close();
                return;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    dataGridView1.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString());
                    cmbIncidencia.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }

        private void Limpia()
        {
            cmbTiempoSolucion.SelectedIndex = -1;
            cmbTiempoAtencion.SelectedIndex = -1;
            cmbTecnicos.SelectedIndex = -1;
            cmbIncidencia.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                actualizaAdminitrador();
            }
            else
            {
                actualizaTecnico();
            }
        }
        private void actualizaAdminitrador()
        {
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            string strComandoSQL = "update incidencia set tecnico=@usu,tiempoAtender=@tiemate,estatus=@est where id='" + cmbIncidencia.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@usu", usuario);
            cmd.Parameters.AddWithValue("@tiemate", cmbTiempoAtencion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@est", "Asignado");
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Técnico Asignado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            Limpia();
            autorizacion();
        }
        private void actualizaTecnico()
        {
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            } 
            string strComandoSQL = "update incidencia set tiempoSolucion=@tiemsol,estatus=@est where id='"+cmbIncidencia.SelectedItem.ToString()+"'";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@tiemsol", cmbTiempoSolucion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@est", "En proceso");
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tiempo Asignado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            Limpia();
            autorizacion();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
