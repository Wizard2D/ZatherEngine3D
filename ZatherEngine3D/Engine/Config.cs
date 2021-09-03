using System;
using System.Collections.Generic;
using System.Text;
using ZatherEngine3D.Engine.ECS;
using Raylib_cs;

namespace ZatherEngine3D.Engine
{
    public static class Config
    {
        public static List<Entity> entities;
        public static int EntityLimit;

        public static void Setup(List<Entity> entts, int limit = 12000)
        {
            entities = entts;
            EntityLimit = limit;
        }
    }
}
