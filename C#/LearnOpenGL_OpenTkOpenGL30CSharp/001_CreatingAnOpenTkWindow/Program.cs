
namespace _001_CreatingAnOpenTkWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var window = new Window())
            {
                window.Run();
            }
        }
    }
}
