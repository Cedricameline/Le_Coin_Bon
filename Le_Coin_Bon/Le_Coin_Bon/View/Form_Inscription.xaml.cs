using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Le_Coin_Bon.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Form_Inscription : ContentPage
	{
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }

        public Form_Inscription(string nom, string prenom, string password, string login)
        {
            Nom = nom;
            Prenom = prenom;
            Password = password;
            Login = login;
        }

        async void OnSave(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }	
}