using MohawkGame2D;
using System;
using System.Numerics;

namespace _2D_Game_Assignment
{
    internal class Player1
    {
        Vector2 circle = new Vector2 (200,200);
 
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
            Draw.Circle(circle.X, circle.Y, circleSize);
            CircleMovement();
           
            
            string text = $"{circle.X},{circle.Y}";
            Text.Color = Color.Red;
            Text.Draw(text, 10, 10);
        }
        
        
        
        
        public void CircleMovement()
        {
            Vector2 input = Vector2.Zero;

           


            if (Input.IsKeyboardKeyDown(KeyboardInput.W))
            {
                input.Y -= circleSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                input.Y += circleSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                input.X -= circleSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                input.X += circleSpeed;
            }
            if (input != Vector2.Zero)
            {
                input = Vector2.Normalize(input);
            }
       
            circle += input * circleSpeed;
        }

        public bool IsTouching(CircleObstacle othercircle)
        {
           
            float distance = Vector2.Distance(circle,othercircle.position);

            return distance <= (circleSize + othercircle.radius);
        }
        public bool IsTouching(CircleObstacle[] circles)
        {
            foreach (var c in circles)
            {
                if (IsTouching(c)) 
                    return true;
            }
            return false;
        }


    }
}
 