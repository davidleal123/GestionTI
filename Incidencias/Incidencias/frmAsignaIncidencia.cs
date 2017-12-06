
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
        string[] atencion = { "1", "2", "3", "4", "5", "6", "7", "8" };
        string[] solucion = { "30 minutos", "1-2 horas", "3-5 horas", "1 día", "1-3 días", "1 semana", "2-3 semanas", "1 mes" };
        private void frmAsignaIncidencia_Load(object sender, EventArgs e)
        {
            Limpia();
            autorizacion();
        }
        private void autorizacion()
        {
            if (cargo == "ADMINISTRADOR")
            {
                cmbIncidencia.Enabled = true;
                cmbTiempoAtencion.Enabled = true;
                cmbTecnicos.Enabled = true;
                cmbTiempoSolucion.Enabled = false;
                cmbTipo.Enabled = true;
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
                cmbTipo.Enabled = false;
                cargaDataTecnico();
                cargaComboTecnico();
            }
        }
        private void cargaTecnicos()
        {
            dataGridView2.Rows.Clear();
            cmbTecnicos.Items.Clear();
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            SqlDataReader lector = null;
            string consulta = "select concat(e.nombre,' ',e.apellidoPaterno), especializacion,incidenciasAsignadas from tecnico INNER JOIN EMPLEADO E ON E.ID=TECNICO.IDEMPleado ";
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
        private int regresaClaveTecnico2() //TIENE QUE REGRESAR EL ID DE LA TABLA DEL TECNICO
        {
            int clave = -1;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return clave;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "Select idEmpleado from incidencia i inner join tecnico t on i.tecnico=t.id where idEmpleado=" + usuario + "";
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta clavedepa");
                conn.Close();
                return clave;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    clave = Convert.ToInt32(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
            return clave;
        }
        private void cargaDataTecnico()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            cmbIncidencia.Items.Clear();
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "Select i.id,i.descripcion,d.nombre,d.prioridad from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento inner join tecnico t on i.tecnico=t.id where i.tecnico is not NULL and i.estatus='Asignado'  and t.idEmpleado=" + usuario + "";//NECESITO USAR EL ID DE LA TABLA TECNICO
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
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "Select i.id,i.descripcion,d.nombre,d.prioridad from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento where i.tecnico is NULL ";
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
        private int regresaNumeroIncidencias()
        {
            int inc = -1;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return inc;
            }
            int index = Convert.ToInt32(cmbTecnicos.SelectedIndex.ToString());
            index++;
            SqlDataReader lector = null;
            string strComandoSQL = "select incidenciasAsignadas from tecnico t where id='" + index + "'";
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en obtener numero de incidencias");
                conn.Close();
                return inc;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    inc = Convert.ToInt32(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
            return inc;
        }
        private void actualizaNumeroIncidencias()
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            string strComandoSQL = "update tecnico set incidenciasAsignadas=@inc where id='" + regresaClaveTecnico() + "'";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@inc", (regresaNumeroIncidencias()) + 1);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Actualizar incidencia al tecnico");
            }
            conn.Close();
        }

        private void actualizaAdminitrador()
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            string strComandoSQL = "update incidencia set tipo=@tipo, tecnico=@usu,tiempoAtender=@tiemate,estatus=@est where id=" + Convert.ToInt32(cmbIncidencia.SelectedItem.ToString()) + "";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@tipo", cmbTipo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@usu", regresaClaveTecnico());
            cmd.Parameters.AddWithValue("@tiemate", cmbTiempoAtencion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@est", "Asignado");
            

            try
            {
                cmd.ExecuteNonQuery();
                actualizaNumeroIncidencias();
                MessageBox.Show("Técnico Asingado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Actualizar incidencia");
            }
            conn.Close();
            Limpia();
            autorizacion();
        }
        private int regresaClaveTecnico()
        {
            int clave = -1;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return clave;
            }
            SqlDataReader lector = null;
            int index = Convert.ToInt32( cmbTecnicos.SelectedIndex.ToString());
            index++;
            string strComandoSQL = "select t.id from tecnico t inner join empleado e on e.id=t.idEmpleado where t.id='" + index + "'";
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta claveTecnico");
                conn.Close();
                return clave;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    clave = Convert.ToInt32(lector.GetValue(0).ToString());
                    
                }
            }
            conn.Close();
            return clave;
        }

        private void actualizaTecnico()
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            string fecha = DateTime.Now.ToString("yyyy/MM/dd H:mm:ss");
            string strComandoSQL = "update incidencia set tiempoSolucion=@tiemsol,estatus=@est,fechaInicio=@fecha where id='" + cmbIncidencia.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@tiemsol", cmbTiempoSolucion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@est", "En proceso");
            cmd.Parameters.AddWithValue("@fecha", fecha);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
