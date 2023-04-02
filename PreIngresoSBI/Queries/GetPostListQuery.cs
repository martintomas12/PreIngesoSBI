using MediatR;
using PreIngresoSBI.Model;
using System.Collections.Generic;

namespace PreIngresoSBI.Queries
{
    public record GetPostListQuery() : IRequest<List<ServerPost>>;
}
