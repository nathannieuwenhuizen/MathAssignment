using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class DevMath
    {
        public static float Lerp(float a, float b, float t)
        {
            return a * (1 - t) + b * t;
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time) //needs testing
        {
            float v = startVelocity;
            float a = acceleration;
            float t = time;

            return v * t + .5f * a * (t * t);
        }

        public static float Clamp(float value, float min, float max)
        {
            return Math.Min(max, Math.Max(min, value));
        }

        public static float RadToDeg(float angle)
        {
            //180 graden = pi rad
            // 1 graden = pi / 180 rad
            //1 rad = 180 / pi graden = 57.2
            return angle * (float)(180 / Math.PI);
        }

        public static float DegToRad(float angle)
        {
            return angle * (float)(Math.PI / 180);
        }
    }
}
