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
    public partial class frmMuestraTecnicos : Form
    {
        public frmMuestraTecnicos()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMuestraTecnicos_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=CARLOS-GERMÁN;Initial Catalog=incidencias;Integrated Security=True";
            SqlConnection conn = UsoBD.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            string comando = "select distinct concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno),certificaciones,incidenciasAsignadas from tecnico t inner join empleado e on t.nombre=e.id";
            SqlDataReader lector = null; lector = UsoBD.Consulta(comando, conn);
            if (lector == null)
            {
                MessageBox.Show("Error en Consulta clave");
                conn.Close();
                return;
            }
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    dtgTecnicos.Rows.Add(false,lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString());
                }
            }
            conn.Close();
        }
    }
}
