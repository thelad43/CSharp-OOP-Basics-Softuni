namespace _02._Point_in_Rectangle
{
    public class Rectangle
    {
        public Rectangle()
        {
        }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public Point TopLeft { get; set; }

        public Point BottomRight { get; set; }

        // Returns true if the point is inside or is on the side
        public bool Contains(Point point)
        {
            if (point.X >= this.TopLeft.X && point.X <= this.BottomRight.X
                && point.Y >= this.TopLeft.Y && point.Y <= this.BottomRight.Y)
            {
                return true;
            }

            return false;
        }
    }
}