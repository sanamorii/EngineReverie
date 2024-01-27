using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Components
{
    internal class Input : Component
    {
        private KeyboardState _prevKeyboardState = new KeyboardState();
        private MouseState _prevMouseState = new MouseState();
        //private GamePadState _gamePadState => GamePad.GetState();

        public bool IsPressed { get; private set; }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }


    }
}
