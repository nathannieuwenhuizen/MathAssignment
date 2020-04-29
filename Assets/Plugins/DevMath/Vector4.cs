using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public float Magnitude
        {
            get
            {
                return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
            }
            set
            {
                float aspect = value / Magnitude;
                x *= aspect;
                y *= aspect;
                z *= aspect;
                w *= aspect;
            }
        }

        public Vector4 Normalized
        {
            get { return new Vector4(x / Magnitude, y / Magnitude, z / Magnitude, w / Magnitude); }
        }

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static implicit operator Vector4(Vector3 v)
        {
            return new Vector4(v.x, v.y, v.z, 0);
        }

        public static float Dot(Vector4 lhs, Vector4 rhs)
        {
            return lhs.Normalized.x * rhs.Normalized.x + lhs.Normalized.y * rhs.Normalized.y + lhs.Normalized.z * rhs.Normalized.z + lhs.Normalized.w * rhs.Normalized.w;
        }

        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            return a * (1 - t) + b * t;
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }

        public static Vector4 operator -(Vector4 v)
        {
            return new Vector4(-v.x, -v.y, -v.z, -v.w);
        }

        public static Vector4 operator *(Vector4 lhs, float scalar)
        {
            return new Vector4(lhs.x * scalar, lhs.y * scalar, lhs.z * scalar, lhs.w * scalar);
        }

        public static Vector4 operator /(Vector4 lhs, float scalar)
        {
            scalar = 1 / scalar;
            return new Vector4(lhs.x / scalar, lhs.y / scalar, lhs.z / scalar, lhs.w / scalar);
        }
    }
}
