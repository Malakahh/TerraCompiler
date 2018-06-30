using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraCompiler.Common
{
    class ScopeWalker
    {
        public uint ScopeLevel { get; private set; } = 0;

        public void Increment()
        {
            if (ScopeLevel == uint.MaxValue)
            {
                throw new ParseCanceledException("Maximum scope depth reached.");
            }

            ScopeLevel++;
        }

        public void Decrement()
        {
            if (ScopeLevel == 0)
            {
                throw new ParseCanceledException("Minimum scope depth reached, but tried to exit scope.");
            }

            ScopeLevel--;
        }

        public static ScopeWalker operator++(ScopeWalker walker)
        {
            walker.Increment();
            return walker;
        }

        public static ScopeWalker operator--(ScopeWalker walker)
        {
            walker.Decrement();
            return walker;
        }
    }
}
