using AutoMapper;
using Vava.Domain.Api.DTO;
using Vava.Domain.Api.Entities;

namespace Vava.Domain.Api.Mapping
{
    public class AgentProfile : Profile
    {

        public AgentProfile() 
        {
            CreateMap<Agent, ResponseDTO>();
        }

        
    }
}
