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
                frmBajaEmpleado be = new frmBajaEmpleado();
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
                frmBajaTecnico bt = new frmBajaTecnico();
                bt.ShowDialog();
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
                frmBajaEquipo be = new frmBajaEquipo();
                be.ShowDialog();
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
        }


    }
}
