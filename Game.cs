
using _2D_Game_Assignment;
using System;
using System.Numerics;


namespace MohawkGame2D
{
    
    public class Game
    {
       Player1 player1 = new Player1();
       CircleObstacle[] circle = new CircleObstacle[20];

        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Shape Shuffle");
            for (int i = 0; i < circle.Length; i++)
            {
                circle[i] = new CircleObstacle();
                circle[i].Setup();
            }
            player1.Setup();
            
        }

        
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            for (int i = 0; i < circle.Length; i++)
            {
                circle[i].Update();
            }
            player1.Update();
            int size = 75;

            if (player1.IsTouching(circle))
            {
                Draw.FillColor = Color.Green;
                Draw.Rectangle(400, 20, size,size);
            }
            
            else
            {
                Draw.FillColor = Color.Red;
                Draw.Rectangle(400, 20, size, size);
            }
        }

       

            
                

            
        

    }

}
