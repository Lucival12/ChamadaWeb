using ChamadaWeb.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChamadaWeb.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListPageDetail : ContentPage
    {
        Aprovacao aprovacaoAux;
        public MyListPageDetail(Aprovacao aprovacao)
        {
            aprovacaoAux = aprovacao;
            InitializeComponent();

            NumeroDocumento.Text = aprovacao.numeroDocumento;
            ValorTotal.Text = aprovacao.valorTotal;
            Fornecedor.Text = aprovacao.fornecedor;
            DataLiberacao.Text = aprovacao.dataLiberacao;
            BindingContext = new MyListItemAprovacaoViewModel(aprovacao.itens);

        }

        async void OnClickAsync(object sender, EventArgs e)
        {
            ToolbarItem tbi = (ToolbarItem)sender;
            var res = await this.DisplayAlert("Aprovação de Documento", "Deseja aprovar o documento?", "Ok","Cancelar");
            UsuarioBo.Instance.AprovarDocumanto(aprovacaoAux);
            if (res) { await Navigation.PopAsync(); }


        }
    }
}