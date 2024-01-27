using ReverieGame.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame
{
    internal class Entity
    {
        public int ID { get; set; }

        List<Component> components = new List<Component>();

        public void AddComponent(Component component)
        {
            components.Add(component);
            component.entity = this;
        }

        public T GetComponent<T>() where T : Component
        {
            foreach (Component component in components)
            {
                if (component.GetType().Equals(typeof(T)))
                {
                    return (T)component;
                }
            }
            return null;
        }

        public virtual void Initialise() { }

        public virtual void Update(GameTime gameTime) { }

        public virtual void LoadContent(ContentManager Content) { }

        public virtual void UnloadContent(ContentManager Content) { }
    }
}
