using BlazoHubbleTelescopeSite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazoHubbleTelescopeSite.Services
{
    public class HubbleService : IHubbleService
    {

        private readonly HttpClient _httpClient;

     public HubbleService(HttpClient  httpClient)
        {

            _httpClient = httpClient;
        }


        public  async  Task<IEnumerable<HubbleImage>> GetAllImages()
        {
           return JsonConvert.DeserializeObject<IEnumerable<HubbleImage>>(
            
            await  _httpClient.GetStringAsync($"videos/all?page=all"));
        }

        public async  Task<HubbleImage> GetVideo(int id)
        {

            return JsonConvert.DeserializeObject<HubbleImage>(

           await _httpClient.GetStringAsync($"video/{id}"));


        }
    }
}
