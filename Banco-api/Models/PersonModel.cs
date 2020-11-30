using System.ComponentModel.DataAnnotations;

namespace Banco_api.Models
{
    public class PersonModel
    {
        [Key]
        public int id_cliente { get; set; }
        public string name_client { get; set; }
        public string street { get; set; }
        public string city_client { get; set; }
    }
    public class ConsultaCuentaModel
    {
        public int id_cliente { get; set; }
        public string costo { get; set; }
    }
    public class CuentasModel
    {
        [Key]
        public int id_cuenta {get;set;}
        public string name_client { get; set; }
        public int type_account { get; set; }
        public double saldo { get; set; }
        public int number_account { get; set; }
        
    }
    
}
