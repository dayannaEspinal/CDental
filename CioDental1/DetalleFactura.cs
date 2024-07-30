using System; // Utiliza el espacio de nombres System
using System.Collections.Generic; // Utiliza el espacio de nombres System.Collections.Generic
using System.Linq; // Utiliza el espacio de nombres System.Linq
using System.Text; // Utiliza el espacio de nombres System.Text
using System.Threading.Tasks; // Utiliza el espacio de nombres System.Threading.Tasks

namespace CioDental1 // Define el espacio de nombres CioDental1
{
    public class DetalleFactura // Define la clase DetalleFactura
    {
        public int IdFacDet { get; set; } // Define la propiedad IdFacDet con un getter y setter
        public int IdPro { get; set; } // Define la propiedad IdPro con un getter y setter
        public int IdTra { get; set; } // Define la propiedad IdTra con un getter y setter
        public int PrePro { get; set; } // Define la propiedad PrePro con un getter y setter
        public int PreTra { get; set; } // Define la propiedad PreTra con un getter y setter

        public DetalleFactura(int idFacDet, int idPro, string nomPro, int idTra, string nomTra, int prePro, int canPro, int totPro, int preTra) // Constructor de la clase DetalleFactura
        {
            IdFacDet = idFacDet; // Asigna el valor del parámetro idFacDet a la propiedad IdFacDet
            IdPro = idPro; // Asigna el valor del parámetro idPro a la propiedad IdPro
            IdTra = idTra; // Asigna el valor del parámetro idTra a la propiedad IdTra
            PrePro = prePro; // Asigna el valor del parámetro prePro a la propiedad PrePro
            PreTra = preTra; // Asigna el valor del parámetro preTra a la propiedad PreTra
        }
    }
}
