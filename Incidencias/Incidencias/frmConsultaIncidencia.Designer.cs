namespace Incidencias
{
    partial class frmConsultaIncidencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Liberadas = new System.Windows.Forms.TabPage();
            this.Proceso = new System.Windows.Forms.TabPage();
            this.Pendiente = new System.Windows.Forms.TabPage();
            this.dtgLiberadas = new System.Windows.Forms.DataGridView();
            this.Asignada = new System.Windows.Forms.TabPage();
            this.Todas = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTodas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProceso = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgAsignadas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPendientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Liberadas.SuspendLayout();
            this.Proceso.SuspendLayout();
            this.Pendiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLiberadas)).BeginInit();
            this.Asignada.SuspendLayout();
            this.Todas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Todas);
            this.tabControl1.Controls.Add(this.Liberadas);
            this.tabControl1.Controls.Add(this.Proceso);
            this.tabControl1.Controls.Add(this.Asignada);
            this.tabControl1.Controls.Add(this.Pendiente);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // Liberadas
            // 
            this.Liberadas.Controls.Add(this.dtgLiberadas);
            this.Liberadas.Location = new System.Drawing.Point(4, 22);
            this.Liberadas.Name = "Liberadas";
            this.Liberadas.Padding = new System.Windows.Forms.Padding(3);
            this.Liberadas.Size = new System.Drawing.Size(836, 428);
            this.Liberadas.TabIndex = 0;
            this.Liberadas.Text = "Liberadas";
            this.Liberadas.UseVisualStyleBackColor = true;
            // 
            // Proceso
            // 
            this.Proceso.Controls.Add(this.dtgProceso);
            this.Proceso.Location = new System.Drawing.Point(4, 22);
            this.Proceso.Name = "Proceso";
            this.Proceso.Padding = new System.Windows.Forms.Padding(3);
            this.Proceso.Size = new System.Drawing.Size(836, 428);
            this.Proceso.TabIndex = 1;
            this.Proceso.Text = "En Proceso";
            this.Proceso.UseVisualStyleBackColor = true;
            // 
            // Pendiente
            // 
            this.Pendiente.Controls.Add(this.dtgPendientes);
            this.Pendiente.Location = new System.Drawing.Point(4, 22);
            this.Pendiente.Name = "Pendiente";
            this.Pendiente.Size = new System.Drawing.Size(836, 428);
            this.Pendiente.TabIndex = 2;
            this.Pendiente.Text = "Pendientes";
            this.Pendiente.UseVisualStyleBackColor = true;
            // 
            // dtgLiberadas
            // 
            this.dtgLiberadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLiberadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dtgLiberadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLiberadas.Location = new System.Drawing.Point(3, 3);
            this.dtgLiberadas.Name = "dtgLiberadas";
            this.dtgLiberadas.Size = new System.Drawing.Size(830, 422);
            this.dtgLiberadas.TabIndex = 0;
            // 
            // Asignada
            // 
            this.Asignada.Controls.Add(this.dtgAsignadas);
            this.Asignada.Location = new System.Drawing.Point(4, 22);
            this.Asignada.Name = "Asignada";
            this.Asignada.Padding = new System.Windows.Forms.Padding(3);
            this.Asignada.Size = new System.Drawing.Size(836, 428);
            this.Asignada.TabIndex = 3;
            this.Asignada.Text = "Asignadas";
            this.Asignada.UseVisualStyleBackColor = true;
            // 
            // Todas
            // 
            this.Todas.Controls.Add(this.dtgTodas);
            this.Todas.Location = new System.Drawing.Point(4, 22);
            this.Todas.Name = "Todas";
            this.Todas.Size = new System.Drawing.Size(836, 428);
            this.Todas.TabIndex = 4;
            this.Todas.Text = "Todas";
            this.Todas.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No. Inicidencia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Departamento";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Técnico Asignado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dtgTodas
            // 
            this.dtgTodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTodas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgTodas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTodas.Location = new System.Drawing.Point(0, 0);
            this.dtgTodas.Name = "dtgTodas";
            this.dtgTodas.Size = new System.Drawing.Size(836, 428);
            this.dtgTodas.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No. Inicidencia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Técnico Asignado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dtgProceso
            // 
            this.dtgProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dtgProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProceso.Location = new System.Drawing.Point(3, 3);
            this.dtgProceso.Name = "dtgProceso";
            this.dtgProceso.Size = new System.Drawing.Size(830, 422);
            this.dtgProceso.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "No. Inicidencia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Técnico Asignado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dtgAsignadas
            // 
            this.dtgAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAsignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dtgAsignadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAsignadas.Location = new System.Drawing.Point(3, 3);
            this.dtgAsignadas.Name = "dtgAsignadas";
            this.dtgAsignadas.Size = new System.Drawing.Size(830, 422);
            this.dtgAsignadas.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "No. Inicidencia";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Técnico Asignado";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dtgPendientes
            // 
            this.dtgPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dtgPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPendientes.Location = new System.Drawing.Point(0, 0);
            this.dtgPendientes.Name = "dtgPendientes";
            this.dtgPendientes.Size = new System.Drawing.Size(836, 428);
            this.dtgPendientes.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "No. Inicidencia";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Técnico Asignado";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // frmConsultaIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmConsultaIncidencia";
            this.Text = "frmConsultaIncidencia";
            this.tabControl1.ResumeLayout(false);
            this.Liberadas.ResumeLayout(false);
            this.Proceso.ResumeLayout(false);
            this.Pendiente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLiberadas)).EndInit();
            this.Asignada.ResumeLayout(false);
            this.Todas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Liberadas;
        private System.Windows.Forms.TabPage Proceso;
        private System.Windows.Forms.TabPage Pendiente;
        private System.Windows.Forms.DataGridView dtgLiberadas;
        private System.Windows.Forms.TabPage Asignada;
        private System.Windows.Forms.TabPage Todas;
        private System.Windows.Forms.DataGridView dtgTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dtgProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dtgAsignadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView dtgPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}