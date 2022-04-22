using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetCoches
{


    [Table("Versiones")]

    public class Version
    {
        [Key]
        [Column("IdVersion")]
        public int IdVersion { get; set; }
        [Column("Nombre")]
        public String Nombre { get; set; }
        [Column("Descripcion")]
        public String Descripcion { get; set; }
        [Column("Precio")]
        public int Precio { get; set; }
        [Column("IdMarca")]
        public int IdMarca { get; set; }
        [Column("IdModelo")]
        public int IdModelo { get; set; }
        [Column("Unidades")]
        public int Unidades { get; set; }
    }
}
