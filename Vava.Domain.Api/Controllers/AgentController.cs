using Microsoft.AspNetCore.Mvc;
using Vava.Domain.Api.DTO;
using Vava.Domain.Api.Entities;
using Vava.Domain.Api.Repositories;

namespace Vava.Domain.Api.Controllers
{
    [ApiController]
    [Route("agents")]
    public class AgentController : ControllerBase
    {

        [HttpGet]
        public Task<ResponseDTO> findAll([FromServices] IAgentRepository repository)
        {
            return repository.findAll(new DTO.RequestDTO());


        }
        
        [HttpGet("{uuid}")]
        public Task<ResponseUniqueDTO> findById([FromServices] IAgentRepository repository , string uuid)
        {
            return repository.findById(uuid);

        }
    }
}
