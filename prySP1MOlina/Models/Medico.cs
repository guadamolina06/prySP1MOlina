using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySP1MOlina.Models
{
    // Clase que representa un médico
    public class Medico
    {
        // Matrícula (clave única)
        public int Matricula { get; set; }

        // Nombre del médico
        public string Nombre { get; set; }

        // Número de especialidad (relación)
        public int NumeroEspecialidad { get; set; }
    }
}