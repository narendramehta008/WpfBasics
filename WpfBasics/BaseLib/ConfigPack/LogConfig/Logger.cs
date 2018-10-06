using BaseLib.ConfigPack.GeneralConfig;
using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigPack.BaseLib.LogConfig
{
    public delegate void InfoLogger(string message);

    public class Logger
    {
        private static readonly object LockInfo = new object();
        private static readonly object LockError = new object();
        private static readonly ILog Log4Net = LogManager.GetLogger("");
        private static InfoLogger InfoLogger { get; set; }

        public Logger()
        {
            XmlConfigurator.Configure();
        }

        public static class Log
        {
            public static void Info(string InfoText)
            {
                try
                {
                    lock (LockInfo)
                    {
                        InfoLogger(InfoText);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log.Error(ex.ToString());
                }
            }

            public static void Error(string Error)
            {
                try
                {
                    lock (LockError)
                    {
                        Log4Net.Error(Error);
                    }
                }
                catch (Exception ex)
                {
                }
            }

        }
    }


}
