using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DXGI;
using System.Transactions;
using System.DirectoryServices;

namespace ReverieGame.Components
{
    internal class Physics : Component
    {

        public Vector2 velocity = Vector2.Zero;
        public Vector2 direction = new Vector2(0, 0);

        private float magnitude = 0f;

        public float friction { get; set; }
        public float acceleration { get; set; }
        public float maxSpeed { get; set; }

        public bool runToggle { get; set; } 

        private Transform transform;

        public Physics()
        {
            PhysicsSystem.Register(this);
        }

        public override void Initialise()
        {
            transform = this.entity.GetComponent<Transform>();
            base.Initialise();
        }

        public override void Update(GameTime gameTime)
        {
            var deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            Vector2 dMaxSpeed = new Vector2(maxSpeed * deltaTime, maxSpeed* deltaTime);
            Vector2 absDirection = new Vector2(Math.Abs(direction.X), Math.Abs(direction.Y));

            if (direction != Vector2.Zero)
            {
                direction.Normalize();
                absDirection.Normalize();

                velocity += acceleration * direction * deltaTime;
                velocity = Vector2.Clamp(velocity, absDirection * dMaxSpeed * -1, dMaxSpeed * absDirection);

            }

            if (direction.X == 0) { velocity.X = Decelerate(velocity.X, friction * deltaTime); }
            if (direction.Y == 0) { velocity.Y = Decelerate(velocity.Y, friction * deltaTime); }

            transform.position += velocity;

            Console.WriteLine(deltaTime);
 
        }

        private float Decelerate(float val, float amount)
        {
            if (val > 0f && (val -= amount) < 0f) return 0f;
            if (val < 0f && (val += amount) > 0f) return 0f;
            return val;
        }

        public Vector2 ClampMagnitude(Vector2 value1, Vector2 min, Vector2 max)
        {
            return new Vector2(MathHelper.Clamp(value1.X, min.X, max.X), MathHelper.Clamp(value1.Y, min.Y, max.Y));
        }
    }
}
