using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraCompiler.Common
{
    static class IdentifierTable
    {
        static HashSet<Identifier> Identifiers = new HashSet<Identifier>();

        public static void Add(Identifier id)
        {
            Console.WriteLine($"Adding identifier \"{id.Name}\" with type {id.Type.ToString()} \t\t\t Scope {id.Scope.Name} with depth {id.Scope.Depth}");
            Identifiers.Add(id);
        }

        public static Identifier Find(Func<Identifier, bool> predicate)
        { 
            try
            {
                return Identifiers.First(predicate);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public static Identifier FindWithinScope(string name, Scope scopeToLookIn)
        {
            List<uint> scopes = new List<uint>();
            scopes.Add(scopeToLookIn.Name);
            scopes.AddRange(scopeToLookIn.ancestry);
            foreach (uint s in scopes)
            {
                return Find(i => i.Name == name && i.Scope.Name == s);
            }

            return null;
        }
    }
}
