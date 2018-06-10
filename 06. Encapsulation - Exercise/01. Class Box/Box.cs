namespace _01._Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public double CalculateSurfaceArea()
        {
            var surfaceArea = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return surfaceArea;
        }

        public double CalculateLateralSurfaceArea()
        {
            var lateralSurfaceArea = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return lateralSurfaceArea;
        }

        public double CalculateVolume()
        {
            var volume = this.Length * this.Height * this.Width;
            return volume;
        }
    }
}