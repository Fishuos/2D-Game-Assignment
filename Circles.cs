using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using MohawkGame2D;

namespace _2D_Game_Assignment
{
    internal class CircleObstacle
    {
        Vector2 point;  
        public Vector2 position;
        public float radius = 40f;
        public Color color = Color.Blue;

        public void Setup()
        {
            position = Random.Vector2(760, 560);
        }

        public void Update()
        {
          bool isPointInCircle = Vector2.Distance(point,position) <= radius;
          
            
            Draw.FillColor = color;
            Draw.Circle(position.X, position.Y, radius);

        }

        
            

            

    }
}
