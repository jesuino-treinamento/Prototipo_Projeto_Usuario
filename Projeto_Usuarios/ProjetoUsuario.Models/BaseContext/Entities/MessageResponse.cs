using Newtonsoft.Json;

namespace ProjetoUsuario.Models.BaseContext.Entities
{
    public class MessageResponse : IMessageResponse
    {
        #region /* Public Properties */

        [JsonProperty(Required = Required.Default, PropertyName = "error", Order = 0)]
        public bool Error { get; set; }

        [JsonProperty(Required = Required.Default, PropertyName = "code", Order = 1)]
        public string Code { get; set; }

        [JsonProperty(Required = Required.Default, PropertyName = "property", Order = 2)]
        public string Property { get; set; }

        [JsonProperty(Required = Required.Default, PropertyName = "message", Order = 3)]
        public string Message { get; set; }

        #endregion

        #region /* Constructors */

        public MessageResponse() { }

        public MessageResponse(bool error = false, string code = null, string property = null, string message = null)
        {
            this.Error = error;
            this.Code = code;
            this.Property = property;
            this.Message = message;
        }

        public MessageResponse(bool error = false, string message = null)
        {
            this.Error = error;
            this.Code = null;
            this.Property = null;
            this.Message = message;
        }
        #endregion
    }
}
