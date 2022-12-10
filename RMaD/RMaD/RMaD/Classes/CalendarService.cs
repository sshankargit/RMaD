using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;

namespace GoogleCalendarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the private key file
            var credPath = "path/to/private/key/file.json";
            var cred = GoogleCredential.FromFile(credPath)
                .CreateScoped(CalendarService.Scope.Calendar);

            // Use the credentials to authenticate the service account
            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = cred
            });

            // Use the calendar service to access Google Calendar events
            var events = service.Events.List("primary").Execute();
            foreach (var ev in events.Items)
            {
                Console.WriteLine("{0} ({1})", ev.Summary, ev.Start.DateTime);
            }
        }
    }
}

//In the code above, the GoogleCredential.FromFile method is used to load the private key 
//file and create a GoogleCredential object. The CreateScoped method is then used to
//create a scoped credential that has access to the Google Calendar API. The 
//CalendarService class is then used to create a calendar service that uses the service 
//account's credentials to authenticate. The calendar service can then be used to acc
//Google Calendar events.

namespace CalendarAPI
{
    public static class CalendarInvite
    {
        public static Event CreateShippingEvent(string trackingNumber, DateTime shippingDate,
                                                string shippingStatus, string shippingLocation,
                                                DateTime deliveryDate)
        {
            var shippingEvent = new Event
            {
                Summary = $"Package Tracking: {trackingNumber}",
                Location = shippingLocation,
                Start = new EventDateTime
                {
                    DateTime = shippingDate
                },
                End = new EventDateTime
                {
                    DateTime = deliveryDate
                },
                Description = $"Shipping status: {shippingStatus}"
            };

            return shippingEvent;
        }
    }
}

//This code defines a static class called CalendarInvite that contains a method called
//CreateShippingEvent. The CreateShippingEvent method takes five parameters: 
//trackingNumber, shippingDate, shippingStatus, shippingLocation, and 
//deliveryDate.
//
//The method uses these parameters to create a new Event object that represents a 
//shipping event in a calendar. The Event object contains information about the package's 
//tracking number, shipping location, shipping date, delivery date, and shipping status.
//Once the Event object has been created, it is returned by the CreateShippingEvent 
//method. The Event object can then be used to add the shipping event to a calendar using 
//the Google Calendar API.


namespace RMaD.Classes
{
    internal class CalendarService
    {
    }
}
