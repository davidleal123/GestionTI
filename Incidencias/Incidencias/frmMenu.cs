using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incidencias
{
    public partial class frmMenu : Form
    {
        string cargo = "";
        string contra = "";
        public frmMenu(string c,string con)
        {
            InitializeComponent();
            cargo = c;
            contra = con;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (cargo == "ADMINISTRADOR")
            {
                frmAltaEmpleado ae = new frmAltaEmpleado();
                ae.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmBajaEmpleado be = new frmBajaEmpleado(1);
                be.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmAltaTecnico at = new frmAltaTecnico();
                at.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmBajaEmpleado baja = new frmBajaEmpleado(3);
                baja.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (cargo == "TECNICO")
            {
                frmAltaEquipo ae = new frmAltaEquipo();
                ae.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (cargo == "TECNICO")
            {

                frmBajaEmpleado baja = new frmBajaEmpleado(5);
                baja.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAltaIncidencia ai = new frmAltaIncidencia(contra);
            ai.ShowDialog();
        }

        private void asignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmAsignaIncidencia asig = new frmAsignaIncidencia(cargo,contra);
                asig.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tiempoDeSolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargo == "TECNICO")
            {
                frmAsignaIncidencia asig = new frmAsignaIncidencia(cargo,contra);
                asig.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInicio inicio = new frmInicio();
            inicio.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIncidencia cInc = new frmConsultaIncidencia(cargo, contra);
            cInc.ShowDialog();
        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargo == "TECNICO")
            {
                frmTerminaIncidencia term = new frmTerminaIncidencia(cargo, contra);
                term.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void liberarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmTerminaIncidencia term = new frmTerminaIncidencia(cargo, contra);
                term.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void evaluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmEvaluarIncidencia eva = new frmEvaluarIncidencia(cargo, contra);
                eva.ShowDialog();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmBajaEmpleado baja = new frmBajaEmpleado(2);
                baja.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmMuestraEmpleados me = new frmMuestraEmpleados();
                me.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cambioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmBajaEmpleado baja = new frmBajaEmpleado(4);
                baja.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmMuestraTecnicos me = new frmMuestraTecnicos();
                me.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cambioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (cargo == "TECNICO")
            {

                frmBajaEmpleado baja = new frmBajaEmpleado(6);
                baja.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (cargo != "DOCENTE")
            {
                frmMuestraEquipos me = new frmMuestraEquipos();
                me.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmAltaServicio AltaSer = new frmAltaServicio();
                AltaSer.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargo != "DOCENTE")
            {
                frmCatalogoServicios cs = new frmCatalogoServicios();
                cs.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmAltaDepartamento adep = new frmAltaDepartamento();
                adep.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmMuestraDepartamento mdep = new frmMuestraDepartamento();
                mdep.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cambioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmBajaEmpleado baja = new frmBajaEmpleado(8);
                baja.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (cargo == "ADMINISTRADOR")
            {
                frmBajaEmpleado baja = new frmBajaEmpleado(7);
                baja.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
