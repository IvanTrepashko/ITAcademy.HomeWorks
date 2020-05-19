using System.IO;
using log4net;
using log4net.Config;


namespace hw_12
{
    class Logger
    {
        public static ILog CreateLog()
        {
            var logRepos = LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepos, new FileInfo("log4net.config"));
            var logger = LogManager.GetLogger(typeof(Logger));
            return logger;
        }
    }
}
