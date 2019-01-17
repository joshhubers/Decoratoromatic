using System;
using System.IO;

namespace Decoratoromatic
{
    class Program
    {
        static void Main(string[] args)
        {
          CheckArgs(args);

          string sourceFile = args[0];
          string destinationFile = args[1];
          string decoratorClassName = destinationFile.Split(".")[0];

          string rawText = ReadCSharpFile(sourceFile);

          Decorator decorator = new Decorator(rawText);
          string decoratedText = decorator.Generate(decoratorClassName);

          WriteCSharpFile(destinationFile, decoratedText);
        }

        private static void CheckArgs(string[] arguments)
        {
          if(arguments.Length != 2)
          {
            throw new Exception("Args not provided");
          }
        }

        private static void WriteCSharpFile(string fileLocation, string text)
        {
          File.WriteAllText(fileLocation, text);
        }

        private static string ReadCSharpFile(string fileLocation)
        {
          return File.ReadAllText(fileLocation);
        }
    }
}
