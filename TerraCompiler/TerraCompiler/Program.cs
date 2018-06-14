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
            //string input = "Window { Test }";
            
            AntlrInputStream inputStream = new AntlrInputStream(File.OpenRead(Directory.GetCurrentDirectory() + "/test.terra"));
            TerraLexer terraLexer = new TerraLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(terraLexer);
            TerraParser terraParser = new TerraParser(commonTokenStream); 
            terraParser.ErrorHandler = new err();
            Ehhh ehhh = new Ehhh();

            ParseTreeWalker walker = new ParseTreeWalker();
            walker.Walk(ehhh, terraParser.start());

            Console.ReadKey();
        }
    }
}