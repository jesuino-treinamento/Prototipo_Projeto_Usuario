using Newtonsoft.Json;
using System.Linq;

namespace ProjetoUsuario.Models.BaseContext.Entities
{
    public class Result<T> : IResult where T : BaseEntity
    {
        private MessagesResponse messages;

        public T Data { get; set; }
        public bool IsSuccessful => this.Data != null && !this.Messages.Any(message => message.Error == true);
        public MessagesResponse Messages
        {
            get
            {
                if (this.messages == null)
                    this.messages = new MessagesResponse();

                return this.messages;
            }
            set => this.messages = value;
        }

        public Result() { }

        [JsonConstructor]
        public Result(T data) => this.Data = data;

        public static implicit operator Result<T>(T data) => new Result<T>(data);
    }
}
