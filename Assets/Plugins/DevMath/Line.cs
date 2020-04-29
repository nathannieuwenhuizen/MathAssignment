using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Line
    {
        private Vector2 direction;
        public Vector2 Position
        {
            get; set;
        }

        public Vector2 Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        public float Length
        {
            get
            {
                return Direction.Magnitude;
            }
            set
            {
                direction.Magnitude  = value;
            }
        }
    }
}
