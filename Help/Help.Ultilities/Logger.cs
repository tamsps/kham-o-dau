using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Help.Ultilities
{
    public class Logger
    {
        private const string LOGGER_NAME = "HelpKhamODau";
        private static readonly ILog frameworkLogger;

        public static ILog FrameworkLogger
        {
            get { return frameworkLogger; }
        }

        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
            frameworkLogger = LogManager.GetLogger(LOGGER_NAME);
        }
    }
}
