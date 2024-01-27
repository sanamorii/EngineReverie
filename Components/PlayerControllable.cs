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



        public override void Initialise()
        {


            base.Initialise();
        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                direction.Y = -1;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                direction.Y = 1;
            }
            else
            {
                direction.Y = 0;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                direction.X = -1;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                direction.X = 1;
            }
            else
            {
                direction.X = 0;
            }
            base.Update(gameTime);
        }


    }
}
