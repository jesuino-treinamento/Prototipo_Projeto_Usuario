namespace ProjetoUsuario.Models.BaseContext.Entities
{
    public interface IBaseDTO
    {
        bool IsSuccessful { get; }
        MessagesResponse Messages { get; set; }
    }
}
