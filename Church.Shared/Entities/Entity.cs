using System;

namespace Church.Shared.Entities
{
    public abstract class Entity
    {
        public string ID { get; private set; }

        public Entity()
        {
            ID = Guid.NewGuid().ToString().ToUpper();
        }

        protected Entity(string id)
        {
            ID = id;
        }
    }
}
