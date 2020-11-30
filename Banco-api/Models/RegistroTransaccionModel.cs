using System.ComponentModel.DataAnnotations;

namespace Banco_api.Models
{
    public class RegistroTransaccionModel
    {
        [Key]
        public int id_registros { get; set; }
        public int tipo { get; set; }
        public float cantidad { get; set; }
        public int id_cliente { get; set; }
        public int id_deposito { get; set; }
    }
}
