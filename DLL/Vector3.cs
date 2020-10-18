using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public float Magnitude
        {
            get
            {   //mag dit wel?????????
                float mag;

                mag = (float)Math.Sqrt(x * x + y * y + z * z);

                return mag;
            }
        }

        public Vector3 Normalized
        {
            get {
                float normX;
                float normY;
                float normZ;

                normX = x / Magnitude;
                normY = y / Magnitude;
                normZ = z / Magnitude;

                return new Vector3(normX, normY, normZ);
            }
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Vector3(Vector2 v)
        {
            throw new NotImplementedException();
        }

        public static float Dot(Vector3 lhs, Vector3 rhs)
        {
            float product;

            product = lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;

            return product;
        }

        public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x * rhs.x, lhs.y * rhs.z, lhs.z * rhs.y);
            
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            float lerp1;
            float lerp2;
            float lerp3;

            lerp1 = t * (b.x - a.x) + a.x;
            lerp2 = t * (b.y - a.y) + a.y;
            lerp3 = t * (b.z - a.z) + a.z;


            return new Vector3(lerp1, lerp2, lerp3);
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.x + rhs.x), (lhs.y + rhs.y), (lhs.z + rhs.z));
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.x - rhs.x), (lhs.y - rhs.y), (lhs.z - rhs.z));
        }

        public static Vector3 operator -(Vector3 v)
        {
            return new Vector3(-v.x, -v.y, -v.z);
        }

        public static Vector3 operator *(Vector3 lhs, float scalar)
        {
            return new Vector3(lhs.x * scalar, lhs.y * scalar, lhs.z *scalar);
        }

        public static Vector3 operator /(Vector3 lhs, float scalar)
        {
            return new Vector3(lhs.x / scalar, lhs.y / scalar, lhs.z / scalar);
        }
    }
}
