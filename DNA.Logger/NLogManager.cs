using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA.Logger
{
    public class NLogManager : INLogManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public NLogManager()
        {
        }
        public void LogDebug(string message) => logger.ConditionalDebug(message);

        public void LogError(string message) => logger.Error(message);

        public void LogInfo(string message) => logger.Info(message);

        public void LogWarn(string message) => logger.Warn(message);
    }
}
