using MohawkGame2D;
using System;
using System.Numerics;

namespace _2D_Game_Assignment
{
    internal class Player2
    {
        Vector2 circle = new Vector2(600, 200);

        float circleSpeed = 2.5f;
        int circleSize = 20;
        public Color circleColor;

        public Color[] playerColor =
            [
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Cyan,
            Color.Magenta,

        ];

        public void Setup()
        {
            //randomizes colour
            circleColor = playerColor[MohawkGame2D.Random.Integer(playerColor.Length)];
        }
        
        public void Update()
        {
            Draw.FillColor = circleColor;
            Draw.Circle(circle.X, circle.Y, circleSize);
            CircleMovement();

        }



        // manages the players movement
        public void CircleMovement()
        {
            Vector2 input = Vector2.Zero;



            // if press (key), move in that direction
           // move up
            if (Input.IsKeyboardKeyDown(KeyboardInput.I))
            {
                input.Y -= circleSpeed;
            }
          // move down
            if (Input.IsKeyboardKeyDown(KeyboardInput.K))
            {
                input.Y += circleSpeed;
            }
           // move left
            if (Input.IsKeyboardKeyDown(KeyboardInput.J))
            {
                input.X -= circleSpeed;
            }
            
            //move right
            if (Input.IsKeyboardKeyDown(KeyboardInput.L))
            {
                input.X += circleSpeed;
            }
          // normalzies speed, so it dosnt move faster on a angle
            if (input != Vector2.Zero)
            {
                input = Vector2.Normalize(input);
            }

            circle += input * circleSpeed;

         // stops player from going out of bounds
            if (circle.X < circleSize)
            {
                circle.X = circleSize;
            }


            if (circle.X > 800 - circleSize)
            {
                circle.X = 800 - circleSize;
            }


            if (circle.Y < 75 + circleSize)
            {
                circle.Y = 75 + circleSize;
            }


            if (circle.Y > 600 - circleSize)
            {
                circle.Y = 600 - circleSize;
            }
        }

        //manages if the circles are touching
        public bool IsTouching(CircleObstacle othercircle)
        {

            float distance = Vector2.Distance(circle, othercircle.position);

            return distance <= (circleSize + othercircle.radius);

        }
        public bool IsTouching(CircleObstacle[] circles)
        {
            foreach (CircleObstacle circ in circles)
            {
                if (IsTouching(circ))
                    return true;
            }
            return false;
        }

      //when reset is called, sets player back to starting position
        public void Reset(Vector2 startPos)
        {
            circle = startPos;
        }

    }
}
