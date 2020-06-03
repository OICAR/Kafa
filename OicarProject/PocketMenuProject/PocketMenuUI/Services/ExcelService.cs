using PocketMenuUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PocketMenuUI.Services
{
    public class ExcelService :IExcel
    {
        private string _Url = "https://api-gateway20200429072611.azurewebsites.net";

        private readonly HttpClient _httpClientFactory;



        public ExcelService(HttpClient httpClient)
        {
            _httpClientFactory = httpClient;
        }

        public async void Get()
        {
            var uri = API.ExcelAPI.GetExcel(_Url);


            _httpClientFactory.DefaultRequestHeaders.Clear();
            //Define request data format  
            _httpClientFactory.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
            HttpResponseMessage Res = await _httpClientFactory.GetAsync(uri);

            //Checking the response is successful or not which is sent using HttpClient  
            if (Res.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api   
                var responseString = Res.Content.ReadAsStringAsync().Result;

            }

     

        }

}
}
