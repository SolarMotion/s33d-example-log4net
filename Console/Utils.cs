using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Console
{
    internal static class Utils
    {
        private static readonly log4net.ILog _webApiLogger = log4net.LogManager.GetLogger("WebApiLogger");
        private static readonly log4net.ILog _webLogger = log4net.LogManager.GetLogger("WebLogger");

        internal static void LogApiInfo(string message)
        {
            _webApiLogger.Info(message);
        }

        internal static void LogApiError(Exception ex)
        {
            _webApiLogger.Error(ex);
        }

        internal static void LogWebInfo(string message)
        {
            _webLogger.Info(message);
        }

        internal static void LogWebError(Exception ex)
        {
            _webLogger.Error(ex);
        }
    }
}
