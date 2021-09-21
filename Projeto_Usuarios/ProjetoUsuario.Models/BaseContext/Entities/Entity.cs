using System;

namespace ProjetoUsuario.Models.BaseContext.Entities
{
    public abstract class Entity : BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
