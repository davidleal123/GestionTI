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
    public partial class frmAltaServicio : Form
    {
        public frmAltaServicio()
        {
            InitializeComponent();
        }
        string[] unidades = { "horas","dias","meses"};

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }
        private void Limpia()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void frmAltaServicio_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                comboBox1.Items.Add(i);
            }
            for(int i=0;i<unidades.Length;i++)
            {
                comboBox2.Items.Add(unidades[i]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                string des = richTextBox1.Text.ToString();
                string sol = richTextBox2.Text.ToString(); ;
                string tiempo = comboBox1.SelectedItem.ToString()+" "+comboBox2.SelectedItem.ToString();


                if (string.IsNullOrWhiteSpace(des) || string.IsNullOrWhiteSpace(sol) || comboBox1.SelectedIndex==-1 || comboBox2.SelectedIndex==-1)
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
                //string strComandoSQL = "insert into empleado(nombre,apellidoPaterno,apellidoMaterno,correoElectronico,contraseña,numeroCelular,direccion,cargo,departamento)";
                string strComandoSQL = "insert into servicios(descripcion,solucion,tiempo)";
                strComandoSQL += " values(@descrip,@solucion,@tiempo)";
                SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
                cmd.Parameters.AddWithValue("@descrip", des);
                cmd.Parameters.AddWithValue("@solucion", sol);
                cmd.Parameters.AddWithValue("@tiempo", tiempo);
  
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Servicio dado del Alta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
