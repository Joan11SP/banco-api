using Banco_api.DataBase;
using Banco_api.Models;
using Banco_api.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Banco_api.Utilities;

namespace Banco_api.Controllers
{
    [Route("api/person/")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly SqlServer connection;
        private PersonQuery query = new PersonQuery();
        Logs log = new Logs();
        Encrypt encrypt = new Encrypt();
        public PersonController(SqlServer connection)
        {
            this.connection = connection;
        }
        [HttpPost]
        [Route("create-person")]
        public object create_person(PersonModel person)
        {
            int result;
            if (person.name_client !=null && person.city_client !=null) {
                result = query.create(person, connection);

                if (result == 1) {
                    return new { mensaje = "Guardado Correctamente" };
                }
                else
                {
                    return new { mensaje = "Ha ocurrido un error" };
                }
            }
            else
            {
                return new { mensaje = "Faltan datos" };
            }
        }
        [HttpPost]
        [Route("find")]
        public IEnumerable<PersonModel> find() {
            return connection.cliente;
        }
        [HttpPost]
        [Route("consulta-cuentas-propias")]
        public object consulta_cuentas(ConsultaCuentaModel consulta)
        {
            List<CuentasModel> cuentasModel = new List<CuentasModel>();
            DbDataReader result = null;
            try
            {                
                result = query.consultaCuentasPropias(consulta, connection);
               
            } catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                log.logger(e.Message);
                return new{ m = "Ha ocurrido una desgracia",ok = 0 };
            }

            if (result.HasRows) {
                while (result.Read())
                {
                    cuentasModel.Add(new CuentasModel
                    {
                        name_client = result["name_client"].ToString(),
                        saldo = (double)result["saldo"],
                        number_account = (int)result["number_account"],
                        type_account = (int)result["type_account"]
                    }

                    );
                }
                string str = string.Join(',',cuentasModel);
                var res = encrypt.GetMD5(str);
                return new { m = "satifactorio", ok = 1, data = res };
            }
            else
            {
                return new { m = "No existe", ok = 0 };
            }
        }
    }
}
