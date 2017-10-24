using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Libreria1;
using Metodos;

namespace Incidencias
{
    public partial class frmAltaEmpleado : Form
    {
        public frmAltaEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string [] cargos = {"ADMINISTRADOR","TECNICO","DOCENTE"};
        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {
            ActualizaCombo(cmbDepa,"select nombre from departamento");
            for (int i = 0; i < cargos.Length; i++)
            {
                cmbCargo.Items.Add(cargos[i]);
            }
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }

        private void Limpia(){
            txtNombre.Clear();
            txtApePat.Clear();
            txtApeMat.Clear();
            txtContra.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtNumCel.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbDepa.SelectedIndex = -1;
        }
        private int RegresaClaveDepa(string Departamento)
        {
            int band = -1;
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }
            SqlDataReader lector = null;
            string strComandoSQL = "Select id from departamento where nombre='" + Departamento + "'";
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string Nom = txtNombre.Text;
                string ApePat = txtApePat.Text;
                string ApeMat = txtApeMat.Text;
                string Corre = txtCorreo.Text;
                string Contra = txtContra.Text;
                string Numero = txtNumCel.Text;
                string Dire = txtDireccion.Text;
                string Carg = cmbCargo.SelectedItem.ToString();
                string Depa = cmbDepa.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(Nom) || string.IsNullOrWhiteSpace(ApePat) || string.IsNullOrWhiteSpace(ApeMat) || string.IsNullOrWhiteSpace(Carg)
                    || string.IsNullOrWhiteSpace(Depa) || string.IsNullOrWhiteSpace(Dire) || string.IsNullOrWhiteSpace(Contra) || cmbCargo.SelectedIndex==-1 || cmbDepa.SelectedIndex==-1 )
                {
                    MessageBox.Show("Información Faltante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                /*if (BuscaClave(Contra))
                {
                    MessageBox.Show("Contraseña Duplicada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContra.Clear(); txtContra.Focus();
                    return;
                }*/
                string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
                SqlConnection conn = UsoBD.ConectaBD(strCon);
                if (conn == null)
                {
                    MessageBox.Show("Imposible Conectar con BD");
                    return;
                }
                int ClaveDepa=RegresaClaveDepa(Depa);
                //string strComandoSQL = "insert into empleado(nombre,apellidoPaterno,apellidoMaterno,correoElectronico,contraseña,numeroCelular,direccion,cargo,departamento)";
                string strComandoSQL = "insert into empleado(nombre,apellidoPaterno,apellidoMaterno,correoElectronico,contraseña,numeroCelular,direccion,cargo,departamento)";
                strComandoSQL += " values(@nom,@apepat,@apemat,@ce,@con,@num,@dir,@car,@dep)";
                SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
                cmd.Parameters.AddWithValue("@nom", Nom);
                cmd.Parameters.AddWithValue("@apepat", ApePat);
                cmd.Parameters.AddWithValue("@apemat", ApeMat);
                cmd.Parameters.AddWithValue("@ce", Corre);
                cmd.Parameters.AddWithValue("@con", Contra);
                cmd.Parameters.AddWithValue("@num", Numero);
                cmd.Parameters.AddWithValue("@dir", Dire);
                cmd.Parameters.AddWithValue("@car", Carg);
                cmd.Parameters.AddWithValue("@dep", ClaveDepa);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado Guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                Limpia();
            }
        }
        public bool BuscaClave(string clave)
        {
            bool band = false;
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }
            string comando = "Select contraseña from Empleado where id= " + clave + "";
            SqlDataReader lector = null; lector = UsoBD.Consulta(comando, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta clave");
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

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
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
