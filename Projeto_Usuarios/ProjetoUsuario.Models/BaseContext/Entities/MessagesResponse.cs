using System.Collections.Generic;

namespace ProjetoUsuario.Models.BaseContext.Entities
{
    public class MessagesResponse : List<MessageResponse>, IMessageResponse
    {
        public MessagesResponse()
        {
        }

        public MessagesResponse(params MessageResponse[] messages)
        {
        }
    }
}