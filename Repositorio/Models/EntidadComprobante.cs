using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class EntidadComprobante
    {
        public int Identidadcompronte { get; set; }
        public int Idcomprobante { get; set; }
        public int Idtipoentidad { get; set; }
        public int Identidad { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string NumeroDocumento { get; set; } = null!;
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual Comprobante IdcomprobanteNavigation { get; set; } = null!;
        public virtual Entidad IdentidadNavigation { get; set; } = null!;
    }
}
