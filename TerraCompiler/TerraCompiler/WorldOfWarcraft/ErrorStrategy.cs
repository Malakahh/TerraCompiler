using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace TerraCompiler.WorldOfWarcraft
{
    class ErrorStrategy : IAntlrErrorStrategy
    {
        public bool InErrorRecoveryMode(Parser recognizer)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Recover(Parser recognizer, RecognitionException e)
        {
            //throw new NotImplementedException();
        }

        [return: NotNull]
        public IToken RecoverInline(Parser recognizer)
        {
            return null;
            //throw new NotImplementedException();
        }

        public void ReportError(Parser recognizer, RecognitionException e)
        {
            //throw new NotImplementedException();
        }

        public void ReportMatch(Parser recognizer)
        {
            //throw new NotImplementedException();
        }

        public void Reset(Parser recognizer)
        {
            //throw new NotImplementedException();
        }

        public void Sync(Parser recognizer)
        {
            //throw new NotImplementedException();
        }
    }
}
