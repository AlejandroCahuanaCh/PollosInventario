using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class TipoComprobante
    {
        public TipoComprobante()
        {
            Series = new HashSet<Serie>();
        }

        public int Idtipocomprobante { get; set; }
        public string Descripcion { get; set; } = null!;
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual ICollection<Serie> Series { get; set; }
    }
}
