using ConsoleApp1.DOs;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static string FilePath = "D:\\Users\\Daniel\\input.json";

        static void Main(string[] args)
        {
            var project = JsonSerializerUtil.JsonDeSerialize<Project>(FilePath);
            Console.WriteLine($"The name of the container project is \"{ project.name }\" ");
            Console.WriteLine($"The name of the container project category is \"{ project.projectCategory.name }\" ");
            Console.ReadLine();
        }
    }
}
