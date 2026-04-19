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
    public partial class FormConsulta : Form
    {
        private ClinicaService service;

        public FormConsulta()
        {
            InitializeComponent();
            service = Program.Service;
            CargarEspecialidades();
        }

        private void CargarEspecialidades()
        {
            cmbEspecialidades.Items.Clear();
            var list = service.GetEspecialidades();
            //
            foreach (var e in list)
            {
                cmbEspecialidades.Items.Add(e);
            }

            if (cmbEspecialidades.Items.Count > 0)
                cmbEspecialidades.SelectedIndex = 0;
        }

        // Al cambiar la especialidad seleccionada, actualizar DataGridView
        private void cmbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            var esp = cmbEspecialidades.SelectedItem as Especialidad;
            if (esp == null)
            {
                dgvMedicos.DataSource = null;
                return;
            }

            var medicos = service.GetMedicosPorEspecialidad(esp.Numero);
            // Preparar lista para mostrar solo Matrícula y Nombre
            var list = medicos.Select(m => new { m.Matricula, m.Nombre }).ToList();
            dgvMedicos.DataSource = list;
        }
    }
}
