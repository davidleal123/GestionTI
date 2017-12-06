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
    public partial class frmConsultaIncidencia : Form
    {
        string cargo;
        string usuario;
        public frmConsultaIncidencia(string c, string u)
        {
            InitializeComponent();
            cargo = c;
            usuario = u;

        }

        public void rellenaDataGridTodo(DataGridView data, string con)
        {
            data.Rows.Clear();
            int col = data.ColumnCount;
            //Data Source=DESKTOP-HRH1LBC\ANTONIOPC;Initial Catalog=incidencias;Integrated Security=True
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
                    data.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString());
                }
            }
            conn.Close();
        }

        public void rellenaDataGrid(DataGridView data, string con)
        {
            data.Rows.Clear();
            int col = data.ColumnCount;
            //Data Source=DESKTOP-HRH1LBC\ANTONIOPC;Initial Catalog=incidencias;Integrated Security=True
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
                    data.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString());
                }
            }
            conn.Close();
        }

        public void rellenaDataGridEvaluadas(DataGridView data, string con)
        {
            data.Rows.Clear();
            int col = data.ColumnCount;
            //Data Source=DESKTOP-HRH1LBC\ANTONIOPC;Initial Catalog=incidencias;Integrated Security=True
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
                    data.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(),lector.GetValue(4).ToString());
                }
            }
            conn.Close();
        }

        private void dtgTodas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgProceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void autorizacion()
        {
            if(cargo=="ADMINISTRADOR")
            {
                rellenaDataGridTodo(dtgTodas, "select i.id,descripcion,d.nombre,concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) ,estatus from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado order by estatus");
                rellenaDataGrid(dtgPendientes, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Pendiente'");
                rellenaDataGrid(dtgProceso, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='En Proceso'");
                rellenaDataGrid(dtgAsignadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Asignado'");
                rellenaDataGrid(dtgTerminadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Terminada'");
                rellenaDataGrid(dtgLiberadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Liberada'");
                rellenaDataGridEvaluadas(dtgEvaluadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico, calificacion from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Evaluada'");
            }
            else if(cargo=="TECNICO")
            {
                rellenaDataGridTodo(dtgTodas, "select i.id,descripcion,d.nombre,concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) ,estatus from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where t.idEmpleado="+usuario+" order by estatus");
                rellenaDataGrid(dtgPendientes, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Pendiente' and t.idEmpleado="+usuario);
                rellenaDataGrid(dtgProceso, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='En Proceso' and t.idEmpleado="+usuario);
                rellenaDataGrid(dtgAsignadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Asignado' and t.idEmpleado=" + usuario);
                rellenaDataGrid(dtgTerminadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Terminada' and t.idEmpleado=" + usuario);
                rellenaDataGrid(dtgLiberadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Liberada' and t.idEmpleado=" + usuario);
                rellenaDataGridEvaluadas(dtgEvaluadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico, calificacion from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Evaluada' and t.idEmpleado=" + usuario);
            }
            else
            {
                rellenaDataGridTodo(dtgTodas, "select i.id,descripcion,d.nombre,concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) ,estatus from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where i.empleado="+usuario+" order by estatus ");
                rellenaDataGrid(dtgPendientes, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Pendiente' and i.empleado=" + usuario);
                rellenaDataGrid(dtgProceso, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='En Proceso' and i.empleado=" + usuario);
                rellenaDataGrid(dtgAsignadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Asignado' and i.empleado=" + usuario);
                rellenaDataGrid(dtgTerminadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Terminada' and i.empleado=" + usuario);
                rellenaDataGrid(dtgLiberadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Liberada' and i.empleado=" + usuario);
                rellenaDataGridEvaluadas(dtgEvaluadas, "select i.id,descripcion,d.nombre 'Departamento',concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Tecnico, calificacion from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Evaluada' and i.empleado=" + usuario);
            }
        }
        private void frmConsultaIncidencia_Load(object sender, EventArgs e)
        {
            autorizacion();
        }
    }
}
