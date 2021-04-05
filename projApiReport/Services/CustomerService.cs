using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using projApiReport.Dto;

namespace projApiReport.Services
{
    public class CustomerService
    {
        private HttpClient _httpClient = new HttpClient();

        private IEnumerable<CustomerDto> _customers;

        public async Task<IEnumerable<CustomerDto>> GetCustomerAsync()
        {
            _httpClient.BaseAddress = new Uri("http://localhost:5003/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await _httpClient.GetAsync("api/Customer");
            
            if(response.IsSuccessStatusCode){
                var customerString = await response.Content.ReadAsStringAsync();
                _customers = JsonConvert.DeserializeObject<IEnumerable<CustomerDto>>(customerString);
            }
            else
                response.EnsureSuccessStatusCode();

            return _customers;
        }
    }
}