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
    public partial class frmAltaDepartamento : Form
    {
        public frmAltaDepartamento()
        {
            InitializeComponent();
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiar()
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }
        string[] prioridad = {"ALTA","MEDIA","BAJA" };
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string Nom = textBox1.Text;
                string prio = comboBox1.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(Nom) || comboBox1.SelectedIndex == -1)
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
                string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
                SqlConnection conn = UsoBD.ConectaBD(strCon);
                if (conn == null)
                {
                    MessageBox.Show("Imposible Conectar con BD");
                    return;
                }
                //string strComandoSQL = "insert into empleado(nombre,apellidoPaterno,apellidoMaterno,correoElectronico,contraseña,numeroCelular,direccion,cargo,departamento)";
                string strComandoSQL = "insert into departamento(nombre,prioridad)";
                strComandoSQL += " values(@nom,@prio)";
                SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
                cmd.Parameters.AddWithValue("@nom", Nom);
                cmd.Parameters.AddWithValue("@prio", prio);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Departamento Guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                limpiar();
            }
        }
        private void llenaCombo()
        {
            for (int i = 0; i < prioridad.Length; i++)
            {
                comboBox1.Items.Add(prioridad[i]);
            }
        }

        private void frmAltaDepartamento_Load(object sender, EventArgs e)
        {
     
            llenaCombo();
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Metodos.ValidaTexto(e, textBox1, errorProvider1);
        }
    }
}
