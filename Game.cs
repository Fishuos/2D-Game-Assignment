
using _2D_Game_Assignment;
using System;
using System.Numerics;


namespace MohawkGame2D
{
    
    public class Game
    {
       Player1 player1 = new Player1();
      

        public void Setup()
        {
            Window.SetSize(1200, 1000);
            Window.SetTitle("Shape Shuffle");

        }

        
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
           player1.Update();
           
        }

       

            
                

            
        

    }

}
