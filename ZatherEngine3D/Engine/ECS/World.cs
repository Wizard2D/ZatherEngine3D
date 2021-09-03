using System;
using System.Linq;
using System.Collections.Generic;
using ZatherEngine3D.Engine;
using System.Text;

namespace ZatherEngine3D.Engine.ECS
{
    public static class World // idk.
    {
        public static Entity GetEntity(Guid id)
        {
            return Config.entities.Single(e => e.id == id);
        }
    }
}
