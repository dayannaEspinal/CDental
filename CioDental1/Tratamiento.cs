using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;
using System.Threading.Tasks; 

namespace CioDental1 
{
    public class Tratamiento 
    {
        
        public int Codigo { get; set; } 
        public string Nombre { get; set; } 
        public int Precio { get; set; } 

        
        public Tratamiento(int codigo, string nombre, int precio) 
        {
            Codigo = codigo; 
            Nombre = nombre; 
            Precio = precio; 
    }    }
}
