using interaktiva14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interaktiva14.Repositories
{
    public interface ICmdbRepository
    {
        /// <summary>
        /// Retrieves toplist of movies
        /// </summary>
        /// <returns>CmdbDto</returns>
        Task<MovieBySearchDto> GetMovieToplist();    
    }
}