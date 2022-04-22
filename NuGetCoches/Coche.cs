using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetCoches
{
    [Table("Coches")]
    public class Coche
    {
        [Key]
        [Column("idCoche")]
        public int IdCoche { get; set; }
        [Column("idVendedor")]
        public int IdVendedor { get; set; }
        [Column("IdVersion")]
        public int IdVersion { get; set; }
        [Column("Nombre")]
        public String Nombre { get; set; }
        [Column("Descripcion")]
        public String Descripcion { get; set; }
        [Column("Precio")]
        public int Precio { get; set; }
        [Column("Foto1")]
        public String Foto1 { get; set; }
        [Column("Foto2")]
        public String Foto2 { get; set; }
        [Column("Foto3")]
        public String Foto3 { get; set; }
    }
}
