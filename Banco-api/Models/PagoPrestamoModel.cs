using System.ComponentModel.DataAnnotations;

namespace Banco_api.Models
{
    public class PagoPrestamoModel
    {
        [Key]
        public int id_pago { get; set; }
        public float cantidad_pago { get; set; }
        public string fecha_pago { get; set; }
        public int dias_retraso { get; set; }
        public int id_prestamo { get; set; }

    }
}
