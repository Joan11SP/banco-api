using System.ComponentModel.DataAnnotations;

namespace Banco_api.Models
{
    public class CuentaModel
    {
        [Key]
        public int id_deposito { get; set; }
        public int number_account { get; set; }
        public float saldo { get; set; }
        public int id_cliente { get; set; }
        public int id_sucursal { get; set; }
        


    }
}
