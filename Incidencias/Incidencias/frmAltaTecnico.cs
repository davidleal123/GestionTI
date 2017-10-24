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
    public partial class frmAltaTecnico : Form
    {
        public frmAltaTecnico()
        {
            InitializeComponent();
            
        }
        string[] especializaciones = { "REDES", "PROGRAMACION JAVA", "PROGRAMACION C++", "REPARACION HARDWARE","REPARACION SOFTWARE","DESARROLLO WEB","CCNA 1","CCNA2","CCNA3","CCNA4","OTRO" };
        private void frmAltaTecnico_Load(object sender, EventArgs e)
        {
            ActualizaCombo(cmbNombre, "select distinct concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) from empleado e join tecnico t on t.nombre!=e.id");
            ActualizaCombo(cmbId, "select id from empleado except(select nombre from tecnico)");
            for (int i = 0; i < especializaciones.Length; i++)
            {
                cmbEspecializacion.Items.Add(especializaciones[i]);
            }
        }
        public void ActualizaCombo(ComboBox combo, string con)
        {
            combo.Items.Clear();
            string strCon = "Data Source=DAVIDLEALFLEF4C;Initial Catalog=incidencias;Integrated Security=True";
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

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNombre.SelectedIndex = Convert.ToInt32(cmbId.SelectedIndex.ToString());
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbId.SelectedIndex = Convert.ToInt32(cmbNombre.SelectedIndex.ToString());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }

        private void Limpia()
        {
            txtCertificacion.Clear();
            cmbId.SelectedIndex = -1;
            cmbEspecializacion.SelectedIndex = -1;
            cmbNombre.SelectedIndex = -1;
            cmbId.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool BuscaTecnico(string clave)
        {
            bool band = false;
            string strCon = "Data Source=DAVIDLEALFLEF4C;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return band;
            }
            string comando = "Select * from tecnico where nombre=" + clave + "";
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string id = cmbId.SelectedItem.ToString();
                string nombre = cmbNombre.SelectedItem.ToString();
                string especializacion = cmbEspecializacion.SelectedItem.ToString();
                string certificaciones = txtCertificacion.Text;

                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(especializacion) || string.IsNullOrWhiteSpace(certificaciones))
                {
                    MessageBox.Show("Información Faltante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strCon = "Data Source=DAVIDLEALFLEF4C;Initial Catalog=incidencias;Integrated Security=True";
                SqlConnection conn = UsoBD.ConectaBD(strCon);
                if (conn == null)
                {
                    MessageBox.Show("Imposible Conectar con BD");
                    return;
                }
                if (BuscaTecnico(id)==true)
                {
                    MessageBox.Show("Este empleado ya ha sido registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //string strComandoSQL = "insert into empleado(nombre,apellidoPaterno,apellidoMaterno,correoElectronico,contraseña,numeroCelular,direccion,cargo,departamento)";
                string strComandoSQL = "insert into tecnico";
                strComandoSQL += " values(@nom,@esp,@cer,0)";
                SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
                cmd.Parameters.AddWithValue("@nom", id);
                cmd.Parameters.AddWithValue("@esp", especializacion);
                cmd.Parameters.AddWithValue("@cer", certificaciones);
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
    }
}
