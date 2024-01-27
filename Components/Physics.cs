using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Components
{
    internal class Physics : Component
    {

        public double velocity { get; set; }
        public double friction { get; set; }
        public double acceleration { get; set; }

        public Vector2 direction = new Vector2(0, 0);

        public Physics()
        {
            PhysicsSystem.Register(this);
        }

        public override void Update(GameTime gameTime)
        {
            Console.WriteLine(direction);

        }
    }
}
