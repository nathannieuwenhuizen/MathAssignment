using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DevMath
{
    [System.Serializable]

    public struct Vector2
    {
        public float x;
        public float y;

        public float Magnitude
        {
            get {
                return (float)Math.Sqrt(x * x + y * y);
            }
            set
            {
                float aspect = value / Magnitude ;
                x *= aspect;
                y *= aspect;
            }
        }

        public Vector2 Normalized
        {
            get { return new Vector2( x / Magnitude, y / Magnitude); }
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            return lhs.Normalized.x * rhs.Normalized.x + lhs.Normalized.y * rhs.Normalized.y;
        }
        public static float DotNotNormalized(Vector2 lhs, Vector2 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y;
        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return a * (1 - t) + b * t;
        }

        public static float Angle(Vector2 lhs, Vector2 rhs) //in radians
        {
            float angle = (float)(Math.Atan2(rhs.y, rhs.x) - Math.Atan2(lhs.y, lhs.x));
            return angle;
            //float dot = DotNotNormalized(lhs, rhs);
            //float productOfMagnitudes = (lhs.Normalized.Magnitude * rhs.Normalized.Magnitude);
            //return (float)Math.Acos(  dot / productOfMagnitudes);
        }

        public static Vector2 DirectionFromAngle(float angle) //in radians
        {
            angle = DevMath.DegToRad(angle);
            return new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle));
            throw new NotImplementedException();
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }

        public static Vector2 operator -(Vector2 v)
        {
            return new Vector2(-v.x , -v.y);
        }

        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.x * scalar, lhs.y * scalar);
        }

        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            scalar = 1 / scalar;
            return new Vector2(lhs.x * scalar, lhs.y * scalar);
        }
    }
}
