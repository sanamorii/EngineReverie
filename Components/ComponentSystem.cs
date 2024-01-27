using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Components
{
    internal class ComponentSystem<T> where T : Component
    {
        public static List<T> components = new List<T>();

        public static void Register(T component)
        {
            components.Add(component);
        }

        public static void Update(GameTime gameTime)
        {
            foreach (T component in components)
            {
                component.Update(gameTime);
            }
        }
    }


    class InputSystem : ComponentSystem<Input> { }

    class MovementSystem : ComponentSystem<Movement> { }

    class AnimatedSpriteSystem : ComponentSystem<AnimatedSprite> 
    {
        public static void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (AnimatedSprite sprite in components)
            {
                Movement movement = sprite.entity.GetComponent<Movement>();
                spriteBatch.Draw(sprite.texture, movement.position, Color.White);
            }
        }

        public static void DestroyAll()
        {
            foreach (AnimatedSprite sprite in components)
            {
                sprite.texture.Dispose();
                // TODO: idfk
            }
        }
    }
    class PhysicsSystem : ComponentSystem<Physics> { }
}
