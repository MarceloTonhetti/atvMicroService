using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using projApiReport.Dto;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System;

namespace projApiReport.Services
{
    public class ProductService
    {
        private HttpClient _httpClient = new HttpClient();
        
        private IEnumerable<ProductDto> _products;

        public async Task<IEnumerable<ProductDto>> GetProductAsync()
        {
            _httpClient.BaseAddress = new Uri("http://localhost:5002/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            
            HttpResponseMessage response = await _httpClient.GetAsync("api/Product");

            if(response.IsSuccessStatusCode){
                var productString = await response.Content.ReadAsStringAsync();
                _products = JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(productString);
            }
            else
                response.EnsureSuccessStatusCode();

            return _products;
        }
    }
}