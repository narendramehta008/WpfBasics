using ConfigPack.BaseLib.LogConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib.ConfigPack.GeneralConfig
{
    public static class ExceptionConfig
    {
        public static void ErrorLog(this Exception ex, string message = null)
        {
            try
            {
                message = (message == null ? "" : message);
                Logger.Log.Error($"{message} {ex.ToString()}");
            }
            catch (Exception exc)
            {
                Logger.Log.Error(exc.ToString());
            }
        }
    }
}
