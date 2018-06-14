using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace TerraCompiler
{
    class Ehhh : ITerraListener
    {
        public void EnterBlock([NotNull] TerraParser.BlockContext context)
        {
            Console.WriteLine("Enter Block " + context.GetText());
        }

        public void EnterDefinition([NotNull] TerraParser.DefinitionContext context)
        {
            Console.WriteLine("Enter Definition");
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {

        }

        public void EnterFileName([NotNull] TerraParser.FileNameContext context)
        {
            Console.WriteLine("Enter FileName");
        }

        public void EnterInclude([NotNull] TerraParser.IncludeContext context)
        {
            Console.WriteLine("Enter Include");
        }

        public void EnterPath([NotNull] TerraParser.PathContext context)
        {
            Console.WriteLine("Enter Path: " + context.GetText());
        }

        public void EnterPathExpression([NotNull] TerraParser.PathExpressionContext context)
        {
            Console.WriteLine("Enter PathExpression");
        }

        public void EnterStart([NotNull] TerraParser.StartContext context)
        {
            Console.WriteLine("Enter Start");
        }

        public void EnterIdentifier([NotNull] TerraParser.IdentifierContext context)
        {
            Console.WriteLine("Enter Identifier " + context.GetText());
        }

        public void EnterStatement([NotNull] TerraParser.StatementContext context)
        {
            Console.WriteLine("Enter Statement");
        }

        public void EnterWindow([NotNull] TerraParser.WindowContext context)
        {
            Console.WriteLine("Enter Window");
        }

        public void ExitBlock([NotNull] TerraParser.BlockContext context)
        {
            
            Console.WriteLine("Exit Block");
        }

        public void ExitDefinition([NotNull] TerraParser.DefinitionContext context)
        {
            Console.WriteLine("Exit Definition");
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            
        }

        public void ExitFileName([NotNull] TerraParser.FileNameContext context)
        {
            Console.WriteLine("Exit FileName");
        }

        public void ExitInclude([NotNull] TerraParser.IncludeContext context)
        {
            Console.WriteLine("Exit Include");
        }

        public void ExitPath([NotNull] TerraParser.PathContext context)
        {
            Console.WriteLine("Exit Path");
        }

        public void ExitPathExpression([NotNull] TerraParser.PathExpressionContext context)
        {
            Console.WriteLine("Exit PathExpression");
        }

        public void ExitStart([NotNull] TerraParser.StartContext context)
        {
            Console.WriteLine("Exit Start");
        }

        public void ExitIdentifier([NotNull] TerraParser.IdentifierContext context)
        {
            Console.WriteLine("Exit Identifier");        }

        public void ExitStatement([NotNull] TerraParser.StatementContext context)
        {
            Console.WriteLine("Exit Statement");
        }

        public void ExitWindow([NotNull] TerraParser.WindowContext context)
        {
            Console.WriteLine("Exit Window");
        }

        public void VisitErrorNode(IErrorNode node)
        {
            Console.WriteLine("Visit Error Node");
        }

        public void VisitTerminal(ITerminalNode node)
        {
            //Console.WriteLine("Visit Terminal " + node.GetText());
        }
    }
}
