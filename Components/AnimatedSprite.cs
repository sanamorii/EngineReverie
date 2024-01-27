using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Components
{
    internal class AnimatedSprite : Component
    {
        public Texture2D texture { get; set; }

        public AnimatedSprite()
        {
            AnimatedSpriteSystem.Register(this);
        }

    }
}
