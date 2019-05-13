using System;

namespace MultiFrameworkTargets
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            var settings = new Settings();
            var settings2 = new CompilerFlagBasedSettings();

            Console.WriteLine("Hello World");

            Console.WriteLine($"Built with {settings.Framework}");
            Console.WriteLine($"With compiler flag {settings2.CompiledAgainst}");

            Console.ReadLine();
        }
    }
}
