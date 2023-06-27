using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Maui_BlazorApp_1.Models;


namespace Maui_BlazorApp_1.Services
{
    internal interface IRickAndMorty
    {
        public Task<RickAndMorty> Get();
    }
}
