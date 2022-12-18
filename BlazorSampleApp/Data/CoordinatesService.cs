using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorSampleApp.Data
{
    public class CoordinatesService
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        private static readonly Coordinates Location;
        static CoordinatesService()
        {
            Location = new Coordinates();
            //{
            //    Latitude = "32454",
            //    Longitude = "345245"
            //};
            Location.Photo = "https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/16/2019/04/BrandBlazor_nohalo_1000x.png";
        }
        public Task<Coordinates> GetLocationAsync()
        {
            return Task.FromResult(Location);
        }



        [JSInvokable("nativeToWebViewSendCoordinates")]
        public static async void nativeToWebViewSendCoordinates()
        {

        }
    } 
}

