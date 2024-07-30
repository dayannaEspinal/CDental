using System; // Utiliza el espacio de nombres System
using System.Collections.Generic; // Utiliza el espacio de nombres System.Collections.Generic
using System.Linq; // Utiliza el espacio de nombres System.Linq
using System.Text; // Utiliza el espacio de nombres System.Text
using System.Threading.Tasks; // Utiliza el espacio de nombres System.Threading.Tasks

namespace CioDental1
{
    // Definición de la clase Citas
    public class Citas
    {
        
        public int Codigo { get; set; } // Propiedad para almacenar el código de la cita
        public string Nombre { get; set; } // Propiedad para almacenar el nombre del paciente
        public string Apellido { get; set; }  // Propiedad para almacenar el apellido del paciente

        // Constructor de la clase Citas
        public Citas(int codigo, string nombre, string apellido)
        {
            Codigo = codigo; // Inicializa la propiedad Codigo con el valor proporcionado
            Nombre = nombre; // Inicializa la propiedad Nombre con el valor proporcionado
            Apellido = apellido; // Inicializa la propiedad Apellido con el valor proporcionado
        }
    }
}
