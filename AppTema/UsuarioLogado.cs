using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTema
{
    public sealed class UsuarioLogado
    {

        static UsuarioLogado _instancia;
        public static UsuarioLogado Instancia
        {
            get
            {

                return _instancia ?? (_instancia = new UsuarioLogado());
            }
        }

        public UsuarioLogado() { }

        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
