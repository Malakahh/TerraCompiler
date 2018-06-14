using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace TerraCompiler
{
    class err : IAntlrErrorStrategy
    {
        // Tests whether or not recognizer is in the process of recovering from an error. In error recovery mode, Parser.consume() adds symbols to the parse tree by calling Parser.createErrorNode(ParserRuleContext, Token) then ParserRuleContext.addErrorNode(ErrorNode) instead of Parser.createTerminalNode(ParserRuleContext, Token).
        public bool InErrorRecoveryMode(Parser recognizer)
        {
            //throw new NotImplementedException();
            return false;
        }

        // This method is called to recover from exception e. This method is called after reportError(org.antlr.v4.runtime.Parser, org.antlr.v4.runtime.RecognitionException) by the default exception handler generated for a rule method.
        public void Recover(Parser recognizer, RecognitionException e)
        {
            Console.WriteLine("Recover");
            Console.WriteLine(e.Message);
            //throw new NotImplementedException();
        }

        // This method is called when an unexpected symbol is encountered during an inline match operation, such as Parser.match(int). If the error strategy successfully recovers from the match failure, this method returns the Token instance which should be treated as the successful result of the match.
        // This method handles the consumption of any tokens - the caller should not call Parser.consume() after a successful recovery.
        // Note that the calling code will not report an error if this method returns successfully.The error strategy implementation is responsible for calling Parser.notifyErrorListeners(java.lang.String) as appropriate.
        [return: NotNull]
        public IToken RecoverInline(Parser recognizer)
        {
            return recognizer.CurrentToken;
            //throw new NotImplementedException();
        }

        // Report any kind of RecognitionException. This method is called by the default exception handler generated for a rule method.
        public void ReportError(Parser recognizer, RecognitionException e)
        {
            Console.WriteLine($"Error line {e.OffendingToken.Line}: " + e.OffendingToken.Text);
            //throw new NotImplementedException();
        }

        // This method is called by when the parser successfully matches an input symbol.
        public void ReportMatch(Parser recognizer)
        {
            //throw new NotImplementedException();
        }

        // Reset the error handler state for the specified recognizer.
        public void Reset(Parser recognizer)
        {
            throw new NotImplementedException();
        }

        // This method provides the error handler with an opportunity to handle syntactic or semantic errors in the input stream before they result in a RecognitionException.
        // The generated code currently contains calls to sync(org.antlr.v4.runtime.Parser) after entering the decision state of a closure block ((...)* or(...)+).
        // For an implementation based on Jim Idle's "magic sync" mechanism, see DefaultErrorStrategy.sync(org.antlr.v4.runtime.Parser).
        public void Sync(Parser recognizer)
        {
            //throw new NotImplementedException();
        }
    }
}
