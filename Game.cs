
using _2D_Game_Assignment;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;


namespace MohawkGame2D
{
    
    public class Game
    {
       Player1 player1 = new Player1();
       CircleObstacle obstacle = new CircleObstacle();
        CircleObstacle[] circle = new CircleObstacle[20];
       

        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Shape Shuffle");
            player1.Setup();
            for (int i = 0; i < circle.Length; i++)
            {
                circle[i] = new CircleObstacle();
                circle[i].Setup(circle, i);
            }
           
        }




        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            for (int i = 0; i < circle.Length; i++)
            {
                circle[i].Update();
            }
            player1.Update();
            CircleMatch();
        }

        public void CircleMatch()
        {
            int size = 75;
            if (player1.circleColor == obstacle.colorObs && player1.IsTouching(obstacle))
            {
                Draw.FillColor = Color.Green;
                Draw.Rectangle(400, 20, size, size);
            }
            else
            {
                Draw.FillColor = Color.Red;
                Draw.Rectangle(400, 20, size, size);
            }
        }


            
                

            
        

    }

}
