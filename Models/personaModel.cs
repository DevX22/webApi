using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("persona")]
    public class personaModel
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string tipoDocumento { get; set; }
        [MaxLength(12)]
        public string numeroDocumento { get; set; }
        [MaxLength(9)]
        public string celular { get; set; }
        public string correo { get; set; }
        public DateTime MyProperty { get; set; }
    }
}
