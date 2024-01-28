using ReverieGame.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Reflection.Metadata;
using Microsoft.Xna.Framework.Content;

namespace ReverieGame
{
    internal class Player : Entity
    {
        public Player()
        {

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Initialise()
        {
            Transform transform = new Transform();
            Physics physics = new Physics();
            PlayerControllable controller = new PlayerControllable();

            transform.position = new Vector2(0, 0);

            AddComponent(controller);
            AddComponent(transform);
            AddComponent(physics);

            transform.Initialise(); // goes after AddComponents
            physics.Initialise();
            controller.Initialise();

            base.Initialise();
        }

        public override void LoadContent(ContentManager Content)
        {
            AnimatedSprite sprite = new AnimatedSprite();

            sprite.texture = Content.Load<Texture2D>("idle_single");

            AddComponent(sprite);

            base.LoadContent(Content);
        }
    }
}
