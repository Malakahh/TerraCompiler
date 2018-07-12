using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraCompiler.Common
{
    class Identifier
    {
        public Common.Type Type { get; set; }
        public string Name { get; set; }
        public Scope Scope { get; set; }
        public ParserRuleContext Context { get; set; }
        public string FrameType { get; set; }

        public Identifier()
        {

        }
    }
}
