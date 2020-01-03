using System;
using NLog;
using VerserAssetLeasingServices.Common.Interfaces;
namespace VerserAssetLeasingServices.Common.Implementation
{
    public class Logs 
    {
      
        private  Logger logger = LogManager.GetCurrentClassLogger();

        public Logs()
        {
        }

        public  Logs(Logger log)
        {
            logger = log;
        }       
        public void WrireErrorLogs(string ErrorMessage)
        {
            logger.Error(ErrorMessage);
        }
    }
}
