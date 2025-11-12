using MohawkGame2D;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace _2D_Game_Assignment
{
    internal class CircleObstacle
    {
        Vector2 point;  
        public Vector2 position;
        public float radius = 40f;
        public Color colorObs = Color.Blue;


        public Color[] circleColor =
            [
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Cyan,
            Color.Magenta,
            Color.Gray,
            Color.White,
            Color.Black
        ];
        public void Setup(CircleObstacle[] allCircles, int currentIndex)
        {
            colorObs = circleColor[MohawkGame2D.Random.Integer(circleColor.Length)];
            bool overlapping;
            int attempts = 0;

            do
            {
                overlapping = false;
                position = Random.Vector2(760, 560); 
                attempts++;

               
                for (int i = 0; i < currentIndex; i++)
                {
                   

                    float distance = Vector2.Distance(position, allCircles[i].position);
                    if (distance < radius + allCircles[i].radius)
                    {
                        overlapping = true;
                        break;
                    }
                }

             

            } while (overlapping);


        }


        public void Update()
        {
          bool isPointInCircle = Vector2.Distance(point,position) <= radius;


            Draw.FillColor = colorObs;
            Draw.Circle(position.X, position.Y, radius);

        }

      
    }
}
