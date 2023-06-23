using Vava.Domain.Api.Entities;

namespace Vava.Domain.Api.DTO
{
    public class ResponseDTO
    {
        public int status{ get; set; }
        public List<Agent> data{ get; set; }
    }
}
