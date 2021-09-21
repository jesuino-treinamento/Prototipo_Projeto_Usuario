using FluentValidator.Validation;

namespace ProjetoUsuario.Models.BaseContext.Commands.Contracts
{
    public interface ICommandValidation
    {
        ValidationContract Contract { get; set; }
    }
}
