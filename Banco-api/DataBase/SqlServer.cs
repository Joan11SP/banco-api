using Banco_api.Models;
using Microsoft.EntityFrameworkCore;
namespace Banco_api.DataBase
{
    public class SqlServer : DbContext
    {
        public SqlServer(DbContextOptions<SqlServer> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<PersonModel> cliente {get;set;}
        public DbSet<CuentaModel> deposito { get; set; }
        public DbSet<RegistroTransaccionModel> registros { get; set; }
        public DbSet<PagoPrestamoModel> pago_prestamo { get; set; }
        public DbSet<PrestamoModel> prestamo { get; set; }
        public DbSet<SucursalModel> sucursal { get; set; }
        public DbSet<CuentasModel> cuenta { get; set; }
        
    }
}
