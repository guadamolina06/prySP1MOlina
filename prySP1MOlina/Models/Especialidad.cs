using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySP1MOlina.Models
{
    // Clase que representa una especialidad
    public class Especialidad
    {
        // Número (clave única)
        public int Numero { get; set; }

        // Nombre de la especialidad
        public string Nombre { get; set; }

        public override string ToString()
        {
            // Mostrar el nombre en ComboBox por defecto
            return Nombre;
        }
    }
}