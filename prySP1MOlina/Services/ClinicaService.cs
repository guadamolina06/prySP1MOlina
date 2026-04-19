using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prySP1MOlina.Models;

namespace prySP1MOlina.Services
{
    // Servicio que maneja la lógica de la clínica (listas en memoria)
    public class ClinicaService
    {
        // Listas en memoria para almacenar especialidades y médicos
        private List<Especialidad> especialidades;
        private List<Medico> medicos;

        // Constructor: inicializa listas vacías
        public ClinicaService()
        {
            especialidades = new List<Especialidad>();
            medicos = new List<Medico>();
        }

        // Obtener todas las especialidades
        public List<Especialidad> GetEspecialidades()
        {
            return especialidades;
        }

        // Obtener todos los médicos
        public List<Medico> GetMedicos()
        {
            return medicos;
        }

        // Agregar una especialidad con validaciones
        public bool AgregarEspecialidad(Especialidad e)
        {
            // Validar no vacío
            if (e == null || string.IsNullOrWhiteSpace(e.Nombre))
            {
                MessageBox.Show("La especialidad y su nombre no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar número único
            if (especialidades.Any(x => x.Numero == e.Numero))
            {
                MessageBox.Show("El número de especialidad ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Agregar
            especialidades.Add(e);
            return true;
        }

        // Agregar un médico con validaciones
        public bool AgregarMedico(Medico m)
        {
            // Validar no vacío
            if (m == null || string.IsNullOrWhiteSpace(m.Nombre))
            {
                MessageBox.Show("El médico y su nombre no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar matrícula única
            if (medicos.Any(x => x.Matricula == m.Matricula))
            {
                MessageBox.Show("La matrícula ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar existencia de la especialidad
            if (!especialidades.Any(x => x.Numero == m.NumeroEspecialidad))
            {
                MessageBox.Show("La especialidad seleccionada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            medicos.Add(m);
            return true;
        }

        // Obtener médicos por número de especialidad
        public List<Medico> GetMedicosPorEspecialidad(int numeroEspecialidad)
        {
            return medicos.Where(x => x.NumeroEspecialidad == numeroEspecialidad).ToList();
        }
    }
}