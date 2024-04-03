using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class TipoMovimiento
    {
        public TipoMovimiento()
        {
            Movimientos = new HashSet<Movimiento>();
        }

        public int Idtipomovimiento { get; set; }
        public string Descripcion { get; set; } = null!;
        public byte Tipo { get; set; }
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}
