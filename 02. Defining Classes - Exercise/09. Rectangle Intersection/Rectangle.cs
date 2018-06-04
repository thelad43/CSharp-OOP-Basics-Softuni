namespace _09._Rectangle_Intersection
{
    public class Rectangle
    {
        public Rectangle()
        {
        }

        public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
        }

        public string Id { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double TopLeftX { get; set; }

        public double TopLeftY { get; set; }

        public bool HasIntersect(Rectangle secondRectangle)
        {
            return secondRectangle.TopLeftX + secondRectangle.Width >= this.TopLeftX &&
                secondRectangle.TopLeftX <= this.TopLeftX + this.Width &&
                secondRectangle.TopLeftY >= this.TopLeftY - this.Height &&
                secondRectangle.TopLeftY - secondRectangle.Height <= this.TopLeftY;
        }
    }
}