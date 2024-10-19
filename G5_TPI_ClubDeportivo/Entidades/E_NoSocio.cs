using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace G5_TPI_ClubDeportivo.Entidades
{
    public class E_NoSocio : E_Cliente
    {
        public int NoSocioID { get; set; }
    }
}
