using AutoMapper;
using PreIngresoSBI.Model;

namespace PreIngresoSBI
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ServerPost, Salida>().ForMember(d => d.Id, o => o.MapFrom(s => s.id));
            CreateMap<ServerPost, Salida>().ForMember(d => d.Titulo, o => o.MapFrom(s => s.title));
        }
    }
}
