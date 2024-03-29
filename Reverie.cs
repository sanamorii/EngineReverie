﻿using ReverieGame.Components;
using ReverieGame.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.DXGI;
using System.Windows.Forms.VisualStyles;
using System;
using System.Net.NetworkInformation;

namespace ReverieGame
{
    public class Reverie : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private KeyboardState keyboardPrev = new KeyboardState();
        private MouseState mousePrev = new MouseState();
        private GamePadState gamePadPrev = new GamePadState();

        private Texture2D texture;
        private Player player;
        private Stone stone;

        public Reverie()
        {

            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.IsFullScreen = false;
            graphics.SynchronizeWithVerticalRetrace = true;

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            player = new Player();
            //stone = new Stone();
            player.Initialise();
            //stone.Initialise();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player.LoadContent(Content);
            //stone.LoadContent(Content);


            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            spriteBatch.Dispose();
            AnimatedSpriteSystem.DestroyAll();
        }

        protected override void Update(GameTime gameTime)
        {
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            //    Exit();

            // TODO: Add your update logic here

            ControllerSystem.Update(gameTime);
            PhysicsSystem.Update(gameTime);
            TransformSystem.Update(gameTime);
            AnimatedSpriteSystem.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            AnimatedSpriteSystem.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}