using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraCompiler.Common
{
    class Scope
    {
        static Dictionary<uint, Scope> allScopes = new Dictionary<uint, Scope>();
        static uint totalNumScopes = 0;
        static Stack<Scope> scopeStack = new Stack<Scope>();

        public uint Name { get; private set; }
        public uint[] ancestry;
        public int Depth { get; private set; }

        public Scope()
        {
            Name = totalNumScopes++;
            allScopes.Add(this.Name, this);
        }

        public void Enter()
        {
            ancestry = scopeStack.Select((s) => s.Name).ToArray();
            Depth = scopeStack.Count;
        }
    }
}
