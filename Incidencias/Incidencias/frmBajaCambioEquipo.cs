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
    public partial class frmBajaCambioEquipo : Form
    {
        int distintivo;
        string clave;
        public frmBajaCambioEquipo(int d, string c)
        {
            InitializeComponent();
            distintivo = d;
            clave = c;
        }

        private void frmBajaCambioEquipo_Load(object sender, EventArgs e)
        {
            decide();
        }
        private void decide()
        {
            if (distintivo == 5)
            {
                btnEliminar.Visible = true;
                btnActualizar.Visible = false;
                btnLimpiar.Visible = false;

            }
            else
            {
                btnEliminar.Visible = false;
                btnActualizar.Visible = true;
                btnLimpiar.Visible = true;
                txtDescripcion.Enabled = true;
                txtEquipo.Enabled = true;
                txtMarca.Enabled = true;
                txtModelo.Enabled = true;
                cmbDepartamento.Enabled = true;
                cmbGarantia.Enabled = true;
                cargaCombo();
                llenaComboAños();
            }
            llenaDatos();
        }
        private void cargaCombo()
        {
            cmbDepartamento.Items.Clear();
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            SqlDataReader lector = null;
            string con = "select nombre from departamento";
            lector = UsoBD.Consulta(con, conn);
            if (lector == null)
            {
                conn.Close();
                return;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    cmbDepartamento.Items.Add(lector.GetValue(0).ToString());
                }
            }
            conn.Close();
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
            string con = "select equipo,marca,modelo,descripcion,garantia,fechacompra,nombre from equipo e inner join departamento d on d.id=e.departamento where e.id=" + clave + "";
            lector = UsoBD.Consulta(con, conn);
            if (lector == null)
            {
                conn.Close();
                return;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    txtEquipo.Text = lector.GetValue(0).ToString();
                    txtMarca.Text = lector.GetValue(1).ToString();
                    txtModelo.Text = lector.GetValue(2).ToString();
                    txtDescripcion.Text = lector.GetValue(3).ToString();
                    cmbGarantia.Text = lector.GetValue(4).ToString();
                    txtFechaCompra.Text = lector.GetValue(5).ToString();
                    cmbDepartamento.Text = lector.GetValue(6).ToString();
                }
            }
            conn.Close();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtModelo.Clear();
            txtMarca.Clear();
            txtEquipo.Clear();
            txtDescripcion.Clear();
            cmbGarantia.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
        }
        private void llenaComboAños()
        {
            for (int i = 1;i<=20 ; i++)
            {
                cmbGarantia.Items.Add(i);
            }
        }
        private int regresaclavedepa()
        {
            int claveb = -1;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return claveb;
            }

            SqlDataReader lector = null;
            string con = "select d.id from departamento d where d.nombre='" + cmbDepartamento.SelectedItem.ToString() + "'";
            lector = UsoBD.Consulta(con, conn);
            if (lector == null)
            {
                conn.Close();
                return claveb;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    claveb = Convert.ToInt32(lector.GetValue(0).ToString());            
                }
            }
            conn.Close();
            return claveb;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string mo = txtModelo.Text;
            string ma = txtMarca.Text;
            string eq = txtEquipo.Text;
            string de = txtDescripcion.Text;

            if (cmbDepartamento.SelectedIndex == -1 || cmbGarantia.SelectedIndex == -1 || string.IsNullOrWhiteSpace(mo) || string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(de) || string.IsNullOrWhiteSpace(eq))
            {
                MessageBox.Show("Ingrese información faltante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            int clavedepartamento = regresaclavedepa();
            MessageBox.Show(""+clavedepartamento+"");
            string strComandoSQL = "update EQUIPO set equipo=@equi,marca=@mar,modelo=@mod,descripcion=@desc,departamento=@depar,garantia=@gara where id=@id";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@equi",eq);
            cmd.Parameters.AddWithValue("@mar", ma);
            cmd.Parameters.AddWithValue("@mod", mo);
            cmd.Parameters.AddWithValue("@desc", de);
            cmd.Parameters.AddWithValue("@depar", clavedepartamento);
            cmd.Parameters.AddWithValue("@gara", cmbGarantia.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@id", clave);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Equipo actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            decide();
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

            string strComandoSQL = "delete from equipo where id=@id";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@id", clave);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Equipo eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Errors.ToString());
                MessageBox.Show("No se puede eliminar un Equipo Asignado a una Transacción","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            conn.Close();
            this.Close();
        }

        private void txtEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Metodos.ValidaTexto(e,txtEquipo,errorProvider1);
        }
    }
}
