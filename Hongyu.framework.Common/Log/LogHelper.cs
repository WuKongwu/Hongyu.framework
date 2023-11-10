using log4net;
using log4net.Repository;
namespace Hongyu.framework.Common.Log
{
    /// <summary>
    /// log4net日志帮助类
    /// </summary>
    public class LogHelper : ILogHelper
    {
        private ILog logger;
        private ILoggerRepository _loggerRepository { get; set; }
        public LogHelper()
        {
            _loggerRepository = log4net.LogManager.CreateRepository("NETCoreLog4netRepository");
            var file = new FileInfo(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config"));
            log4net.Config.XmlConfigurator.Configure(_loggerRepository, file);
            logger = LogManager.GetLogger("NETCoreLog4netRepository", "loginfo");
        }
        /// <summary>
        /// 普通日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Info(string message, Exception exception = null)
        {
            if (exception == null)
                logger.Info(message);
            else
                logger.Info(message, exception);
        }

        /// <summary>
        /// 告警日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Warn(string message, Exception exception = null)
        {
            if (exception == null)
                logger.Warn(message);
            else
                logger.Warn(message, exception);
        }

        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Error(string message, Exception exception = null)
        {
            if (exception == null)
                logger.Error(message);
            else
                logger.Error(message, exception);
        }
    }
}