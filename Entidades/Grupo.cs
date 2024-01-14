using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Grupo
    {
        public int IdGrupo { get; set; }
        public string Descripcion { get; set; }
        public bool EstaHabilitado { get ; set ; }
        public string Nombre { get; set ; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}