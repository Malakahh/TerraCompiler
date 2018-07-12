using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace TerraCompiler
{
    class Program
    {
        static void Main(string[] args)
        {            
            AntlrInputStream inputStream = new AntlrInputStream(File.OpenRead(Directory.GetCurrentDirectory() + "/TestData/test.terra"));
            TerraLexer terraLexer = new TerraLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(terraLexer);
            TerraParser terraParser = new TerraParser(commonTokenStream);

            TerraCompiler.Common.Compiler compiler = new WorldOfWarcraft.Compiler();
            terraParser.ErrorHandler = compiler.ErrorHandler;
            compiler.Run(terraParser);

            Console.ReadKey();
        }
    }
}