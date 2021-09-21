using ProjetoUsuario.Models.Entities;
using ProjetoUsuario.Models.Interfaces;

namespace ProjetoUsuario.Data.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationContext context)
            : base(context)
        {
        }
    }
}