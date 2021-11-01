using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static interaktiva14.Models.MovieBySearchDto;

namespace interaktiva14.Models.ViewModels
{
    public class SearchResultViewModel
    {
        public List<MovieInformationDto> Movies { get; set; }
        public string imdbID { get; set; }

        public SearchResultViewModel(List<MovieInformationDto> movieList)
        {
            Movies = movieList;
        }
        public SearchResultViewModel()
        {
            
        }
    }
}
