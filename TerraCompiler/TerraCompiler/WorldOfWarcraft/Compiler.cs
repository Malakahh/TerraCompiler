using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraCompiler.WorldOfWarcraft
{
    class Compiler : TerraCompiler.Common.Compiler
    {
        private List<ITerraListener> Passes = new List<ITerraListener>();

        public Compiler()
        {
            this.ErrorHandler = new ErrorStrategy();

            Passes.Add(new TypeChecker());
        }

        public override void Run(TerraParser parser)
        {
            ParseTreeWalker walker = new ParseTreeWalker();
            foreach (ITerraListener pass in Passes)
            {
                walker.Walk(pass, parser.start());
                parser.Reset();
            }
        }
    }
}
