using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DXGI;
using System.Transactions;

namespace ReverieGame.Components
{
    internal class Physics : Component
    {

        public Vector2 velocity = Vector2.Zero;
        public float friction = 2f;
        public float acceleration = 100f;

        public float maxSpeed = 200f;


        public Vector2 direction = new Vector2(0, 0);

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
            var deltaTime = (float) gameTime.ElapsedGameTime.TotalSeconds;

            if (direction != Vector2.Zero)
            {
                direction.Normalize();
                velocity += direction * acceleration * deltaTime;
            } else
            {
                velocity = Vector2.Zero;
            }


            transform.position += velocity * (float) gameTime.ElapsedGameTime.TotalSeconds;

            Console.WriteLine(velocity.ToString());

            /*velocity.X = Decelerate(velocity.X, deceleration);
            velocity.Y = Decelerate(velocity.Y, deceleration);*/

            //velocity = Vector2.Zero;

 
        }

        private float Decelerate(float val, float amount)
        {
            if (val > 0f && (val -= amount) < 0f) return 0f;
            if (val < 0f && (val += amount) > 0f) return 0f;
            return val;
        }
    }
}
