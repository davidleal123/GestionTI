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
    public partial class frmCatalogoServicios : Form
    {
        public frmCatalogoServicios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCatalogoServicios_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=DAVIDLEALFLEF4C\\SQLEXPRESS;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            string con = "select * from servicios";
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
                    dataGridView1.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString());
                }
            }
            conn.Close();
        }
    }
}
