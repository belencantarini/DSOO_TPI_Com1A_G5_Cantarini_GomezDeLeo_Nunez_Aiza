using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace G5_TPI_ClubDeportivo.Entidades
{
    public class E_Socio : E_Cliente
    {
        public int SocioID { get; set; }
        public string CarnetSocioID { get; set; }
        public string Estado { get; set; }
        public DateTime FechaVencimientoCuota { get; set; }
    }

}