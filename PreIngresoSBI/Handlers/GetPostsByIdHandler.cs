using MediatR;
using PreIngresoSBI.Model;
using PreIngresoSBI.Queries;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PreIngresoSBI.Handlers
{
    public class GetPostsByIdHandler : IRequestHandler<GetPostByIdQuery, ServerPost>
    {
        private readonly IMediator _mediator;
        public GetPostsByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<ServerPost> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            var post = await _mediator.Send(new GetPostListQuery());
            var serchedPost = post.FirstOrDefault(x => x.id == request.Id);
            return serchedPost;
        }
    }
}
