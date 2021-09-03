using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace ZatherEngine3D.Engine.ECS
{
    public abstract class Entity
    {
        public List<Component> components;
        public Color col;
        public Guid id;

        public abstract void Draw();

        public Component GetComponent<T>(T type)
        {
            return components.Find(e => e.GetType() == type.GetType());
        }
        public bool FindComponent<T>(T type)
        {
            if(GetComponent<T>(type) != null)
            {
                return true;
            }
            return false;
        }
        public void RemoveComponent<T>(T type)
        {
            if (FindComponent<T>(type))
            {
                components.Remove(GetComponent<T>(type));
            }
        }
        public void AddComponent<T>(T type) where T: Component, new()
        {
            if (!FindComponent<T>(type))
            {
                components.Add(new T());
            }
        }
    }
}
