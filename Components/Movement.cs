using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Components
{
    internal class Movement : Component
    {
        public Vector2 position = Vector2.Zero;
        public Vector2 velocity = Vector2.Zero;
        public Vector2 scale = Vector2.Zero;

        public float layerDepth = 0;
        public float rotation = 0;

    }
}
