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
    public partial class frmEvaluarIncidencia : Form
    {
        string cargo;
        string usuario;
        public frmEvaluarIncidencia(string c, string u)
        {
            InitializeComponent();
            cargo = c;
            usuario = u;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgEvaluar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbIncidencia.SelectedIndex==-1 || cmbIncidencia.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Selecciona una incidencia a evaluar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbCalificacion.SelectedIndex == -1 || cmbCalificacion.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Selecciona la calificación de la evaluación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                actualizaEstatusEvaluar();
                cargaData();
            } 
        }

        private void actualizaEstatusEvaluar()
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            string cal = cmbCalificacion.SelectedItem.ToString();
            string fec = txtTiempoTerminado.Text;
            string strComandoSQL = "update incidencia set estatus=@est, calificacion=@cal, tiempoSolucionReal=@fec where id=" + Convert.ToInt32(cmbIncidencia.SelectedItem.ToString()) + "";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@est", "Evaluada");
            cmd.Parameters.AddWithValue("@cal", cal);
            cmd.Parameters.AddWithValue("@fec", fec);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Incidencia Evaluada. \nPor favor llena la siguiente encuesta para completar el proceso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmEncuesta enc = new frmEncuesta();
                enc.ShowDialog();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Actualizar incidencia");
            }
            conn.Close();
        }

        private void frmEvaluarIncidencia_Load(object sender, EventArgs e)
        {
            txtFechaInicio.Enabled = false;
            txtFechaTerminacion.Enabled = false;
            txtTiempoPrometido.Enabled = false;
            txtTiempoTerminado.Enabled = false;
            cargaData();
        }

        private void cargaData()
        {
            dtgEvaluar.Rows.Clear();
            cmbIncidencia.Items.Clear();
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "select i.id,descripcion,d.nombre,concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where i.estatus='Liberada' and i.empleado=" + usuario;
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
                    dtgEvaluar.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString());
                    cmbIncidencia.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
            cmbIncidencia.SelectedIndex = -1;

        }

        private void cmbIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaFechas();
            DateTime fechaInicio = Convert.ToDateTime( txtFechaInicio.Text);
            DateTime fechaFinal = Convert.ToDateTime(txtFechaTerminacion.Text);

            // Difference in days, hours, and minutes.
            TimeSpan ts = fechaFinal - fechaInicio;

            // Difference in days.
            int difDias = ts.Days;
            //Diferencia en horas.
            int difHoras = ts.Hours;
            //Diferencia en minutos;
            int difMinutos = ts.Minutes;
            MessageBox.Show(difMinutos.ToString());
            if (difMinutos == 0)
            {
                txtTiempoTerminado.Text="1 Minuto";
            }
            else
            {
                if (difMinutos >= 1 && difMinutos <= 59)
                {

                    txtTiempoTerminado.Text = difMinutos + " Minutos";
                }
                else if (difHoras >= 1 && difHoras <= 24)
                {
                    txtTiempoTerminado.Text = difHoras + " Horas";
                }
                else
                {
                    txtTiempoTerminado.Text = difDias + " Días";
                }
            }
            
        }

        private void cargaFechas()
        {
            txtFechaInicio.Clear();
            txtFechaTerminacion.Clear();
            txtTiempoPrometido.Clear();
            txtTiempoTerminado.Clear();
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "select fechaInicio,fechaTerminacion,tiempoSolucion from incidencia where id=" + Convert.ToInt32(cmbIncidencia.SelectedItem.ToString());
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
                    txtFechaInicio.Text = lector.GetValue(0).ToString();
                    txtFechaTerminacion.Text = lector.GetValue(1).ToString();
                    txtTiempoPrometido.Text = lector.GetValue(2).ToString();
                }
            }
            conn.Close();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
