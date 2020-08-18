using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tienda_api.Models
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_empleado { get; set; }

        public String Nombre { get; set; }
        public String Numero_documento { get; set; }
        public String Genero { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public int ID_cargo { get; set; }
    }
}
