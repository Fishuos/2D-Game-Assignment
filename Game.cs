
using _2D_Game_Assignment;
using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;


namespace MohawkGame2D
{
    
    public class Game
    {
       Player1 player1 = new Player1();
       Player2 player2 = new Player2();
        CircleObstacle[] circle = new CircleObstacle[40];
        bool isPlayer1Touching = false;
        bool isPlayer2Touching = false;

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
            Window.ClearBackground(Color.White);
            Draw.FillColor = Color.Gray;
            Draw.Rectangle(0, 0, 800, 75);
            

            Text.Color = Color.Black;
            Text.Draw("Player 1", 35, 25);
            Text.Draw("Player 2", 645, 25);



            for (int i = 0; i < circle.Length; i++)
                circle[i].Update();

            player1.Update();
            player2.Update();
            CircleMatch();

            if (isPlayer1Touching && isPlayer2Touching)
            {
                Reset();
            }

        }

        public void Reset()
        {
            isPlayer1Touching = false;
            isPlayer2Touching = false;

            for (int i = 0; i < circle.Length; i++)
            {
                circle[i].Setup(circle, i);
            }

            player1.Reset(new Vector2(200, 200));
            player2.Reset(new Vector2(600, 200));

                player1.Setup();
                player2.Setup();

            if (isPlayer1Touching && isPlayer2Touching == true)
            {
                player1.Update();
                player2.Update();

            }
        }


        public void CircleMatch()
        {
            int size = 75;
            

            for (int i = 0; i < circle.Length; i++)
            {
                if (player1.circleColor == circle[i].color && player1.IsTouching(circle[i]))
                {
                    
                    isPlayer1Touching = true;
                    break; 
                }
                else
                {
                    isPlayer1Touching = false;
                }
            }

            for (int i = 0; i < circle.Length; i++)
            {
                if (player2.circleColor == circle[i].color && player2.IsTouching(circle[i]))
                {
                    isPlayer2Touching = true;


                  


                        break;
                }
                else
                {
                    isPlayer2Touching = false;
                }
            }

            if (isPlayer1Touching)
            {
                Draw.LineSize = 0;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(200, 0, size, size);
            }
            else
            {
                Draw.LineSize = 0;
                Draw.FillColor = Color.Red;
                Draw.Rectangle(200, 0, size, size);
            }

            if (isPlayer2Touching)
            {
                Draw.LineSize = 0;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(550, 0, size, size);
            }
            else
            {
                Draw.LineSize = 0;
                Draw.FillColor = Color.Red;
                Draw.Rectangle(550, 0, size, size);
            }


        }


            
                

            
        

    }

}
