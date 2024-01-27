using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace ReverieGame.Components
{

    internal class Transform : Component
    {
        public Vector2 position = Vector2.Zero;
        public Vector2 scale = Vector2.Zero;

        public float layerDepth = 0;
        public float rotation = 0;

        public Transform()
        {
            TransformSystem.Register(this);
        }

        public override void Initialise()
        {
            base.Initialise();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }



    }
}
