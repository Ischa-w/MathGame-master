using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        }

        public float Acceleration 
        { 
            get; private set; 
        }

        public float mass = 1.0f;

        public float frictionCoefficient;
        public float normalForce;

        public void UpdateVelocityWithForce(Vector2 forceDirection, float forceNewton, float deltaTime)
        {
            float forceFric = normalForce * mass * frictionCoefficient;
            //float forceNet = forceNewton - forceFric; 
            //Acceleration = forceNet / mass;
            Vector2 AccelerationVec;
            AccelerationVec.x = (((forceDirection.x * forceNewton) - forceFric * Velocity.x)/mass) * deltaTime;
            AccelerationVec.y = (((forceDirection.y * forceNewton) - forceFric * Velocity.y) /mass) * deltaTime;
            Velocity = (Velocity + AccelerationVec);
            

            /*float forceFric = normalForce * mass * frictionCoefficient;
            float forceNet = forceNewton - forceFric;
            //Acceleration = forceNet / mass;
            Vector2 AccelerationVec = forceDirection * forceNet * deltaTime;
            Velocity = Velocity + AccelerationVec;*/


            //frictionCoefficient = 100f;
            /*float totalForce = forceNewton - frictionCoefficient * normalForce;
            Acceleration = totalForce / mass;
            Velocity = Velocity + forceDirection * (Acceleration / deltaTime);*/

            /*float totalForce = forceNewton - frictionCoefficient * normalForce;
            Acceleration = totalForce / mass;
            float x = (Acceleration * deltaTime);
            float y = (Acceleration * deltaTime);
            Velocity = Velocity + new Vector2(x,y);*/
        }
    }
}
