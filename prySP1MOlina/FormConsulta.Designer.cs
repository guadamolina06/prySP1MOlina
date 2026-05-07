namespace prySP1MOlina
{
    partial class FormConsulta
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Label lblEspecialidad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidades.Location = new System.Drawing.Point(100, 17);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(200, 21);
            this.cmbEspecialidades.TabIndex = 1;
            this.cmbEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidades_SelectedIndexChanged);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.Location = new System.Drawing.Point(20, 60);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.Size = new System.Drawing.Size(360, 200);
            this.dgvMedicos.TabIndex = 2;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(20, 20);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 0;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // FormConsulta
            // 
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.dgvMedicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Médicos por Especialidad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
