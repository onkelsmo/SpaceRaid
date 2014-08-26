using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRaid.Common
{
    class Logger
    {
        private static string logFile;

        private enum State
        {
            Debug,
            Live
        };

        private Logger()
        {

        }

        public static void log(string text)
        {
            logFile = text + logFile;
        }

        public static string getText()
        {
            return logFile;
        }
    }
}
