using MediatR;
using PreIngresoSBI.Data;
using PreIngresoSBI.Model;
using PreIngresoSBI.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PreIngresoSBI.Handlers
{
    public class GetPostsListHandler : IRequestHandler<GetPostListQuery, List<ServerPost>>
    {
        private readonly IDataAccess _dataAccess;
        public GetPostsListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<List<ServerPost>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.Get());
        }
    }
}
