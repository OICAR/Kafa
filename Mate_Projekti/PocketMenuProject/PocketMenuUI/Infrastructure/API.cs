﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketMenuUI.Infrastructure
{
    public static class API
    {

        private static string BaseURL = "https://api-gateway20200429072611.azurewebsites.net";


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