namespace ProjetoUsuario.Models.BaseContext.Entities
{
    public class ResponseModel<T>
    {
        public bool Sucesso { get; set; }
        public T Data { get; set; }
        public string Mensagem { get; set; }

        private MessagesResponse messages;

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
    }
}