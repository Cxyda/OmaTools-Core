using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace Plugins.O.M.A.Games.Core.ErrorHandling
{
    /// <summary>
    /// TODO:
    /// </summary>
    public static class OMALog
    {
        public static void Warning(string message)
        {
            var stackTrace = new StackTrace();
            Debug.LogWarningFormat(" {0} : {1}", OMAUtils.GetModuleName(stackTrace.GetFrame(1).GetMethod().DeclaringType),
                message);
        }
    }
}