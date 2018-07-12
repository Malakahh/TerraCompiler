using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using TerraCompiler.Common;

namespace TerraCompiler.WorldOfWarcraft
{
    class TypeChecker : ITerraListener
    {
        public void EnterAssignment([NotNull] TerraParser.AssignmentContext context)
        {
            TerraParser.IdentifierContext[] identifiers = context.identifier();
            string lhs = identifiers[0].GetText();

            // Sanity check for lhs
            if (lhs == null || lhs == "")
            {
                throw new Exception("Left hand side not valid during assignment");
            }

            Identifier id = new Identifier();
            id.Scope = Scope.Current;
            id.Name = lhs;

            if (identifiers.Length > 1 && identifiers[1] != null)
            {
                Identifier rhs = IdentifierTable.FindWithinScope(identifiers[1].GetText(), Scope.Current);
                if (rhs == null)
                {
                    throw new Exception("Right hand side identifier not defined.");
                }

                id.Type = rhs.Type;
                id.Context = identifiers[1];
            }
            else if (context.identifierChain() != null)
            {
                // Split up chain

                Identifier rhs = IdentifierTable.FindWithinScope(context.;
                if (rhs == null)
                {
                    throw new Exception("Right hand side identifier not defined.");
                }

                id.Type = Common.Type.Identifier;
                id.Context = context.identifierChain();
            }
            else if (context.@string() != null)
            {
                id.Type = Common.Type.String;
                id.Context = context.@string();
            }
            else if (context.integer() != null)
            {
                id.Type = Common.Type.Int;
                id.Context = context.integer();
            }
            else if (context.@float() != null)
            {
                id.Type = Common.Type.Float;
                id.Context = context.@float();
            }
            else if (context.boolean() != null)
            {
                id.Type = Common.Type.Boolean;
                id.Context = context.boolean();
            }
            else if (context.collection() != null)
            {
                id.Type = Common.Type.Collection;
                id.Context = context.collection();
            }
            else if (context.point() != null)
            {
                id.Type = Common.Type.Point;
                id.Context = context.point();
            }
            else
            {
                throw new Exception("Right hand side not valid during assignment.");
            }

            IdentifierTable.Add(id);
        }

        public void EnterBlock([NotNull] TerraParser.BlockContext context)
        {
            Scope.Enter();
        }

        public void EnterBoolean([NotNull] TerraParser.BooleanContext context)
        {
            
        }

        public void EnterCollection([NotNull] TerraParser.CollectionContext context)
        {
            
        }

        public void EnterDefinition([NotNull] TerraParser.DefinitionContext context)
        {
            
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            
        }

        public void EnterFileName([NotNull] TerraParser.FileNameContext context)
        {
            
        }

        public void EnterFloat([NotNull] TerraParser.FloatContext context)
        {
            
        }

        public void EnterIdentifier([NotNull] TerraParser.IdentifierContext context)
        {
            
        }

        public void EnterIdentifierChain([NotNull] TerraParser.IdentifierChainContext context)
        {
            
        }

        public void EnterInclude([NotNull] TerraParser.IncludeContext context)
        {
            
        }

        public void EnterInteger([NotNull] TerraParser.IntegerContext context)
        {
            
        }

        public void EnterPath([NotNull] TerraParser.PathContext context)
        {
            
        }

        public void EnterPathExpression([NotNull] TerraParser.PathExpressionContext context)
        {
            
        }

        public void EnterPoint([NotNull] TerraParser.PointContext context)
        {
            
        }

        public void EnterStart([NotNull] TerraParser.StartContext context)
        {
            Scope.Enter();
        }

        public void EnterStatement([NotNull] TerraParser.StatementContext context)
        {
            
        }

        public void EnterString([NotNull] TerraParser.StringContext context)
        {
            
        }

        public void EnterWindow([NotNull] TerraParser.WindowContext context)
        {
            
        }

        public void ExitAssignment([NotNull] TerraParser.AssignmentContext context)
        {
            
        }

        public void ExitBlock([NotNull] TerraParser.BlockContext context)
        {
            Scope.Exit();
        }

        public void ExitBoolean([NotNull] TerraParser.BooleanContext context)
        {
            
        }

        public void ExitCollection([NotNull] TerraParser.CollectionContext context)
        {
            
        }

        public void ExitDefinition([NotNull] TerraParser.DefinitionContext context)
        {
            
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            
        }

        public void ExitFileName([NotNull] TerraParser.FileNameContext context)
        {
            
        }

        public void ExitFloat([NotNull] TerraParser.FloatContext context)
        {
            
        }

        public void ExitIdentifier([NotNull] TerraParser.IdentifierContext context)
        {
            
        }

        public void ExitIdentifierChain([NotNull] TerraParser.IdentifierChainContext context)
        {
            
        }

        public void ExitInclude([NotNull] TerraParser.IncludeContext context)
        {
            
        }

        public void ExitInteger([NotNull] TerraParser.IntegerContext context)
        {
            
        }

        public void ExitPath([NotNull] TerraParser.PathContext context)
        {
            
        }

        public void ExitPathExpression([NotNull] TerraParser.PathExpressionContext context)
        {
            
        }

        public void ExitPoint([NotNull] TerraParser.PointContext context)
        {
            
        }

        public void ExitStart([NotNull] TerraParser.StartContext context)
        {
            Scope.Exit();
        }

        public void ExitStatement([NotNull] TerraParser.StatementContext context)
        {
            
        }

        public void ExitString([NotNull] TerraParser.StringContext context)
        {
            
        }

        public void ExitWindow([NotNull] TerraParser.WindowContext context)
        {
            
        }

        public void VisitErrorNode(IErrorNode node)
        {
            
        }

        public void VisitTerminal(ITerminalNode node)
        {
            
        }
    }
}
