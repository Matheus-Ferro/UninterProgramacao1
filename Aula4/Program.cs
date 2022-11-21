namespace Pratica4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Aula Prática 4 de C#");
            Console.WriteLine($"---------------------------------------------");
            // ThreadPing exercicio1 = new ThreadPing();
            // exercicio1.StartPing();
            var EThread = new EntendendoThreads();
            EThread.ProgAssincrona();
            var ETask = new EntendendoTasks();
            ETask.ProgAssincrona();
        }
    }
}
