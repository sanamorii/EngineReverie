using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Components
{
    internal class KeyboardController : Component
    {
        //private KeyboardState _prevKeyboardState = new KeyboardState();
        //private MouseState _prevMouseState = new MouseState();
        //private GamePadState _gamePadState => GamePad.GetState();

        private Physics physics;
        private float old;

        public KeyboardController()
        {
            ControllerSystem.Register(this);
        }

        public override void Initialise()
        {
            physics = this.entity.GetComponent<Physics>();
            old = physics.maxSpeed; 

            base.Initialise();
        }

        public override void Update(GameTime gameTime)
        {
            int up = Keyboard.GetState().IsKeyDown(Keys.W) ? 1 : 0;
            int down = Keyboard.GetState().IsKeyDown(Keys.S) ? 1 : 0;

            int left = Keyboard.GetState().IsKeyDown(Keys.A) ? 1 : 0;
            int right = Keyboard.GetState().IsKeyDown(Keys.D) ? 1 : 0;

            bool run = Keyboard.GetState().IsKeyDown(Keys.LeftShift) ? true : false;

            if (run == true)
            {
                physics.maxSpeed = old * 1.5f;
            } else
            {
                physics.maxSpeed = old;
            }

            physics.direction.X = right - left;
            physics.direction.Y = down - up;

            base.Update(gameTime);
        }


    }
}
