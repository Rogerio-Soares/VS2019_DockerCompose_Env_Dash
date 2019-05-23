using Microsoft.Extensions.Configuration;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            foreach (var c in config.AsEnumerable())
            {
                Console.WriteLine($"{c.Key} ==> {c.Value}");
            }
        }
    }
}
