using Dominio.Entidades;

namespace Repositorio.Interfaces.Entidad
{
    public interface IEntidadRepo
    {
        EntidadDTO ObtenerEntidadporId(int identidad);
        EntidadDTO ObtenerEntidadporDocumento(string documento);
        int GuardarEntidad(EntidadDTO entidad);
        int ActualizarEntidad(EntidadDTO entidad);
        int DesactivarEntidad(int identidad);

    }
}
