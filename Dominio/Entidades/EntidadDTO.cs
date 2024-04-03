using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class EntidadDTO
    {
        public int Identidad { get; set; }
        public int Idtipodocumento { get; set; }
        public string NumeroDocumento { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string? Direccion { get; set; }
        public int Tipo { get; set; }
        public string DescripcionTipo { get; set; } = string.Empty!;
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }
    }
}
