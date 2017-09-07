using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpTrack.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Login_Clicked(object sender,EventArgs args)
        {
            //await DirectoryAuthentication.SearchByAlias();
            App.Current.MainPage = new Views.Menu.MainPage();
        }
    }
}