using System.ComponentModel.DataAnnotations;

namespace ProjetoUsuario.Models.Dtos
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o e-mail")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o telefone")]
        public string Telefone { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o login")]
        public string Login { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }
    }
}