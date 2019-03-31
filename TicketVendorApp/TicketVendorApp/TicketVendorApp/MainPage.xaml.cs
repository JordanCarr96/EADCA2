using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicketVendorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

           
        }

        private async void GetAll_Click(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GetData());

        }

        private async void GetAct_Click(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GetDataByAct());

        }

        private async void GetVenue_Click(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GetDataByVenue());

        }

        private async void GetSoon_Click(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GetComingSoon());

        }

        private async void GetAvailable_Click(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GetTicketsAvailable());

        }
    }
}
