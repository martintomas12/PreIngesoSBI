using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PreIngresoSBI.Model;
using PreIngresoSBI.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PreIngresoSBI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {


        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public PostController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Obtiene la lista de posts
        /// </summary>
        /// <returns>Listado de posts</returns>
        [HttpGet]
        public async Task<List<ServerPost>> Get()
        {
            return await _mediator.Send(new GetPostListQuery());
        }

        /// <summary>
        /// Obtiene el post por el id
        /// </summary>
        /// <param name="id">Id del post</param>
        /// <returns>Post segun ID</returns>
        [HttpGet("{id}")]
        public async Task<Salida> Get(int id)
        {
            var response = await _mediator.Send(new GetPostByIdQuery(id));
            Salida post = _mapper.Map<Salida>(response);
            return post;
        }
    }
}
