using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System.Collections.ObjectModel;

namespace Controlador
{
    namespace Controlador
    {
        public class ControladoraUsuarios
        {
            private Contexto contexto;
            private ControladoraUsuarios() => contexto = new Contexto();

            private static ControladoraUsuarios instancia;
            public static ControladoraUsuarios Instancia
            {
                get
                {
                    if (instancia == null)
                        instancia = new ControladoraUsuarios();
                    return instancia;
                }
            }

            public IReadOnlyCollection<Usuario> ListarUsuarios()
            {
                return new ReadOnlyCollection<Usuario>(contexto.Usuarios.Include(u => u.Grupos).ToList());
            }

            public bool MailExiste(string email)
            {
                return !contexto.Usuarios.Any(x => x.Email == email);
            }

            public string Agregar(Usuario usuario)
            {
                try
                {
                    contexto.Usuarios.Add(usuario);
                    contexto.SaveChanges();
                    return $"El usuario {usuario.Email} se agregó correctamente.";
                }
                catch (Exception)
                {
                    return "Error desconocido al agregar el usuario.";
                }
            }
            public string Eliminar(Usuario usuario)
            {
                try
                {
                    contexto.Usuarios.Remove(usuario);
                    contexto.SaveChanges();
                    return $"El usuario {usuario.Email} se eliminó correctamente.";
                }
                catch (Exception)
                {
                    return "Error desconocido al eliminar el usuario.";
                }
            }

            public string Modificar(Usuario usuario)
            {
                try
                {
                    contexto.Usuarios.Update(usuario);
                    contexto.SaveChanges();
                    return $"El usuario {usuario.Email} se modificó correctamente.";
                }
                catch (Exception)
                {
                    return "Error desconocido al modificar el usuario.";
                }
            }

            public IReadOnlyCollection<Grupo> ListarGrupos()
            {
                return new ReadOnlyCollection<Grupo>(contexto.Grupos.ToList());
            }


            public List<Grupo> ObtenerGruposPorNombre(List<Grupo> listaGrupos)
            {
                var gruposTotales = ListarGrupos();
                var gruposEncontrados = listaGrupos.Select(grupo => gruposTotales
                                                             .FirstOrDefault(g => g.Nombre == grupo.Nombre))
                                                             .Where(grupoEncontrado => grupoEncontrado != null).ToList();
                return gruposEncontrados;
            }
        }
    }
}