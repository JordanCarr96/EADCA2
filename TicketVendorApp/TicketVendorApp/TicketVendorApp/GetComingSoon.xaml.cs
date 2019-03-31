using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicketVendorApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GetComingSoon : ContentPage
	{
		public GetComingSoon ()
		{
			InitializeComponent ();
            GetTicketsComingSoon();
		}

        private async void GetTicketsComingSoon()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://ticketvendor.azurewebsites.net/api/tickets/dates");

            var tickets = JsonConvert.DeserializeObject<List<TicketVendor>>(response);

            TicketsListComingSoon.ItemsSource = tickets;

        }
    }
}