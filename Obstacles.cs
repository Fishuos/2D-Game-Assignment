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
        public float radius = 25f;
        public Color color = Color.Blue;

        
        public Color[] circleColor =
            [
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Cyan,
            Color.Magenta,
           
        ];
        //makes circles have position and color / if theyre overlapping
        public void Setup(CircleObstacle[] allCircles, int currentIndex)
        {
            color = circleColor[MohawkGame2D.Random.Integer(circleColor.Length)];
           
            float minY = 30 + 75 / 1f + radius; 
            bool overlapping;
            
            do
            {
                overlapping = false;
                position = new Vector2(
                    Random.Float(radius, 800 - radius),  
                    Random.Float(minY, 600 - radius)     
                );

                
                for (int i = 0; i < currentIndex; i++)
                {
                    if (Vector2.Distance(position, allCircles[i].position) < radius + allCircles[i].radius)
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

            Draw.LineSize = 0;
            Draw.FillColor = color;
            Draw.Circle(position.X, position.Y, radius);

        }

      
    }
}
