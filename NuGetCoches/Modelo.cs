using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetCoches
{

    [Table("Modelos")]

    public class Modelo
    {
        [Key]
        [Column("IdModelo")]
        public int IdModelo { get; set; }
        [Column("NombreModelo")]
        public String NombreModelo { get; set; }
        [Column("IdMarca")]
        public int IdMarca { get; set; }
    }

}
