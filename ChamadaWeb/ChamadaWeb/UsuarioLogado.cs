using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChamadaWeb.Model;

namespace ChamadaWeb
{
    class UsuarioLogado
    {
        private static UsuarioLogado instance;
        public Usuario user;
        private UsuarioLogado()
        {

        }

        public static UsuarioLogado Instance
        {
            get
            {
                if (instance == null)
                    lock (typeof(UsuarioLogado))
                        if (instance == null)
                            instance = new UsuarioLogado { user = new Usuario()};

                return instance;
            }
        }

        public void signIn(Usuario user)
        {
            instance.user = user;
        }

        public void signOut()
        {
            instance = null;
        }

    }
}