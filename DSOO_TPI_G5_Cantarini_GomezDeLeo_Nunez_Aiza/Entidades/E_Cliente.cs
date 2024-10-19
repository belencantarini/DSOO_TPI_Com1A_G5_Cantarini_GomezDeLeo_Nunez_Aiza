using DSOO_TPI_G5_Cantarini_GomezDeLeo_Nunez_Aiza.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TPI_G5_Cantarini_GomezDeLeo_Nunez_Aiza.Entidades
{
    public class E_Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool AptoFisico { get; set; }
    }
}