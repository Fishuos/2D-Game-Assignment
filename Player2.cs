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
            circleColor = playerColor[MohawkGame2D.Random.Integer(playerColor.Length)];
        }
        public void Update()
        {
            Draw.FillColor = circleColor;
            Draw.Circle(circle.X, circle.Y, circleSize);
            CircleMovement();

        }




        public void CircleMovement()
        {
            Vector2 input = Vector2.Zero;




            if (Input.IsKeyboardKeyDown(KeyboardInput.I))
            {
                input.Y -= circleSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.K))
            {
                input.Y += circleSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.J))
            {
                input.X -= circleSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.L))
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

            float distance = Vector2.Distance(circle, othercircle.position);

            return distance <= (circleSize + othercircle.radius);

        }
        public bool IsTouching(CircleObstacle[] circles)
        {
            foreach (CircleObstacle c in circles)
            {
                if (IsTouching(c))
                    return true;
            }
            return false;
        }


    }
}
