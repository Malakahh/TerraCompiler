using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraCompiler.Common
{
    class IdentifierTable
    {
        Dictionary<string, (Identifier id, uint scope)> Identifiers = new Dictionary<string, (Identifier id, uint scope)>();

        public void Add(Identifier id)
        {
            Identifiers.Add(id);
        }
    }
}
