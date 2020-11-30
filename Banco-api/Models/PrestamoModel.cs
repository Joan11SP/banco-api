
using System.ComponentModel.DataAnnotations;

namespace Banco_api.Models
{
    public class PrestamoModel
    {
        [Key]
        public int id_prestamo { get; set; }
        public float cantidad_prestamo { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public string fecha_c_pago { get; set; }
        public int cuotas { get; set; }
        public int id_cliente { get; set; }

    }
}
