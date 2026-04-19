using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prySP1MOlina.Models;
using prySP1MOlina.Services;

namespace prySP1MOlina
{
    public partial class FormMedicos : Form
    {
        private ClinicaService service;

        public FormMedicos()
        {
            InitializeComponent();
            service = Program.Service;
            CargarEspecialidades();
        }

        // Cargar especialidades en el ComboBox
        private void CargarEspecialidades()
        {
            cmbEspecialidad.Items.Clear();
            var list = service.GetEspecialidades();
            foreach (var e in list)
            {
                cmbEspecialidad.Items.Add(e);
            }

            if (cmbEspecialidad.Items.Count > 0)
                cmbEspecialidad.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int matricula;
            if (!int.TryParse(txtMatricula.Text, out matricula))
            {
                MessageBox.Show("Matrícula debe ser un entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var esp = cmbEspecialidad.SelectedItem as Especialidad;
            if (esp == null)
            {
                MessageBox.Show("Especialidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var med = new Medico { Matricula = matricula, Nombre = txtNombre.Text.Trim(), NumeroEspecialidad = esp.Numero };
            if (service.AgregarMedico(med))
            {
                MessageBox.Show("Médico guardado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatricula.Clear();
                txtNombre.Clear();
                CargarEspecialidades();
            }
        }
    }
}
