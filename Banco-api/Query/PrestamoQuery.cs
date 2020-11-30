using Banco_api.DataBase;
using Banco_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Banco_api.Query
{
    public class PrestamoQuery
    {
        public int pago(PagoPrestamoModel pagoPrestamo,SqlServer sqlServer)
        {
            var cantidad =new SqlParameter("@Cant", pagoPrestamo.cantidad_pago);
            var id_prestamo = new SqlParameter("@Prestamo", pagoPrestamo.id_prestamo);
            int result = sqlServer.Database.ExecuteSqlRaw("exec Pago @Cant, @Prestamo",cantidad,id_prestamo);
            return result;

        }
    }
}
