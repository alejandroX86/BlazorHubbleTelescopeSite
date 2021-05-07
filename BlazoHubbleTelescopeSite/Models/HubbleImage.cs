using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoHubbleTelescopeSite.Models
{
    public class HubbleImage
    {
   
        [JsonProperty("id")]

    public int Id { get; set; }



        [JsonProperty("name")]
        public string Name { get; set; }


        
        public string Image { get; set; }


        [JsonProperty("video_files")]

        public List<HubbleVideo> Videos { get; set; }
    
    }
}
