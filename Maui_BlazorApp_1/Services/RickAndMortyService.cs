using Maui_BlazorApp_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Maui_BlazorApp_1.Services
{
    internal class RickAndMortyService : IRickAndMorty
    {
        const string url = "https://rickandmortyapi.com/api/character";

        // Http Request Method
        public async Task<RickAndMorty> Get()
        {            
            var httpClient = new HttpClient();
            // Response
            var response = await httpClient.GetAsync(url);
            // Get
            var content = await response.Content.ReadAsStringAsync();

            // Serialize
            var rickAndMorty = JsonSerializer.Deserialize<RickAndMorty>(content);

            return rickAndMorty;
        }
    }
}
