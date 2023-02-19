using MediatR;
using MovieManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Queries
{
    //So this is a super charge class in C# 9
   public record GetMovieListQuery() : IRequest<List<MovieModel>>; //IRequest is a mediator Interface which can be used after downloading MediatorR package
    //from NutGut Package. So IRequest Just detect what will be the return type which is going to be a List of movies here
}
