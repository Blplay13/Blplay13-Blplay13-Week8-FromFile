using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuck_Norris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomJoke;
            randomJoke = GetRandomFromFile("chuck");
            Console.WriteLine($"{randomJoke}.");
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\Samples\chuck.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
    }
}
