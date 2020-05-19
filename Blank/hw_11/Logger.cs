using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace hw_11
{
    public static class Logger
    {
        static public ILog CreateLogger()
        {
            var logRepo = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepo, new FileInfo("log4net.config"));
            var logger = LogManager.GetLogger(typeof(Program));
            return logger;
        }
    }
}
