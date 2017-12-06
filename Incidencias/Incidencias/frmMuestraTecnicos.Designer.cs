namespace Incidencias
{
    partial class frmMuestraTecnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuestraTecnicos));
            this.dtgTecnicos = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTecnicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTecnicos
            // 
            this.dtgTecnicos.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dtgTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTecnicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.certific});
            this.dtgTecnicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgTecnicos.Location = new System.Drawing.Point(0, 0);
            this.dtgTecnicos.Name = "dtgTecnicos";
            this.dtgTecnicos.Size = new System.Drawing.Size(439, 435);
            this.dtgTecnicos.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Habilidades";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Certificaciones";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // certific
            // 
            this.certific.HeaderText = "No. Incidencias Asignadas";
            this.certific.Name = "certific";
            this.certific.ReadOnly = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(162, 441);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(109, 27);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.toolTip1.SetToolTip(this.btnRegresar, "Regresará a la ventana anterior");
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(-90, 474);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(636, 32);
            this.textBox2.TabIndex = 42;
            // 
            // frmMuestraTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 503);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtgTecnicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMuestraTecnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMuestraTecnicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTecnicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTecnicos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn certific;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox2;
    }
}