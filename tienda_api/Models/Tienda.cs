using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tienda_api.Models
{
    public class Tienda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_tienda { get; set; }
        public String nombre { get; set; }
        public String direccion { get; set; }
        public Decimal telefono { get; set; }
    }
}
