using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Matrix4x4
    {
        public float[][] m = new float[4][] { new float[4], new float[4], new float[4], new float[4] };

        public Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
        {
            m[1][1] = m11;
            m[1][2] = m12;
            m[1][3] = m13;
            m[1][4] = m14;

            m[2][1] = m21;
            m[2][2] = m22;
            m[2][3] = m23;
            m[2][4] = m24;

            m[3][1] = m31;
            m[3][2] = m32;
            m[3][3] = m33;
            m[3][4] = m34;

            m[4][1] = m41;
            m[4][2] = m42;
            m[4][3] = m43;
            m[4][4] = m44;
        }

        public static Matrix4x4 Identity
        {
            get {
                return new Matrix4x4(1,0,0,0, 0,1,0,0, 0,0,1,0, 0,0,0,1);
            }
        }

        public float Determinant
        {
            get { throw new NotImplementedException(); }
        }

        public Matrix4x4 Inverse
        {
            get { throw new NotImplementedException(); }
        }

        public static Matrix4x4 Translate(Vector3 translation)
        {
            //m[1][4] = translation.x;
            //return m;
            throw new NotImplementedException();
        }

        public static Matrix4x4 Rotate(Vector3 rotation)
        {
            //Er zijn 2 manieren om deze te berekenen
            throw new NotImplementedException();


        }

        public static Matrix4x4 RotateX(float rotation)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x4 RotateY(float rotation)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x4 RotateZ(float rotation)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x4 Scale(Vector3 scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            throw new NotImplementedException();
        }

        public static Vector4 operator *(Matrix4x4 lhs, Vector4 rhs)
        {
            throw new NotImplementedException();
        }
    }
}
