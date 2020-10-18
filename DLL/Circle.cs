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
            //circle.Position = new Vector2(2,2);
            //Position = new Vector2(3, 3);
            Vector2 pointsPositions = circle.Position - Position;
            double pointDistance = Math.Sqrt(pointsPositions.x * pointsPositions.x + pointsPositions.y * pointsPositions.y);
            double circleDistance = pointDistance - Radius - circle.Radius;
            if (circleDistance >= 0)
            {return false; } else {return true;}
        }
    }
}
