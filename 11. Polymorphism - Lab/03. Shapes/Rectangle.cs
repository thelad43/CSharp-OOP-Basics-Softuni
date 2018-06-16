namespace _03._Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculateArea()
        {
            var area = this.width * this.height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = 2 * (this.width + this.height);
            return perimeter;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}