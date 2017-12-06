namespace Incidencias
{
    partial class frmEvaluarIncidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvaluarIncidencia));
            this.dtgEvaluar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaTerminacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTiempoPrometido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTiempoTerminado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCalificacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvaluar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEvaluar
            // 
            this.dtgEvaluar.AllowUserToAddRows = false;
            this.dtgEvaluar.AllowUserToDeleteRows = false;
            this.dtgEvaluar.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dtgEvaluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEvaluar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgEvaluar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgEvaluar.Location = new System.Drawing.Point(0, 0);
            this.dtgEvaluar.Name = "dtgEvaluar";
            this.dtgEvaluar.ReadOnly = true;
            this.dtgEvaluar.Size = new System.Drawing.Size(885, 376);
            this.dtgEvaluar.TabIndex = 0;
            this.dtgEvaluar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEvaluar_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No. Incidencia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Departamento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tecnico Asignado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de Inicio";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(236, 400);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(181, 20);
            this.txtFechaInicio.TabIndex = 2;
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Location = new System.Drawing.Point(12, 400);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(195, 21);
            this.cmbIncidencia.TabIndex = 34;
            this.cmbIncidencia.SelectedIndexChanged += new System.EventHandler(this.cmbIncidencia_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Número de Incidencia:";
            // 
            // txtFechaTerminacion
            // 
            this.txtFechaTerminacion.Location = new System.Drawing.Point(236, 461);
            this.txtFechaTerminacion.Name = "txtFechaTerminacion";
            this.txtFechaTerminacion.Size = new System.Drawing.Size(181, 20);
            this.txtFechaTerminacion.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha de Terminación";
            // 
            // txtTiempoPrometido
            // 
            this.txtTiempoPrometido.Location = new System.Drawing.Point(466, 399);
            this.txtTiempoPrometido.Name = "txtTiempoPrometido";
            this.txtTiempoPrometido.Size = new System.Drawing.Size(181, 20);
            this.txtTiempoPrometido.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tiempo Prometido";
            // 
            // txtTiempoTerminado
            // 
            this.txtTiempoTerminado.Location = new System.Drawing.Point(466, 461);
            this.txtTiempoTerminado.Name = "txtTiempoTerminado";
            this.txtTiempoTerminado.Size = new System.Drawing.Size(181, 20);
            this.txtTiempoTerminado.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tiempo Tardado";
            // 
            // cmbCalificacion
            // 
            this.cmbCalificacion.FormattingEnabled = true;
            this.cmbCalificacion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCalificacion.Location = new System.Drawing.Point(735, 398);
            this.cmbCalificacion.Name = "cmbCalificacion";
            this.cmbCalificacion.Size = new System.Drawing.Size(111, 21);
            this.cmbCalificacion.TabIndex = 42;
            this.cmbCalificacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(733, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Calificación (Estrellas)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(736, 449);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(138, 43);
            this.btnEvaluar.TabIndex = 43;
            this.btnEvaluar.Text = "Evaluar Incidencia";
            this.toolTip1.SetToolTip(this.btnEvaluar, "Procederá a la encuenta de evaluación del servicio");
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 449);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(138, 43);
            this.btnRegresar.TabIndex = 44;
            this.btnRegresar.Text = "Regresar";
            this.toolTip1.SetToolTip(this.btnRegresar, "Regresará a la ventana anterior");
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(0, 498);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(895, 32);
            this.textBox2.TabIndex = 45;
            // 
            // frmEvaluarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 529);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.cmbCalificacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTiempoTerminado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTiempoPrometido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFechaTerminacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIncidencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgEvaluar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEvaluarIncidencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEvaluarIncidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvaluar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEvaluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaTerminacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTiempoPrometido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTiempoTerminado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCalificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox2;
    }
}