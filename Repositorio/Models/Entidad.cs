using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class Entidad
    {
        public Entidad()
        {
            EntidadComprobantes = new HashSet<EntidadComprobante>();
            Series = new HashSet<Serie>();
        }

        public int Identidad { get; set; }
        public int Idtipodocumento { get; set; }
        public string NumeroDocumento { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public string? Direccion { get; set; }
        public int Tipo { get; set; }
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual TipoDocumento IdtipodocumentoNavigation { get; set; } = null!;
        public virtual ICollection<EntidadComprobante> EntidadComprobantes { get; set; }
        public virtual ICollection<Serie> Series { get; set; }
    }
}
