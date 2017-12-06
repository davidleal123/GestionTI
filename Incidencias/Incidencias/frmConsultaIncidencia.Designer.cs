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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaIncidencia));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Todas = new System.Windows.Forms.TabPage();
            this.dtgTodas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendiente = new System.Windows.Forms.TabPage();
            this.dtgPendientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignada = new System.Windows.Forms.TabPage();
            this.dtgAsignadas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso = new System.Windows.Forms.TabPage();
            this.dtgProceso = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terminadas = new System.Windows.Forms.TabPage();
            this.dtgTerminadas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liberadas = new System.Windows.Forms.TabPage();
            this.dtgLiberadas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluadas = new System.Windows.Forms.TabPage();
            this.dtgEvaluadas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Todas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTodas)).BeginInit();
            this.Pendiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPendientes)).BeginInit();
            this.Asignada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsignadas)).BeginInit();
            this.Proceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProceso)).BeginInit();
            this.Terminadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTerminadas)).BeginInit();
            this.Liberadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLiberadas)).BeginInit();
            this.Evaluadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvaluadas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Todas);
            this.tabControl1.Controls.Add(this.Pendiente);
            this.tabControl1.Controls.Add(this.Asignada);
            this.tabControl1.Controls.Add(this.Proceso);
            this.tabControl1.Controls.Add(this.Terminadas);
            this.tabControl1.Controls.Add(this.Liberadas);
            this.tabControl1.Controls.Add(this.Evaluadas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // Todas
            // 
            this.Todas.Controls.Add(this.dtgTodas);
            this.Todas.Location = new System.Drawing.Point(4, 22);
            this.Todas.Name = "Todas";
            this.Todas.Size = new System.Drawing.Size(528, 410);
            this.Todas.TabIndex = 4;
            this.Todas.Text = "Todas";
            this.Todas.UseVisualStyleBackColor = true;
            // 
            // dtgTodas
            // 
            this.dtgTodas.AllowUserToAddRows = false;
            this.dtgTodas.AllowUserToDeleteRows = false;
            this.dtgTodas.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dtgTodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTodas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5});
            this.dtgTodas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTodas.Location = new System.Drawing.Point(0, 0);
            this.dtgTodas.Name = "dtgTodas";
            this.dtgTodas.ReadOnly = true;
            this.dtgTodas.Size = new System.Drawing.Size(528, 410);
            this.dtgTodas.TabIndex = 1;
            this.dtgTodas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTodas_CellContentClick);
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
            // Column5
            // 
            this.Column5.HeaderText = "Estatus";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Pendiente
            // 
            this.Pendiente.Controls.Add(this.dtgPendientes);
            this.Pendiente.Location = new System.Drawing.Point(4, 22);
            this.Pendiente.Name = "Pendiente";
            this.Pendiente.Size = new System.Drawing.Size(528, 410);
            this.Pendiente.TabIndex = 2;
            this.Pendiente.Text = "Pendientes";
            this.Pendiente.UseVisualStyleBackColor = true;
            // 
            // dtgPendientes
            // 
            this.dtgPendientes.AllowUserToAddRows = false;
            this.dtgPendientes.AllowUserToDeleteRows = false;
            this.dtgPendientes.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dtgPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dtgPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPendientes.Location = new System.Drawing.Point(0, 0);
            this.dtgPendientes.Name = "dtgPendientes";
            this.dtgPendientes.ReadOnly = true;
            this.dtgPendientes.Size = new System.Drawing.Size(528, 410);
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
            // Asignada
            // 
            this.Asignada.Controls.Add(this.dtgAsignadas);
            this.Asignada.Location = new System.Drawing.Point(4, 22);
            this.Asignada.Name = "Asignada";
            this.Asignada.Padding = new System.Windows.Forms.Padding(3);
            this.Asignada.Size = new System.Drawing.Size(528, 410);
            this.Asignada.TabIndex = 3;
            this.Asignada.Text = "Asignadas";
            this.Asignada.UseVisualStyleBackColor = true;
            // 
            // dtgAsignadas
            // 
            this.dtgAsignadas.AllowUserToAddRows = false;
            this.dtgAsignadas.AllowUserToDeleteRows = false;
            this.dtgAsignadas.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dtgAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAsignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dtgAsignadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAsignadas.Location = new System.Drawing.Point(3, 3);
            this.dtgAsignadas.Name = "dtgAsignadas";
            this.dtgAsignadas.ReadOnly = true;
            this.dtgAsignadas.Size = new System.Drawing.Size(522, 404);
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
            // Proceso
            // 
            this.Proceso.Controls.Add(this.dtgProceso);
            this.Proceso.Location = new System.Drawing.Point(4, 22);
            this.Proceso.Name = "Proceso";
            this.Proceso.Padding = new System.Windows.Forms.Padding(3);
            this.Proceso.Size = new System.Drawing.Size(528, 410);
            this.Proceso.TabIndex = 1;
            this.Proceso.Text = "En Proceso";
            this.Proceso.UseVisualStyleBackColor = true;
            // 
            // dtgProceso
            // 
            this.dtgProceso.AllowUserToAddRows = false;
            this.dtgProceso.AllowUserToDeleteRows = false;
            this.dtgProceso.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dtgProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dtgProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProceso.Location = new System.Drawing.Point(3, 3);
            this.dtgProceso.Name = "dtgProceso";
            this.dtgProceso.ReadOnly = true;
            this.dtgProceso.Size = new System.Drawing.Size(522, 404);
            this.dtgProceso.TabIndex = 1;
            this.dtgProceso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProceso_CellContentClick);
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
            // Terminadas
            // 
            this.Terminadas.Controls.Add(this.dtgTerminadas);
            this.Terminadas.Location = new System.Drawing.Point(4, 22);
            this.Terminadas.Name = "Terminadas";
            this.Terminadas.Padding = new System.Windows.Forms.Padding(3);
            this.Terminadas.Size = new System.Drawing.Size(528, 410);
            this.Terminadas.TabIndex = 6;
            this.Terminadas.Text = "Terminadas";
            this.Terminadas.UseVisualStyleBackColor = true;
            // 
            // dtgTerminadas
            // 
            this.dtgTerminadas.AllowUserToAddRows = false;
            this.dtgTerminadas.AllowUserToDeleteRows = false;
            this.dtgTerminadas.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dtgTerminadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTerminadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.dtgTerminadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTerminadas.Location = new System.Drawing.Point(3, 3);
            this.dtgTerminadas.Name = "dtgTerminadas";
            this.dtgTerminadas.ReadOnly = true;
            this.dtgTerminadas.Size = new System.Drawing.Size(522, 404);
            this.dtgTerminadas.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "No. Inicidencia";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "Técnico Asignado";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // Liberadas
            // 
            this.Liberadas.Controls.Add(this.dtgLiberadas);
            this.Liberadas.Location = new System.Drawing.Point(4, 22);
            this.Liberadas.Name = "Liberadas";
            this.Liberadas.Padding = new System.Windows.Forms.Padding(3);
            this.Liberadas.Size = new System.Drawing.Size(528, 410);
            this.Liberadas.TabIndex = 0;
            this.Liberadas.Text = "Liberadas";
            this.Liberadas.UseVisualStyleBackColor = true;
            // 
            // dtgLiberadas
            // 
            this.dtgLiberadas.AllowUserToAddRows = false;
            this.dtgLiberadas.AllowUserToDeleteRows = false;
            this.dtgLiberadas.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dtgLiberadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLiberadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dtgLiberadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLiberadas.Location = new System.Drawing.Point(3, 3);
            this.dtgLiberadas.Name = "dtgLiberadas";
            this.dtgLiberadas.ReadOnly = true;
            this.dtgLiberadas.Size = new System.Drawing.Size(522, 404);
            this.dtgLiberadas.TabIndex = 0;
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
            // Evaluadas
            // 
            this.Evaluadas.Controls.Add(this.dtgEvaluadas);
            this.Evaluadas.Location = new System.Drawing.Point(4, 22);
            this.Evaluadas.Name = "Evaluadas";
            this.Evaluadas.Padding = new System.Windows.Forms.Padding(3);
            this.Evaluadas.Size = new System.Drawing.Size(528, 410);
            this.Evaluadas.TabIndex = 5;
            this.Evaluadas.Text = "Evaluadas";
            this.Evaluadas.UseVisualStyleBackColor = true;
            // 
            // dtgEvaluadas
            // 
            this.dtgEvaluadas.AllowUserToAddRows = false;
            this.dtgEvaluadas.AllowUserToDeleteRows = false;
            this.dtgEvaluadas.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dtgEvaluadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEvaluadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.Column6});
            this.dtgEvaluadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEvaluadas.Location = new System.Drawing.Point(3, 3);
            this.dtgEvaluadas.Name = "dtgEvaluadas";
            this.dtgEvaluadas.ReadOnly = true;
            this.dtgEvaluadas.Size = new System.Drawing.Size(522, 404);
            this.dtgEvaluadas.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "No. Inicidencia";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Técnico Asignado";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Calificación";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // frmConsultaIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 436);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaIncidencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConsultaIncidencia_Load);
            this.tabControl1.ResumeLayout(false);
            this.Todas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTodas)).EndInit();
            this.Pendiente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPendientes)).EndInit();
            this.Asignada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsignadas)).EndInit();
            this.Proceso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProceso)).EndInit();
            this.Terminadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTerminadas)).EndInit();
            this.Liberadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLiberadas)).EndInit();
            this.Evaluadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvaluadas)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage Evaluadas;
        private System.Windows.Forms.DataGridView dtgEvaluadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabPage Terminadas;
        private System.Windows.Forms.DataGridView dtgTerminadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}