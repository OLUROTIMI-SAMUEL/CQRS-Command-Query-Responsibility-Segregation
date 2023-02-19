using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Library.Commands;
using MovieManagement.Library.Models;
using MovieManagement.Library.Queries;

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;            
        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //Get: api<MoviesController>
        [HttpGet]
        public async Task<List<MovieModel>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }
        [HttpPost]
        public async Task<MovieModel> Post(MovieModel movieModel)
        {
            return await _mediator.Send(new AddMovieCommand(movieModel));
        }

    }
}
