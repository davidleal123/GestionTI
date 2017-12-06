namespace Incidencias
{
    partial class frmTerminaIncidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminaIncidencia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTerminaIncidencia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLiberarIncidencia = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(443, 215);
            this.dataGridView1.TabIndex = 0;
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
            // Column4
            // 
            this.Column4.HeaderText = "Equipo";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Departamento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Location = new System.Drawing.Point(14, 234);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(195, 21);
            this.cmbIncidencia.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Número de Incidencia:";
            // 
            // btnTerminaIncidencia
            // 
            this.btnTerminaIncidencia.Location = new System.Drawing.Point(293, 234);
            this.btnTerminaIncidencia.Name = "btnTerminaIncidencia";
            this.btnTerminaIncidencia.Size = new System.Drawing.Size(138, 29);
            this.btnTerminaIncidencia.TabIndex = 36;
            this.btnTerminaIncidencia.Text = "Terminar Incidencia";
            this.toolTip1.SetToolTip(this.btnTerminaIncidencia, "Finalizará la incidencia levantada");
            this.btnTerminaIncidencia.UseVisualStyleBackColor = true;
            this.btnTerminaIncidencia.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 49);
            this.button2.TabIndex = 37;
            this.button2.Text = "Regresar";
            this.toolTip1.SetToolTip(this.button2, "Regresará a la ventana anterior");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLiberarIncidencia
            // 
            this.btnLiberarIncidencia.Location = new System.Drawing.Point(291, 294);
            this.btnLiberarIncidencia.Name = "btnLiberarIncidencia";
            this.btnLiberarIncidencia.Size = new System.Drawing.Size(138, 29);
            this.btnLiberarIncidencia.TabIndex = 38;
            this.btnLiberarIncidencia.Text = "Liberar Incidencia";
            this.toolTip1.SetToolTip(this.btnLiberarIncidencia, "Liberará el servicio proporcionado");
            this.btnLiberarIncidencia.UseVisualStyleBackColor = true;
            this.btnLiberarIncidencia.Click += new System.EventHandler(this.btnLiberarIncidencia_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(-87, 341);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(636, 32);
            this.textBox2.TabIndex = 42;
            // 
            // frmTerminaIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 372);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnLiberarIncidencia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTerminaIncidencia);
            this.Controls.Add(this.cmbIncidencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTerminaIncidencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTerminaIncidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTerminaIncidencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLiberarIncidencia;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox2;
    }
}