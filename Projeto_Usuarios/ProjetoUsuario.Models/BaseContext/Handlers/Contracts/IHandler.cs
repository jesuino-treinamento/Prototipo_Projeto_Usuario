using System.Threading.Tasks;
using ProjetoUsuario.Models.BaseContext.Commands.Contracts;
using ProjetoUsuario.Models.BaseContext.Entities;

namespace ProjetoUsuario.Models.BaseContext.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        Task<IResult> HandlerAsync(T command);
    }
}
