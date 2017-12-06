namespace Incidencias
{
    partial class frmAsignaIncidencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignaIncidencia));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.cmbTiempoSolucion = new System.Windows.Forms.ComboBox();
            this.cmbTiempoAtencion = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inciasig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTecnicos = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(652, 480);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 26);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Regresar";
            this.toolTip1.SetToolTip(this.btnSalir, "Regresará a la ventana anterior");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(533, 480);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 26);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardará los datos ingresados");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incidencia,
            this.desc,
            this.dep,
            this.prio});
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(442, 351);
            this.dataGridView1.TabIndex = 27;
            this.toolTip1.SetToolTip(this.dataGridView1, "Muestra las incidencias sin tecnicos asignados");
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // incidencia
            // 
            this.incidencia.HeaderText = "No. Incidencia";
            this.incidencia.Name = "incidencia";
            this.incidencia.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripción";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // dep
            // 
            this.dep.HeaderText = "Departamento";
            this.dep.Name = "dep";
            this.dep.ReadOnly = true;
            // 
            // prio
            // 
            this.prio.HeaderText = "Prioridad";
            this.prio.Name = "prio";
            this.prio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Número de Incidencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Técnico Asignado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tiempo estimado de Atención:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tiempo estimado de Solución:";
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Location = new System.Drawing.Point(12, 432);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(195, 21);
            this.cmbIncidencia.TabIndex = 32;
            // 
            // cmbTiempoSolucion
            // 
            this.cmbTiempoSolucion.FormattingEnabled = true;
            this.cmbTiempoSolucion.Location = new System.Drawing.Point(248, 432);
            this.cmbTiempoSolucion.Name = "cmbTiempoSolucion";
            this.cmbTiempoSolucion.Size = new System.Drawing.Size(194, 21);
            this.cmbTiempoSolucion.TabIndex = 33;
            // 
            // cmbTiempoAtencion
            // 
            this.cmbTiempoAtencion.FormattingEnabled = true;
            this.cmbTiempoAtencion.Location = new System.Drawing.Point(13, 484);
            this.cmbTiempoAtencion.Name = "cmbTiempoAtencion";
            this.cmbTiempoAtencion.Size = new System.Drawing.Size(194, 21);
            this.cmbTiempoAtencion.TabIndex = 34;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.habilidades,
            this.inciasig});
            this.dataGridView2.Location = new System.Drawing.Point(448, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.Size = new System.Drawing.Size(346, 351);
            this.dataGridView2.TabIndex = 36;
            this.toolTip1.SetToolTip(this.dataGridView2, "Muestra los tecnicos en servicio disponibles");
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // habilidades
            // 
            this.habilidades.HeaderText = "Habilidades";
            this.habilidades.Name = "habilidades";
            this.habilidades.ReadOnly = true;
            // 
            // inciasig
            // 
            this.inciasig.HeaderText = "No. Incidencias Asignadas";
            this.inciasig.Name = "inciasig";
            this.inciasig.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Información de las Incidencias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Información de los Técnicos";
            // 
            // cmbTecnicos
            // 
            this.cmbTecnicos.FormattingEnabled = true;
            this.cmbTecnicos.Location = new System.Drawing.Point(248, 484);
            this.cmbTecnicos.Name = "cmbTecnicos";
            this.cmbTecnicos.Size = new System.Drawing.Size(194, 21);
            this.cmbTecnicos.TabIndex = 39;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Redes"});
            this.cmbTipo.Location = new System.Drawing.Point(464, 433);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(194, 21);
            this.cmbTipo.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tipo de Incidencia:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(-9, -1);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(803, 32);
            this.textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(-9, 512);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(803, 32);
            this.textBox1.TabIndex = 43;
            // 
            // frmAsignaIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 540);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTecnicos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmbTiempoAtencion);
            this.Controls.Add(this.cmbTiempoSolucion);
            this.Controls.Add(this.cmbIncidencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsignaIncidencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAsignaIncidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn prio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.ComboBox cmbTiempoSolucion;
        private System.Windows.Forms.ComboBox cmbTiempoAtencion;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn habilidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn inciasig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTecnicos;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}