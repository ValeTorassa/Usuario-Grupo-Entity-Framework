using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {

        //[Key]
        public int IdUsuario { get; set; }
        public int CantidadIntentos { get; }
        public string Email { get; set; }
        public bool EstaAutenticado { get => estaAutenticado; }
        public bool EstaHabilitado { get; }
        public List<Grupo> Grupos { get; set; } = new List<Grupo>();

        private string clave;
        private bool estaAutenticado;

        public void Agregar(Grupo grupo)
        {
            Grupos.Add(grupo);
        }

        public void CambiarClave(string claveActual, string claveNueva)
        {
            if (claveActual == clave)
            {
                clave = claveNueva;
            }
            else
            {
                throw new Exception("La clave actual no coincide.");
            }
        }

        public bool GetEstaAutenticado()
        {
            return EstaAutenticado;
        }

        public void IniciarSesion(string clave)
        {
            if (clave == this.clave)
            {
                estaAutenticado = true;
            }
            else
            {
                throw new Exception("La clave no es válida.");
            }
        }

        public void Quitar(Grupo grupo)
        {
            Grupos.Remove(grupo);
        }

        public Usuario()
        {

        }
    }
}
