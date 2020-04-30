using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketMenuUI.Infrastructure
{
    public static class API
    {

        public static class Forecast
        {
            public static string GetWeatherForecast(string baseUri) => $"{baseUri}/api/weatherforecast";
        
        }

        public static class QRCode
        {

            public static string GetQRCode(string baseUri) => $"{baseUri}/api/QRCode";



        }

    }
}
