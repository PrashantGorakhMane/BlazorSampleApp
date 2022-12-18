using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorSampleApp.Data;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
    {
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray());
    }

    public async Task onClickTakePhoto(IJSRuntime _jsRuntime)
    {
        try
        {
            var parameter = "TakePhoto";
           var image =  _jsRuntime.InvokeAsync<string>("invokeNativeAction", parameter);
            if(image != null)
            {

            }
        }
        catch(Exception ex)
        {

        }
    }
    public async Task onClickSendLocation(IJSRuntime _jsRuntime, string parameter)
    {
        try
        {
            await _jsRuntime.InvokeVoidAsync("invokeNativeAction", parameter);
        }
        catch (Exception ex)
        {

        }
    }
}

