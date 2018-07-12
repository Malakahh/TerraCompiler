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
        public static Scope Current
        {
            get
            {
                return scopeStack.Peek();
            }
        }

        public uint Name { get; private set; }
        public uint[] ancestry;
        public int Depth { get; private set; }

        public Scope()
        {
            Name = totalNumScopes++;
            allScopes.Add(this.Name, this);
            ancestry = scopeStack.Select((s) => s.Name).ToArray();
            Depth = scopeStack.Count;
        }

        public static Scope Enter()
        {
            Scope s = new Scope();
            scopeStack.Push(s);
            return s;
        }

        public static Scope Exit()
        {
            return scopeStack.Pop();
        }
    }
}
