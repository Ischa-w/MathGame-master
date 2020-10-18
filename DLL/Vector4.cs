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
            get {
                float mag;

                mag = (float)Math.Sqrt(x * x + y * y + z * z + w * w);

                return mag;
            }
        }

        public Vector4 Normalized
        {
            get {
                float normX;
                float normY;
                float normZ;
                float normW;

                normX = x / Magnitude;
                normY = y / Magnitude;
                normZ = z / Magnitude;
                normW = w / Magnitude;

                return new Vector4(normX, normY, normZ, normW);
            }
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
            throw new NotImplementedException();
        }

        public static float Dot(Vector4 lhs, Vector4 rhs)
        {
            float product;

            product = lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;

            return product;
        }

        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            float lerp1;
            float lerp2;
            float lerp3;
            float lerp4;

            lerp1 = t * (b.x - a.x) + a.x;
            lerp2 = t * (b.y - a.y) + a.y;
            lerp3 = t * (b.z - a.z) + a.z;
            lerp4 = t * (b.w - a.w) + a.w;

            return new Vector4(lerp1, lerp2, lerp3, lerp4);
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4((lhs.x + rhs.x), (lhs.y + rhs.y), (lhs.z + rhs.z), (lhs.w + rhs.w));
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4((lhs.x - rhs.x), (lhs.y - rhs.y), (lhs.z - rhs.z), (lhs.w - rhs.w));
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
            return new Vector4(lhs.x / scalar, lhs.y / scalar, lhs.z / scalar, lhs.w / scalar);
        }
    }
}
