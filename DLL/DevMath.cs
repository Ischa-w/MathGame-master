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
            float finalValue;

            finalValue = a + (b - a) * t; 

            return finalValue; 
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            double distance;
            distance = (startVelocity * time) + (0.5 * acceleration * time * time);
            return (float)distance;
                
        }

        public static float Clamp(float value, float min, float max)
        {
            float theValue;

            theValue = value;

            if (value < min)  //if statement het beste?? //Is dit wat ik hier uberhoubt meot doen??
            {
                theValue = min;
            }
            else if (value > max)
            {
                theValue = max;
            }

            return theValue;
        }

        public static float RadToDeg(float angle)
        {
            float degrees;
            degrees = (float)(angle * (180 / Math.PI));

            return degrees;

        }

        public static float DegToRad(float angle)
        {
            float Radials;
            Radials = (float)(angle * (Math.PI/ 180));

            return Radials;
        }
    }
}
