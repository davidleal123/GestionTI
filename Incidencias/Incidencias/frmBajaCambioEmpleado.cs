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
    public partial class frmBajaCambioEmpleado : Form
    {
        int distintivo;
        string clave;
        public frmBajaCambioEmpleado(int d,string c)
        {
            InitializeComponent();
            distintivo = d;
            clave = c;
        }
        string[] cargos = { "ADMINISTRADOR","TECNICO","DOCENTE"};
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            if (checaEmpleado())
            {
                MessageBox.Show("El empleado tiene incidencias sin resolver","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (cargoactual == "TECNICO")
            {
                if (regresaNumeroIncidencias() != 0)
                {
                    MessageBox.Show("El empleado es Técnico y tiene incidencias Asignadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!eliminaTecnico())
            {
                MessageBox.Show("El empleado tiene insidencias como técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string strComandoSQL = "delete from empleado where id=@idEmpleado";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@idEmpleado", clave);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado Eliminado","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            this.Close();
        }
        private bool checaEmpleado()
        {
            bool band = false;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return false;
            }

            SqlDataReader lector = null;
            string con = "select i.estatus from empleado e inner join incidencia i on i.empleado=e.id where e.id="+clave+" and i.estatus != 'Evaluada'";
            lector = UsoBD.Consulta(con, conn);
            if (lector == null)
            {
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

        private void frmBajaCambioEmpleado_Load(object sender, EventArgs e)
        {
            limpiar();
            decide();
           
        }
        private void decide()
        {
            if (distintivo == 1)
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
                txtNombre.Enabled = true;
                txtApePat.Enabled = true;
                txtApeMat.Enabled = true;
                txtDireccion.Enabled = true;
                txtCorreo.Enabled = true;
                txtNumCel.Enabled = true;
                cmbDepa.Enabled = true;
                cmbCargo.Enabled = true;
                llenaComboCargos();
                llenaComboDepa();
            }
            llenaDatos();
        }
        private void llenaComboCargos()
        {
            for (int i = 0; i < cargos.Length; i++)
            {
                cmbCargo.Items.Add(cargos[i]);
            }
        }
        private void llenaComboDepa()
        {
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
                    cmbDepa.Items.Add( lector.GetValue(0).ToString());
                }
            }
            conn.Close();
        }
        string cargoactual;
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
            string con = "select e.nombre,e.apellidopaterno,e.apellidomaterno,e.correoelectronico,e.contraseña,e.numerocelular,e.direccion,e.cargo,d.nombre from empleado e inner join departamento d on d.id=e.departamento where e.id="+clave+"";
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
                    txtNombre.Text = lector.GetValue(0).ToString();
                    txtApePat.Text = lector.GetValue(1).ToString();
                    txtApeMat.Text = lector.GetValue(2).ToString();
                    txtCorreo.Text = lector.GetValue(3).ToString();
                    txtContra.Text = lector.GetValue(4).ToString();
                    txtNumCel.Text = lector.GetValue(5).ToString();
                    txtDireccion.Text = lector.GetValue(6).ToString();
                    cmbCargo.Text = lector.GetValue(7).ToString();
                    cargoactual = lector.GetValue(7).ToString();
                    cmbDepa.Text = lector.GetValue(8).ToString();
                }
            }
            conn.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtNombre.Clear();
            txtApePat.Clear();
            txtApeMat.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtNumCel.Clear();
            txtContra.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbDepa.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int regresaNumeroIncidencias()
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
            string con = "select t.incidenciasAsignadas from tecnico t inner join empleado e on e.id=t.idempleado where idempleado="+clave+"";
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
            string nom = txtNombre.Text;
            string apepat = txtApePat.Text;
            string apemat = txtApeMat.Text;
            string dire = txtDireccion.Text;
            string num = txtNumCel.Text;
            string corre = txtCorreo.Text;
            string cargo = cmbCargo.SelectedItem.ToString();
            string depa = cmbDepa.SelectedItem.ToString();

            if (cmbDepa.SelectedIndex == -1 || cmbCargo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(apepat) || string.IsNullOrWhiteSpace(apemat) || string.IsNullOrWhiteSpace(dire) || string.IsNullOrWhiteSpace(corre) || string.IsNullOrWhiteSpace(num))
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
            if(cargoactual=="TECNICO"){
                if (regresaNumeroIncidencias() != 0)
                {
                    MessageBox.Show("El empleado es Técnico y tiene incidencias Asignadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!eliminaTecnico())
            {
                MessageBox.Show("El empleado tiene insidencias como técnico","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int clavedepartamento = regresaclavedepa();
            string strComandoSQL = "update EMPLEADO set nombre=@nom,apellidopaterno=@apepa,apellidomaterno=@apema,correoelectronico=@correo,numerocelular=@numcel,direccion=@direcc,cargo=@cargo,departamento=@depar where id=@id";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@apepa", apepat);
            cmd.Parameters.AddWithValue("@apema", apemat);
            cmd.Parameters.AddWithValue("@correo", corre);
            cmd.Parameters.AddWithValue("@numcel", num);
            cmd.Parameters.AddWithValue("@direcc", dire);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@depar", clavedepartamento);
            cmd.Parameters.AddWithValue("@id", clave);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            decide();           
        }
        private bool eliminaTecnico()
        {
            bool band = false;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }

            string strComandoSQL = "delete from tecnico where idEmpleado=@idEmpleado";
            SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
            cmd.Parameters.AddWithValue("@idEmpleado", clave);

            try
            {
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return band;
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
            string con = "select d.id from departamento d where d.nombre='" + cmbDepa.SelectedItem.ToString() + "'";
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Metodos.ValidaTexto(e,txtNombre,errorProvider1);
        }

        private void txtApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Metodos.ValidaTexto(e, txtApePat, errorProvider1);
        }

        private void txtApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Metodos.ValidaTexto(e, txtApeMat, errorProvider1);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Metodos.ValidaNumero(e, txtNumCel, errorProvider1);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }
    }
}
