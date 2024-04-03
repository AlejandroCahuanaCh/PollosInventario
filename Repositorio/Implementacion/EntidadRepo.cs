using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces.Entidad;
using Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Implementacion
{
    public class EntidadRepo : IEntidadRepo
    {
        //prueba de git 123
        readonly InventariosContext ctx;
        public int ActualizarEntidad(EntidadDTO entidad)
        {
            try
            {
                Entidad EntidadEditada = ctx.Entidads
                                            .Where(e => e.Identidad == entidad.Identidad)
                                            .First();

                EntidadEditada.Idtipodocumento = entidad.Idtipodocumento;
                EntidadEditada.NumeroDocumento = entidad.NumeroDocumento;
                ///
                EntidadEditada.RazonSocial = entidad.RazonSocial;
                EntidadEditada.Direccion = entidad.Direccion;
                EntidadEditada.Tipo = entidad.Tipo;
                
                ///
                EntidadEditada.RazonSocial = entidad.RazonSocial;
                EntidadEditada.LogUsuarioModificacion = entidad.LogUsuarioModificacion;
                EntidadEditada.LogFechaModificacion = DateTime.Now;

                EntidadEditada.LogEstado = entidad.LogEstado;

                ctx.SaveChanges();

                return entidad.Identidad;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DesactivarEntidad(int identidad)
        {
            try
            {
                Entidad EntidadObtenida = ctx.Entidads
                                           .Where(e => e.Identidad == identidad)
                                           .First();

                if (EntidadObtenida != null)
                {
                    EntidadDTO entidadDTO = new EntidadDTO
                    {
                        LogEstado = 0 //desactivar era eso???

                    };

                    return entidadDTO.LogEstado;
                }
                else
                {
                    return identidad;
                }
            }
            catch (Exception ex)
            {
                throw ex; // Maneja la excepción según sea necesario
            }
        }

        public int GuardarEntidad(EntidadDTO entidad)//nueva entidad???
        {
            try
            {
                // Crea una nueva instancia de la entidad a partir de los datos del DTO
                Entidad EntidadGuardada = new Entidad
                {
                    Idtipodocumento = entidad.Idtipodocumento,
                    NumeroDocumento = entidad.NumeroDocumento,
                    RazonSocial = entidad.RazonSocial,
                    Direccion = entidad.Direccion,
                    Tipo = entidad.Tipo,
                    LogUsuarioModificacion = entidad.LogUsuarioModificacion,
                    LogFechaModificacion = DateTime.Now,
                    LogEstado = entidad.LogEstado
                  };

                ctx.Entidads.Add(EntidadGuardada);

                ctx.SaveChanges();

                return EntidadGuardada.Identidad;
            }
            catch (Exception ex)
            {
                throw ex; // Maneja la excepción según sea necesario
            }
        }

        public EntidadDTO ObtenerEntidadporDocumento(string documento)
        {
            try
            {
                Entidad EntidadObtenida = ctx.Entidads
                                           .Where(e => e.NumeroDocumento == documento)
                                           .First();

                if (EntidadObtenida != null)
                {
                    // Una vez encontrado carga la entidad encontrada a un entidadDTO
                    EntidadDTO entidadDTO = new EntidadDTO
                    {
                        Identidad = EntidadObtenida.Identidad,
                        Idtipodocumento = EntidadObtenida.Idtipodocumento,
                        NumeroDocumento = EntidadObtenida.NumeroDocumento,
                        RazonSocial = EntidadObtenida.RazonSocial,
                        Direccion = EntidadObtenida.Direccion,
                        Tipo = EntidadObtenida.Tipo,
                        LogUsuarioModificacion = EntidadObtenida.LogUsuarioModificacion,
                        LogFechaModificacion = EntidadObtenida.LogFechaModificacion,
                        LogEstado = EntidadObtenida.LogEstado

                    };

                    return entidadDTO;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex; // Maneja la excepción según sea necesario
            }
        }

        public EntidadDTO ObtenerEntidadporId(int identidad)
        {
            try
            {
                Entidad EntidadObtenida = ctx.Entidads
                                           .Where(e => e.Identidad == identidad)
                                           .First();
                
                if (EntidadObtenida != null)
                {
                    // Una vez encontrado carga la entidad encontrada a un entidadDTO
                    EntidadDTO entidadDTO = new EntidadDTO
                    {
                        Identidad = EntidadObtenida.Identidad,
                        Idtipodocumento = EntidadObtenida.Idtipodocumento,
                        NumeroDocumento = EntidadObtenida .NumeroDocumento,
                        RazonSocial = EntidadObtenida.RazonSocial,
                        Direccion = EntidadObtenida.Direccion,
                        Tipo = EntidadObtenida.Tipo,
                        LogUsuarioModificacion = EntidadObtenida.LogUsuarioModificacion,
                        LogFechaModificacion = EntidadObtenida.LogFechaModificacion,
                        LogEstado = EntidadObtenida.LogEstado
                        
                    };

                    return entidadDTO;
                }
                else
                {
                    return null; 
                }
            }
            catch (Exception ex)
            {
                throw ex; // Maneja la excepción según sea necesario
            }
        }
    }
}
