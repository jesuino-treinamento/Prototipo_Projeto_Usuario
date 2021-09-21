namespace ProjetoUsuario.Models.Interfaces
{
    public interface IUnitOfWork
    {
        IUsuarioRepository UsuarioRepository { get; }

        bool SaveChanges();
    }
}