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
    public partial class FormEspecialidades : Form
    {
        private ClinicaService service;

        public FormEspecialidades()
        {
            InitializeComponent();
            service = Program.Service; // usar servicio compartido
        }

        // Click en guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (string.IsNullOrWhiteSpace(txtNumero.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numero;
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("Número debe ser un entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var esp = new Especialidad { Numero = numero, Nombre = txtNombre.Text.Trim() };
            if (service.AgregarEspecialidad(esp))
            {
                MessageBox.Show("Especialidad guardada.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar campos
                txtNumero.Clear();
                txtNombre.Clear();
            }
        }

        private void FormEspecialidades_Load(object sender, EventArgs e)
        {

        }
    }
}
