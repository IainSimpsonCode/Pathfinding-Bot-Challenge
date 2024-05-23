using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Program_Simulator
{
    internal class Square
    {
        public Vector2 Coordinates;

        public Vector2 Position; // X and Y are top left of the square

        public int Width;
        public int Height;

        public int Weight = 0;

        public Square()
        {

        }

        public Square(Vector2 coordinates, Vector2 position, int width, int height) 
        {
            Coordinates = coordinates;
            Position = position;
            Width = width;
            Height = height;
        }

        
    }
}
