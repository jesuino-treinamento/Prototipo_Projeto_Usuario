namespace ProjetoUsuario.Models.BaseContext.Entities
{
    public interface IResult : IBaseDTO
    {
        new bool IsSuccessful { get; }

        new MessagesResponse Messages { get; set; }
    }
}
