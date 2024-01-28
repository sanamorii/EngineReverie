using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Components
{
    internal class PlayerControllable : Component
    {
        //private KeyboardState _prevKeyboardState = new KeyboardState();
        //private MouseState _prevMouseState = new MouseState();
        //private GamePadState _gamePadState => GamePad.GetState();

        private Physics physics;

        public PlayerControllable()
        {
            ControllerSystem.Register(this);
        }

        public override void Initialise()
        {
            physics = this.entity.GetComponent<Physics>();

            base.Initialise();
        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                physics.direction.Y = -1;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                physics.direction.Y = 1;
            }
            else
            {
                physics.direction.Y = 0;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                physics.direction.X = -1;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                physics.direction.X = 1;
            }
            else
            {
                physics.direction.X = 0;
            }
            base.Update(gameTime);
        }


    }
}
