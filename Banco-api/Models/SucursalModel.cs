
using System.ComponentModel.DataAnnotations;

namespace Banco_api.Models
{
    public class SucursalModel
    {
        [Key]
        public int id_sucursal { get; set; }
        public string name_sucursal { get; set; }
        public string city_sucursal { get; set; }
        public float activo { get; set; }  
    }
}
