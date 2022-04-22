using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetCoches
{
    [Table("Marcas")]

    public class Marca
    {
        [Key]
        [Column("IdMarca")]
        public int IdMarca { get; set; }
        [Column("NombreMarca")]
        public String NombreMarca { get; set; }
        [Column("Imagen")]
        public String Imagen { get; set; }
    }
}
