namespace _03._Student_System
{
    public class StartUp
    {
        public static void Main()
        {
            var studentSystem = new StudentSystem();

            while (true)
            {
                studentSystem.ParseCommand();
            }
        }
    }
}