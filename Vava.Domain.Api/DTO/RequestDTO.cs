namespace Vava.Domain.Api.DTO
{
    public class RequestDTO
    {
        public string Language { get; set; }
        public bool IsPlayableCharacter { get; set; }

        public RequestDTO()
        {
            Language = "pt-BR";
            IsPlayableCharacter = true;
        }
    }
}
