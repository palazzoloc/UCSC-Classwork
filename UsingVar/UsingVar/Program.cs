using System;

namespace MultiArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            //arguments: name, age
            Console.WriteLine("You entered the following {0} command line arguments: ", args.Length);
            for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("Argument[{0}] = [{1}]", i, args[i]);

                }
            Console.Read();                            
        }
    }
}
