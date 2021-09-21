using ProjetoUsuario.Models.Dtos;
using System.Collections.Generic;

namespace ProjetoUsuario.Models.Interfaces
{
    public interface IUsuarioBusiness
    {
        UsuarioDto Autenticar(LoginDto loginDto);

        IEnumerable<UsuarioDto> Filtrar();

        UsuarioDto Selecionar(int id);

        ResultadoDto Excluir(int id);

        ResultadoDto Salvar(UsuarioDto usuario);
    }
}