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
        Dictionary<string, Common.Type> symbolTable = new Dictionary<string, Common.Type>();

        public void EnterBlock([NotNull] TerraParser.BlockContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterCollection([NotNull] TerraParser.CollectionContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterDefinition([NotNull] TerraParser.DefinitionContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            throw new NotImplementedException();
        }

        public void EnterFileName([NotNull] TerraParser.FileNameContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterIdentifier([NotNull] TerraParser.IdentifierContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterInclude([NotNull] TerraParser.IncludeContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterNumber([NotNull] TerraParser.NumberContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterPath([NotNull] TerraParser.PathContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterPathExpression([NotNull] TerraParser.PathExpressionContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterPoint([NotNull] TerraParser.PointContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStart([NotNull] TerraParser.StartContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterStatement([NotNull] TerraParser.StatementContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterString([NotNull] TerraParser.StringContext context)
        {
            throw new NotImplementedException();
        }

        public void EnterWindow([NotNull] TerraParser.WindowContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitBlock([NotNull] TerraParser.BlockContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitCollection([NotNull] TerraParser.CollectionContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitDefinition([NotNull] TerraParser.DefinitionContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            throw new NotImplementedException();
        }

        public void ExitFileName([NotNull] TerraParser.FileNameContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitIdentifier([NotNull] TerraParser.IdentifierContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitInclude([NotNull] TerraParser.IncludeContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitNumber([NotNull] TerraParser.NumberContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitPath([NotNull] TerraParser.PathContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitPathExpression([NotNull] TerraParser.PathExpressionContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitPoint([NotNull] TerraParser.PointContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStart([NotNull] TerraParser.StartContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitStatement([NotNull] TerraParser.StatementContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitString([NotNull] TerraParser.StringContext context)
        {
            throw new NotImplementedException();
        }

        public void ExitWindow([NotNull] TerraParser.WindowContext context)
        {
            throw new NotImplementedException();
        }

        public void VisitErrorNode(IErrorNode node)
        {
            throw new NotImplementedException();
        }

        public void VisitTerminal(ITerminalNode node)
        {
            throw new NotImplementedException();
        }
    }
}
