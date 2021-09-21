using System;

namespace ProjetoUsuario.WebApp.Areas.Painel.Models
{
    public class ResultadoViewModel
    {
        public bool Sucesso { get; set; }
        public string Url { get; set; }
        public Nullable<int> Id { get; set; }
    }
}