using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetCoches
{


    [Table("usuarios")]

    public class Usuario
    {
        [Key]
        [Column("UserID")]
        public int IdUsuario { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("Contraseña")]
        public string Contraseña { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Imagen")]
        public string Imagen { get; set; }

    }
}
