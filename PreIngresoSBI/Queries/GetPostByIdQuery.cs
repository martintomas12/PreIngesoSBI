using MediatR;
using PreIngresoSBI.Model;

namespace PreIngresoSBI.Queries
{
    public record GetPostByIdQuery(int Id) : IRequest<ServerPost>;
}
