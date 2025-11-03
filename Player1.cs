using MohawkGame2D;
using System;
using System.Numerics;

namespace _2D_Game_Assignment
{
    internal class Player1
    {

        float circleX = 300f;
        float circleY = 500f;
        float circleSpeed = 5f;
        int circleSize = 20;
        public Color circleColor = Color.Black;

        Color[] playerColor = 
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
        
        public void Setup()
        {
            circleColor = playerColor[MohawkGame2D.Random.Integer(playerColor.Length)];
        }
        public void Update()    
        {
            Draw.FillColor = circleColor;
            Draw.Circle(circleX, circleY, circleSize);
            CircleMovement();
           
            
            string text = $"{circleX},{circleY}";
            Text.Color = Color.Red;
            Text.Draw(text, 10, 10);
        }
        
        
        
        
        public void CircleMovement()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.W))
            {
                circleY -= circleSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                circleY += circleSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                circleX -= circleSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                circleX += circleSpeed;
            }

           
        }
    }
}
