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
    public partial class Login : ContentPage
    {

        public Login()
        {
            InitializeComponent();
            
        }

        async void OnClick(object sender, EventArgs e)
        {
            if(new Service().Login(User.Text, Senha.Text))            
                await Navigation.PushAsync(new MylistPage());
            else
               await this.DisplayAlert("Erro", "Login ou Senha Invalído", "Ok");
        }
    }
}