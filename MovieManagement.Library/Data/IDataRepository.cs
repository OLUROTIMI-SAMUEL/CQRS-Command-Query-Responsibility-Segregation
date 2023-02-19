using MovieManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Data
{
    public interface IDataRepository
    {
        List<MovieModel> GetMovies(); //Get here is a query
        MovieModel AddMovie(MovieModel movie);  // Add here is a command 

    }
}
