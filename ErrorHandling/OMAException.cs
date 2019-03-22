using System;
using System.Diagnostics;

namespace Plugins.O.M.A.Games.Core.ErrorHandling
{
    /// <summary>
    /// TODO:
    /// </summary>
    public class OMAException : Exception
    {
        private static StackTrace _stackTrace = new StackTrace();

        public OMAException(string message)
            : base(string.Format("{0} : {1}", OMAUtils.GetModuleName(_stackTrace.GetFrame(1).GetMethod().DeclaringType), message))
        {
        }

        public OMAException(string message, Exception inner)
            : base(string.Format("{0} : {1}",
                OMAUtils.GetModuleName(_stackTrace.GetFrame(1).GetMethod().DeclaringType), message, inner))
        {
        }
    }
}