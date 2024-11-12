using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5_TPI_ClubDeportivo.Entidades
{
    internal class E_Pago
    {
        public int PagoID { get; set; }
        public int ClienteID { get; set; }
        public int MembresiaID { get; set; }
        public int ActividadID { get; set; }
        public double Monto { get; set; }
        public string MetodoPago { get; set; }
        public int Cuotas { get; set; }
        public DateTime FechaPago { get; set; } 
    }
}
