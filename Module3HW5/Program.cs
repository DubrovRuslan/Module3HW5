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
            var textTask = RunAsync();
            Console.WriteLine(textTask.Result);
        }

        public static async Task<string> ReadHelloAsync(string helloFilePath)
        {
            return await Task.Run(() => File.ReadAllText(helloFilePath));
        }

        public static async Task<string> ReadWorldAsync(string worldFilePath)
        {
            return await Task.Run(() => File.ReadAllText(worldFilePath));
        }

        public static async Task<string> RunAsync()
        {
            var task1 = ReadHelloAsync(_helloFilePath);
            var task2 = ReadWorldAsync(_worldFilePath);
            var result = await Task.WhenAll(task1, task2);
            return string.Join(" ", result);
        }
    }
}
