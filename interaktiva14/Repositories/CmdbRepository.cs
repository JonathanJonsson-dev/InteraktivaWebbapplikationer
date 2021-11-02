using interaktiva14.Infrastructure;
using interaktiva14.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interaktiva14.Repositories
{
    public class CmdbRepository : ICmdbRepository
    {
        private readonly IApiClient apiClient;
        private readonly string baseEndpoint = "https://grupp9.dsvkurs.miun.se/api";
        
        public CmdbRepository(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<List<ToplistDto>> GetMovieToplist()
        {
            var top5 = "Toplist?sort=desc&count=5&type=ratings";
            var result = await apiClient.GetAsync<List<ToplistDto>>($"{baseEndpoint}/{top5}");
            return result; // returnerar sökresultat med  imdbID, måste sedan använda sig av omdbAPI för att få titel mm.. 
        }

        public async Task<List<ToplistDto>> GetMovies()
        {
            var result = await apiClient.GetAsync<List<ToplistDto>>($"{baseEndpoint}/Toplist?sort=desc");
            return result; // returnerar sökresultat med  imdbID, måste sedan använda sig av omdbAPI för att få titel mm.. 
        }

        public async Task<ToplistDto> IncreaseNumberOfLikes(string imdbID)
        {
            var test = await apiClient.GetAsync<ToplistDto>($"{baseEndpoint}Movie/{imdbID}/like");
            return test;
        }

        public async Task<ToplistDto> DecreaseNumberOfLikes(string imdbID)
        {
            return await apiClient.GetAsync<ToplistDto>($"{baseEndpoint}Movie/{imdbID}/dislike");
        }
    }
}
