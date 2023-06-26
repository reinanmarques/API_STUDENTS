using Refit;
using Vava.Domain.Api.DTO;
using Vava.Domain.Api.Entities;

namespace Vava.Domain.Api.Repositories
{
    public interface IAgentRepository 
    {

        [Get("/v1/agents")]
        Task<ResponseDTO> findAll(RequestDTO preferences);


        [Get("/v1/agents/{agentUuid}")]
        Task<ResponseUniqueDTO> findById(string agentUuid);

    }
}
