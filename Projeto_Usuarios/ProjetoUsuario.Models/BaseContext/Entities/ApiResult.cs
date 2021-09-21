using System.Collections.Generic;
using ProjetoUsuario.Models.BaseContext.Commands.Contracts;

namespace ProjetoUsuario.Models.BaseContext.Entities
{
    public class ApiResult : ICommandResult
    {
        public ApiResult()
        {
            Message = new List<string>();
        }

        public ApiResult(bool success, string message, object data, int totalReg = 0, int totalRegFilter = 0)
        {
            Message = new List<string>();
            Success = success;
            Data = data;
            TotalReg = totalReg;
            TotalRegFilter = totalRegFilter;
            if (message != string.Empty)
                Message.Add(message);
        }
        public bool Success { get; set; }
        public List<string> Message { get; set; }
        public object Data { get; set; }
        public int TotalReg { get; set; }
        public int TotalRegFilter { get; set; }
    }
}
