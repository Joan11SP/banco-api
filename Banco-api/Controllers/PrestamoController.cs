using Banco_api.DataBase;
using Banco_api.Models;
using Banco_api.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Banco_api.Controllers
{
    [Route("api/prestamo/")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        private readonly SqlServer sql;
        PrestamoQuery prestamoQuery = new PrestamoQuery();
        public PrestamoController(SqlServer sql)
        {
            this.sql = sql;
        }
        [HttpPost]
        [Route("pago-prestamo")]
        public object Post(PagoPrestamoModel pagoPrestamo)
        {
            int result;
            Console.WriteLine(pagoPrestamo.cantidad_pago);
            result = prestamoQuery.pago(pagoPrestamo, sql);
            return new {result};
        }
    }
}
