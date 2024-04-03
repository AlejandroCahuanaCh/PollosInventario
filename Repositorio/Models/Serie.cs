using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class Serie
    {
        public Serie()
        {
            Comprobantes = new HashSet<Comprobante>();
        }

        public int Idserie { get; set; }
        public int Identidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public int IdtipoComprobante { get; set; }
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual Entidad IdentidadNavigation { get; set; } = null!;
        public virtual TipoComprobante IdtipoComprobanteNavigation { get; set; } = null!;
        public virtual ICollection<Comprobante> Comprobantes { get; set; }
    }
}
