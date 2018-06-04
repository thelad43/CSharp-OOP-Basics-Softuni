namespace _15._Drawing_Tool
{
    using System;

    public class Square : IFigure
    {
        public Square()
        {
        }

        public Square(int side)
        {
            this.Side = side;
        }

        public int Side { get; set; }

        public void Draw()
        {
            Console.WriteLine($"|{new string('-', this.Side)}|");

            for (int i = 0; i < this.Side - 2; i++)
            {
                Console.WriteLine($"|{new string(' ', this.Side)}|");
            }

            Console.WriteLine($"|{new string('-', this.Side)}|");
        }
    }
}