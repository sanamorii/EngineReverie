using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverieGame.Components
{
    internal class Physics : Component
    {

        public double velocity { get; set; }
        public double friction { get; set; }
        public double acceleration { get; set; }

        public Physics()
        {
            PhysicsSystem.Register(this);
        }
    }
}
