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
	public partial class GetDataByAct : ContentPage
	{
		public GetDataByAct ()
		{
			InitializeComponent ();
		}

        private void GetAct_Click(object sender, EventArgs args)
        {
            var result = act.Text;
            actlabel.Text = result;
            GetTicketsByAct();
        }

        private async void GetTicketsByAct()
        {
            

            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://ticketvendor.azurewebsites.net/api/tickets/act/" + actlabel.Text);

            var ticket = JsonConvert.DeserializeObject<TicketVendor>(response);

            GetTicketDescription.Text = ticket.EventDescription.ToString();

        }
    }
}