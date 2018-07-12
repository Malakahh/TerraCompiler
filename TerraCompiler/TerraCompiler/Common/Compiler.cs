using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraCompiler.Common
{
    abstract class Compiler
    {
        public IAntlrErrorStrategy ErrorHandler;

        public abstract void Run(TerraParser parser);
    }
}
