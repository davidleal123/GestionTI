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
    public partial class frmTerminaIncidencia : Form
    {
        string cargo;
        string usuario;
        public frmTerminaIncidencia(string c, string u)
        {
            InitializeComponent();
            cargo = c;
            usuario = u;
        }

        private void cargaDataTerminar()
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
            string strComandoSQL = "Select i.id,i.descripcion,e.equipo,d.nombre from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento inner join tecnico t on i.tecnico=t.id where i.tecnico is not NULL and i.estatus='En proceso'  and t.idEmpleado=" + usuario + "";
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

        private void cargaDataLiberar()
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
            string strComandoSQL = "Select i.id,i.descripcion,e.equipo,d.nombre, t.id from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento inner join tecnico t on i.tecnico=t.id where i.estatus='Terminada'";
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
            cmbIncidencia.SelectedIndex = -1;
        }

        private int regresaClaveTecnico() //TIENE QUE REGRESAR EL ID DE LA TABLA DEL TECNICO
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
            string strComandoSQL = "Select tecnico from incidencia where id=" + Convert.ToInt32(cmbIncidencia.SelectedItem.ToString()) + "";
            lector = UsoBD.Consulta(strComandoSQL, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta regresaClaveTEcnico");
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
            MessageBox.Show(clave.ToString()+"  Metodo Regresa clave Tecnico");
            return clave;
        }

        
        private void frmTerminaIncidencia_Load(object sender, EventArgs e)
        {
            autorizacion();
           
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

            SqlDataReader lector = null;
            string strComandoSQL = "select incidenciasAsignadas from tecnico t where id=" +Convert.ToInt32(regresaClaveTecnico()) + "";
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
            MessageBox.Show(inc.ToString() + "  numeros de incidencias asignadas que regresa el metodo");
            return inc;
        }

        private void autorizacion()
        {
            if (cargo == "ADMINISTRADOR")
            {
                btnLiberarIncidencia.Show();
                btnTerminaIncidencia.Hide();
                cargaDataLiberar();
                
            }
            else
            {
                btnLiberarIncidencia.Hide();
                btnTerminaIncidencia.Show();
                cargaDataTerminar();
            }
        }

        private void actualizaEstatusTerminar()
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            string fecha = DateTime.Now.ToString("yyyy/MM/dd H:mm:ss");
            string strComandoSQL = "update incidencia set estatus=@est, fechaTerminacion=@fec where id=" + Convert.ToInt32(cmbIncidencia.SelectedItem.ToString()) + "";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@est", "Terminada");
            cmd.Parameters.AddWithValue("@fec", fecha);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Incidencia Terminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Actualizar incidencia");
            }
            conn.Close();
        }

        private void actualizaEstatusLiberar()
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            
            string strComandoSQL = "update incidencia set estatus=@est where id=" + Convert.ToInt32(cmbIncidencia.SelectedItem.ToString()) + "";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@est", "Liberada");
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Incidencia Liberada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizaAsignaIncidencia();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Actualizar incidencia");
            }

            
            conn.Close();
        }

        private void actualizaAsignaIncidencia()
        {
            MessageBox.Show("Entra en actualiza incidencia");
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            int num = regresaNumeroIncidencias();
            num--;
            MessageBox.Show(num.ToString()+"  Nuevo numero de incidencias asignadas");
            string strComandoSQL = "update tecnico set incidenciasAsignadas=@inc where id=" + regresaClaveTecnico() + "";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@inc", num);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Restó incidencia", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Actualizar incidencia");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbIncidencia.SelectedIndex==-1 || cmbIncidencia.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Necesita seleccionar una incidencia a terminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbIncidencia.Focus();
            }
            else
            {
                if (cmbIncidencia.Items.Count == 0)
                {
                    MessageBox.Show("Este tecnico no tiene incidencias para terminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                        actualizaEstatusTerminar();
                        //actualizaAsignaIncidencia();
                        autorizacion();
                }
                
            }
            
        }

        private void btnLiberarIncidencia_Click(object sender, EventArgs e)
        {
            if (cmbIncidencia.SelectedIndex == -1 || cmbIncidencia.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Necesita seleccionar una incidencia a Liberar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbIncidencia.Focus();
            }
            else
            {
                if (cmbIncidencia.Items.Count == 0)
                {
                    MessageBox.Show("No tiene incidencias para Liberar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                        actualizaEstatusLiberar();
                        autorizacion();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
