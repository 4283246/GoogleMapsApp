using System;

using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XamGoogleMapsApp
{
    public class PinPage : ContentPage
    {
        /* //Map map;

         public PinPage()
         {
             //InitializeComponent();
             DisplayLocation();


         }
         public async void DisplayLocation()
         {
             try
             {
                 var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                 var location = await Geolocation.GetLocationAsync(request);
                 if (location != null)
                 {
                     Position p = new Position(location.Latitude, location.Longitude);
                     MapSpan mapSpan = MapSpan.FromCenterAndRadius(p, Distance.FromKilometers(.444));
                     map.MoveToRegion(mapSpan);
                     Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                     map.Pins.Add(pin);
                 }
             }
         } }
     }
 }
 /*  Map map = new Map
             {
                 IsShowingUser = true,
                 HeightRequest = 100,
                 WidthRequest = 960,
                 VerticalOptions = LayoutOptions.FillAndExpand
             };

             map.MoveToRegion(MapSpan.FromCenterAndRadius(
                 new Position(36.9628066, -122.0194722), Distance.FromMiles(3)));
             var position = new Position(36.9628066, -122.0194722);
             var pin = new Pin
             {
                 Type = PinType.Place,
                 Position = position,
                 Label = "Santa Cruz",
                 Address = "custom detail info"
             };
             map.Pins.Add(pin);



             var morePins = new Button { Text = "Add more pins" };
             morePins.Clicked += (sender, e) => {
                 map.Pins.Add(new Pin
                 {
                     Position = new Position(36.9641949, -122.0177232),
                     Label = "Boardwalk"
                 });
                 map.Pins.Add(new Pin
                 {
                     Position = new Position(36.9571571, -122.0173544),
                     Label = "Wharf"
                 });
                 map.MoveToRegion(MapSpan.FromCenterAndRadius(
                     new Position(36.9628066, -122.0194722), Distance.FromMiles(1.5)));

             };
             var reLocate = new Button { Text = "Re-center" };
             reLocate.Clicked += (sender, e) => {
                 map.MoveToRegion(MapSpan.FromCenterAndRadius(
                     new Position(36.9628066, -122.0194722), Distance.FromMiles(3)));
             };
             var buttons = new StackLayout
             {
                 Orientation = StackOrientation.Horizontal,
                 Children = {
                     morePins, reLocate
                 }
             };

             Content = new StackLayout
             {
                 Spacing = 0,
                 Children = {
                     map,
                     buttons
                 }
             };
         }*/

    }
}