
using _2D_Game_Assignment;
using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text.RegularExpressions;


namespace MohawkGame2D
{
    
    public class Game
    {
       Player1 player1 = new Player1();
       Player2 player2 = new Player2();
        CircleObstacle[] circle = new CircleObstacle[20];
       

        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Shape Shuffle");
            player1.Setup();
            player2.Setup();
            for (int i = 0; i < circle.Length; i++)
            {
                circle[i] = new CircleObstacle();
                circle[i].Setup(circle, i);
            }
            
            

        }




        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            Draw.FillColor = Color.Gray;
            Draw.Rectangle(0, 0, 800, 75);
            for (int i = 0; i < circle.Length; i++)
            {
                circle[i].Update();
            }
            player1.Update();
            player2.Update();
            CircleMatch();
           
        }

        public void Reset()
        {
            player1.Setup();
            player2.Setup();

            for (int i = 0; i < circle.Length; i++)
            {
                circle[i].Setup(circle, i);
            }
        }


        public void CircleMatch()
        {
            int size = 75;
            bool isPlayer1Touching = false;
            bool isPlayer2Touching = false;

            for (int i = 0; i < circle.Length; i++)
            {
                if (player1.circleColor == circle[i].color && player1.IsTouching(circle[i]))
                {
                    
                    isPlayer1Touching = true;
                    break; 
                }
      
            }

            for (int i = 0; i < circle.Length; i++)
            {
                if (player2.circleColor == circle[i].color && player2.IsTouching(circle[i]))
                {
                    isPlayer2Touching = true;
                    break;
                }

            }

            if (isPlayer1Touching)
            {
                Draw.FillColor = Color.Green;
                Draw.Rectangle(200, 0, size, size);
            }
            else
            {
                Draw.FillColor = Color.Red;
                Draw.Rectangle(200, 0, size, size);
            }

            if (isPlayer2Touching)
            {
                Draw.FillColor = Color.Green;
                Draw.Rectangle(550, 0, size, size);
            }
            else
            {
                Draw.FillColor = Color.Red;
                Draw.Rectangle(550, 0, size, size);
            }


        }


            
                

            
        

    }

}
