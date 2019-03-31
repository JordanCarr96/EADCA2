using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TicketVendor.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void GetAllTickets()
        {
            app.Tap(x => x.Button("GetAllButton"));
            app.WaitForElement("GetAllView");
            app.Screenshot("Get All");
        }
        [Test]
        public void GetSoonTickets()
        {
            app.Tap(x => x.Button("GetSoonButton"));
            app.WaitForElement("GetSoonView");
            app.Screenshot("Get Coming Soon");
        }

        [Test]
        public void GetAvailableTickets()
        {
            app.Tap(x => x.Button("GetAvailableButton"));
            app.WaitForElement("GetAvailableView");
            app.Screenshot("Get Available");
        }

        [Test]
        public void GetByActTickets()
        {
            app.Tap(x => x.Button("GetActButton"));
            app.EnterText("Foals");
            app.WaitForElement("ActText");
            Assert.IsTrue(app.Query(x => x.Id("ActText").Text("Foals")).Any());
            app.Screenshot("Get Act");
        }

        [Test]
        public void GetByVenueTickets()
        {
            app.Tap(x => x.Button("GetVenueButton"));
            app.EnterText("Trinity College");
            app.WaitForElement("GetVenueView");
            app.Screenshot("Get Venue");
        }
    }
}
