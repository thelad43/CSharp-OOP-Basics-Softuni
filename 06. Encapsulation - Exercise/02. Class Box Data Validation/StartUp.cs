namespace _02._Class_Box_Data_Validation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Box box = null;

            try
            {
                box = new Box(length, width, height);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            var surfArea = box.CalculateSurfaceArea();
            var latSurfArea = box.CalculateLateralSurfaceArea();
            var volume = box.CalculateVolume();

            Console.WriteLine($"Surface Area - {surfArea:F2}");
            Console.WriteLine($"Lateral Surface Area - {latSurfArea:F2}");
            Console.WriteLine($"Volume - {volume:F2}");
        }
    }
}