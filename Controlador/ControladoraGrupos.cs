using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Modelo;
using Entidades;

namespace Controlador
{
   
        public class ControladoraGrupos
        {
            private Contexto contexto;
            private ControladoraGrupos() => contexto = new Contexto();

            private static ControladoraGrupos instancia;
            public static ControladoraGrupos Instancia
            {
                get
                {
                    if (instancia == null)
                        instancia = new ControladoraGrupos();
                    return instancia;
                }
            }

            public bool NombreExiste(string nombre)
            {
                return !contexto.Grupos.Any(x => x.Nombre == nombre);
            }

        public IReadOnlyCollection<Grupo> Listar()
            {
                return new ReadOnlyCollection<Grupo>(contexto.Grupos.ToList());
            }

            public string Agregar(Grupo grupo)
            {
                try
                {
                    contexto.Grupos.Add(grupo);
                    contexto.SaveChanges();
                    return $"El grupo {grupo.Nombre} se agregó correctamente.";
                }
                catch (Exception)
                {
                    return "Error desconocido al agregar el grupo.";
                }
            }

            public string Eliminar(Grupo grupo)
            {
                try
                {
                    contexto.Grupos.Remove(grupo);
                    contexto.SaveChanges();
                    return $"El grupo {grupo.Nombre} se eliminó correctamente.";
                }
                catch (Exception)
                {
                    return "Error desconocido al eliminar el grupo.";
                }
            }

            public string Modificar(Grupo grupo)
            {
                try
                {
                    contexto.Grupos.Update(grupo);
                    contexto.SaveChanges();
                    return $"El grupo {grupo.Nombre} se modificó correctamente.";
                }
                catch (Exception)
                {
                    return "Error desconocido al modificar el grupo.";
                }
            }
        }
    }
