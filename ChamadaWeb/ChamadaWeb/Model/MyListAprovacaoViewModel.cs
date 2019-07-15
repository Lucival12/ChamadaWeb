using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChamadaWeb.Model
{
    class UsuarioBo
    {
        private static UsuarioBo instance;
        public ObservableCollection<Aprovacao> aprovacaoList { get; set; }

        private UsuarioBo()
        {

        }

        public static UsuarioBo Instance
        {

            get
            {
                if (instance == null)
                    lock (typeof(UsuarioBo))
                        if (instance == null)
                            instance = new UsuarioBo { aprovacaoList = new ObservableCollection<Aprovacao>(new Service().GetAprovacoes()) };
           

                return instance;
            }

        }

        public void AprovarDocumanto(Aprovacao aprovacao)
        {
            aprovacaoList.Remove(aprovacao);
        }

        public void Atualizar()
        {
            instance.aprovacaoList = new ObservableCollection<Aprovacao>(new Service().GetAprovacoes());
        }

    }
}
