using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metodos;
using Libreria1;

namespace Incidencias
{
    public partial class frmAltaEquipo : Form
    {
        public frmAltaEquipo()
        {
            InitializeComponent();
        }

        private void frmAltaEquipo_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 30; i++)
            {
                cmbGarantia.Items.Add(i);
            }
            ActualizaCombo(cmbDepartamento, "select nombre from departamento");
            dtpFechaCompra.MaxDate = DateTime.Today.Date;
        }
        public void ActualizaCombo(ComboBox combo, string con)
        {
            combo.Items.Clear();
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Metodos.ValidaTexto(e, txtEquipo, errorProvider1);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private int RegresaClaveDepa(string Departamento)
        {
            int band = -1;
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }

        public void Limpia()
        {
            txtDescripcion.Clear();
            txtEquipo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            dtpFechaCompra.SetDate(dtpFechaCompra.MaxDate);
            cmbDepartamento.SelectedIndex = -1;
            cmbGarantia.SelectedIndex = -1;
            txtEquipo.Focus();          
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
               
                string equipo = txtEquipo.Text;
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                string descripcion = txtDescripcion.Text;
                int garantia =Convert.ToInt32(cmbGarantia.SelectedItem.ToString());
                string fechaCompra = dtpFechaCompra.SelectionEnd.ToString("yyyy/MM/dd");
                string Depa = cmbDepartamento.SelectedItem.ToString();
                MessageBox.Show(fechaCompra);
                if (string.IsNullOrWhiteSpace(equipo) || string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(cmbGarantia.SelectedItem.ToString()) || string.IsNullOrWhiteSpace(fechaCompra) || string.IsNullOrWhiteSpace(Depa))
                {
                    MessageBox.Show("Información Faltante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
                SqlConnection conn = UsoBD.ConectaBD(strCon);
                if (conn == null)
                {
                    MessageBox.Show("Imposible Conectar con BD");
                    return;
                }
                int ClaveDepa = RegresaClaveDepa(Depa);
                //string strComandoSQL = "insert into empleado(nombre,apellidoPaterno,apellidoMaterno,correoElectronico,contraseña,numeroCelular,direccion,cargo,departamento)";
                string strComandoSQL = "insert into equipo";
                strComandoSQL += " values(@equipo,@marca,@mod,@des,@gar,@fecha,@dep)";
                SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
                cmd.Parameters.AddWithValue("@equipo", equipo);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@mod", modelo);
                cmd.Parameters.AddWithValue("@des", descripcion);
                cmd.Parameters.AddWithValue("@gar", garantia);
                cmd.Parameters.AddWithValue("@fecha", fechaCompra);
                cmd.Parameters.AddWithValue("@dep", ClaveDepa); 
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Equipo dado de alta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                Limpia();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
