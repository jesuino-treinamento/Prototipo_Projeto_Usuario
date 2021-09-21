using System.ComponentModel.DataAnnotations;

namespace ProjetoUsuario.Models.Dtos
{
    public class LoginDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o usuário")]
        public string Usuario { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }
        
        public UsuarioDto GetUsuarios()
        {
            return new UsuarioDto();
        }
    }

    
}
