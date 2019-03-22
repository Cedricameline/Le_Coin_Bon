using Le_Coin_Bon.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Le_Coin_Bon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnInscriptionClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Form_Inscription("","","",""));
        }
    }
}
