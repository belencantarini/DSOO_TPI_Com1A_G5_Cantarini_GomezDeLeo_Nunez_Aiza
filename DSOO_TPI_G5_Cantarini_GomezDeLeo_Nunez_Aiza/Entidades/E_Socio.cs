using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TPI_G5_Cantarini_GomezDeLeo_Nunez_Aiza.Entidades
{
    public class E_Socio : E_Cliente
    {

        public int SocioID { get; set; }
        public string CarnetSocioID { get; set; }
        public string Estado { get; set; }
        public DateTime FechaVencimientoCuota { get; set; }
    }

}
