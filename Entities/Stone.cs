using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ReverieGame.Components;
using SharpDX.Direct3D9;
using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Entities
{
    internal class Stone : Entity
    {
        Transform transform = new Transform();
        AnimatedSprite sprite = new AnimatedSprite();

        public Stone()
        {

        }

        public override void Initialise()
        {
            AddComponent(transform);
            transform.position = new Vector2(100, 100);

            transform.Initialise(); // goes after AddComponents

            base.Initialise();
        }

        public override void LoadContent(ContentManager Content)
        {

            sprite.texture = Content.Load<Texture2D>("idle_single");

            AddComponent(sprite);

            base.LoadContent(Content);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

    }
}
