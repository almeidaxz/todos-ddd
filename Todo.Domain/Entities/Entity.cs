using System.ComponentModel.DataAnnotations;

namespace Todo.Domain.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; private set; }
    }
}