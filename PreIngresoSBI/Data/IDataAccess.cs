using PreIngresoSBI.Model;
using System.Collections.Generic;

namespace PreIngresoSBI.Data
{
    public interface IDataAccess
    {
        /// <summary>
        /// Obtiene la lista de posts
        /// </summary>
        /// <returns></returns>
        List<ServerPost> Get();
    }
}
