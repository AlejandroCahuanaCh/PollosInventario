using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Entidads = new HashSet<Entidad>();
        }

        public int Idtipodocumento { get; set; }
        public string Descripcion { get; set; } = null!;
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual ICollection<Entidad> Entidads { get; set; }
    }
}
