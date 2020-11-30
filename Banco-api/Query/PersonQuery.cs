using Banco_api.DataBase;
using Banco_api.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Banco_api.Query
{
    public class PersonQuery
    {
        public int create(PersonModel person,SqlServer connection)
        {
            connection.cliente.Add(person);
            int result = connection.SaveChanges();
            return result;
        }
        public DbDataReader consultaCuentasPropias(ConsultaCuentaModel consulta,SqlServer sql)
        {
            var com = sql.Database.GetDbConnection().CreateCommand();
            com.CommandText = "exec ConsultaCuentas @Cliente = '"+ consulta.id_cliente + "', @Costo ='"+ consulta.costo + "'";
            sql.Database.OpenConnection();
            DbDataReader result = com.ExecuteReader();
            
            return result;  
        }
    }
}
