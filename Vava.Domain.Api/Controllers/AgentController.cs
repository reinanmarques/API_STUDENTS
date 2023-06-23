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

        private IAgentRepository _agentRepository;

        public AgentController(IAgentRepository agentRepository)
        {
            _agentRepository = agentRepository;
        }

        [HttpGet]
        public Task<ResponseDTO> findAll([FromServices] IAgentRepository repository)
        {
            return _agentRepository.findAll(new DTO.RequestDTO());
        }
    }
}
