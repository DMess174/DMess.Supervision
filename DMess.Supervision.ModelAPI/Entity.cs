using System;

namespace DMess.Supervision.ModelAPI
{
    public abstract class Entity : IEntity
    {
        public string Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
