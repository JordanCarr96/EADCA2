﻿using Newtonsoft.Json;
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
	public partial class GetData : ContentPage
	{
		public GetData ()
		{
			InitializeComponent ();

            GetTickets();
		}
        private async void GetTickets()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://ticketvendor.azurewebsites.net/api/tickets");

            var tickets = JsonConvert.DeserializeObject<List<TicketVendor>>(response);

            TicketsListView.ItemsSource = tickets;

        }
    }
}