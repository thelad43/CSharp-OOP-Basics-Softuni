namespace _15._Drawing_Tool
{
    using System;

    public class Rectangle : IFigure
    {
        public Rectangle()
        {
        }

        public Rectangle(int sideA, int sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public int SideA { get; set; }

        public int SideB { get; set; }

        public void Draw()
        {
            Console.WriteLine($"|{new string('-', this.SideA)}|");

            for (int i = 0; i < this.SideB - 2; i++)
            {
                Console.WriteLine($"|{new string(' ', this.SideA)}|");
            }

            Console.WriteLine($"|{new string('-', this.SideA)}|");
        }
    }
}