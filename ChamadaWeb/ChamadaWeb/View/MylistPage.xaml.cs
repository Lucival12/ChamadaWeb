using ChamadaWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChamadaWeb.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MylistPage : ContentPage
    {

        public MylistPage()
        {
            InitializeComponent();
            BindingContext = UsuarioBo.Instance;
            NavigationPage.SetHasBackButton(this, false);
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            Aprovacao aprovacao = e.Item as Aprovacao;
            await Navigation.PushAsync(new MyListPageDetail(aprovacao));

        }


        async void OnClickAsync(object sender, EventArgs e)
        {
            ToolbarItem tbi = (ToolbarItem)sender;
            UsuarioBo.Instance.Atualizar();
            await Navigation.PushAsync(new MylistPage()); ;


        }

        async void OnClickSignOut(object sender, EventArgs e)
        {
            var res = await this.DisplayAlert("Logout", "Deseja fazer logout?", "Ok", "Cancelar");
            if (res) {
                UsuarioLogado.Instance.signOut();
                await Navigation.PushAsync(new Login());
            }
        }


    }
}