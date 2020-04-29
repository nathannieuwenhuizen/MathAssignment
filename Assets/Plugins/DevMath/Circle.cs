using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {
            Vector2 delta = Position - circle.Position;
            delta.x = Math.Abs(delta.x);
            delta.y = Math.Abs(delta.y);
            return delta.Magnitude < Radius + circle.Radius;
        }
    }
}
