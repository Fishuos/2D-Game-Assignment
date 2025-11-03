
using _2D_Game_Assignment;
using System;
using System.Numerics;


namespace MohawkGame2D
{
    
    public class Game
    {
       Player1 player1 = new Player1();
       CircleObstacle circle = new CircleObstacle();

        public void Setup()
        {
            Window.SetSize(1200, 1000);
            Window.SetTitle("Shape Shuffle");
            circle.Setup();
            player1.Setup();
            
        }

        
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            circle.Update();
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
