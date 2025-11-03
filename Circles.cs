using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using MohawkGame2D;

namespace _2D_Game_Assignment
{
    internal class CircleObstacle
    {
        public Vector2 position;
        public float radius = 40f;
        public Color color = Color.Blue;

        public void Setup()
        {
            position = new Vector2(800f, 500f);
        }

        public void Update()
        {
            Draw.FillColor = color;
            Draw.Circle(position.X, position.Y, radius);
        }

        




    }
}
