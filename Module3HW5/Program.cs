using System;
using System.IO;
using System.Threading.Tasks;

namespace Module3HW5
{
    public class Program
    {
        private const string _helloFilePath = "hello.txt";
        private const string _worldFilePath = "world.txt";
        public static void Main(string[] args)
        {
            var textTask = Run();
            Console.WriteLine(textTask.Result);
        }

        public static async Task<string> ReadHello(string helloFilePath)
        {
            return await Task.Run(() => File.ReadAllText(helloFilePath));
        }

        public static async Task<string> ReadWorld(string worldFilePath)
        {
            return await Task.Run(() => File.ReadAllText(worldFilePath));
        }

        public static async Task<string> Run()
        {
            var helloText = await ReadHello(_helloFilePath);
            var worldText = await ReadWorld(_worldFilePath);
            return $"{helloText} {worldText}";
        }
    }
}
