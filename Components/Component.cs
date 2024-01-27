using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Components
{
    internal class Component
    {
        public Entity entity;
        public virtual void Update(GameTime gameTime) { }
        public virtual void Initialise() { }
    }
}
