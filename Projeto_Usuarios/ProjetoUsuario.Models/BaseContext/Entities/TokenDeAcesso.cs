using Newtonsoft.Json;

namespace ProjetoUsuario.Models.BaseContext.Entities
{
    public class TokenDeAcesso
    {
        [JsonProperty(PropertyName = "aXvaToken")]
        public string Token { get; set; }

        [JsonProperty(PropertyName = "aXvaIdSessaoUsuario")]
        public string SessaoUsuario { get; set; }
    }
}
