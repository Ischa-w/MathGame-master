using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector2
    {
        public float x;
        public float y;

        public float Magnitude
        {
            get {return (float)Math.Sqrt((x * x) + (y * y)); }
        }

        public Vector2 Normalized
        {
            get { 
                float normX;
                float normY;

                normX = x / Magnitude;
                normY = y / Magnitude;

                return new Vector2(normX, normY);
            }
             
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            float product;

            product = (lhs.x * rhs.x) + (lhs.y * rhs.y);

            return product;

        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            float lerp1;
            float lerp2;

            lerp1 = t*(b.x - a.x) + a.x;
            lerp2 = t*(b.y - a.y) + a.y;


            return new Vector2(lerp1, lerp2);
        }

        public static float Angle(Vector2 lhs, Vector2 rhs)
        {
            Vector2 v = lhs - rhs;
            return -(float)(Math.Atan2(v.x, v.y)+Math.PI/2);
        }

        public static Vector2 DirectionFromAngle(float angle)
        {
            Vector2 direction;
            direction.x = (float)Math.Cos(DevMath.DegToRad(angle));
            direction.y = (float)Math.Sin(DevMath.DegToRad(angle));
            //direction = new Vector2(20f,1f);
            return direction;
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            float x;
            float y;
            x = lhs.x + rhs.x;
            y = lhs.y + rhs.y;
            return new Vector2(x, y);
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            float x;
            float y;
            x = lhs.x - rhs.x;
            y = lhs.y - rhs.y;
            return new Vector2(x, y);
        }

        public static Vector2 operator -(Vector2 v)
        {
            return new Vector2(-v.x,-v.y);
        }

        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.x * scalar, lhs.y * scalar);
        }

        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.x / scalar, lhs.y / scalar);
        }
    }
}