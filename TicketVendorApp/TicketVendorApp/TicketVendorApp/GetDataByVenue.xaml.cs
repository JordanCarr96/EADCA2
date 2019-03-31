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
	public partial class GetDataByVenue : ContentPage
	{
		public GetDataByVenue ()
		{
			InitializeComponent ();
		}

        private void GetVenue_Click(object sender, EventArgs args)
        {
            var result = venue.Text;
            venuelabel.Text = result;
            GetTicketsByAct();
        }
        private async void GetTicketsByAct()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://ticketvendor.azurewebsites.net/api/tickets/venue/" + venuelabel.Text);

            var tickets = JsonConvert.DeserializeObject<List<TicketVendor>>(response);

            TicketsListByVenue.ItemsSource = tickets;
        }

	}
}