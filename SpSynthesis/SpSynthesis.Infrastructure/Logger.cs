using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using SpSynthesis.Core.Infrastructure;

namespace SpSynthesis.Infrastructure
{
    public class Logger : ILogger
    {
        #region Constructors
        public Logger()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public Logger(string name)
        {
            _logger = LogManager.GetLogger(name);
        }
        #endregion

        #region ILogger Members
        public void Trace(string message)
        {
            _logger.Trace(message);
        }

        public void Debug(string message, params object[] args)
        {
            _logger.Debug(message, args);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            _logger.Info(message, args);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        #region Error Log methods
        public void Error(string message)
        {
            _logger.Error(message);
        }
        public void Error(string message, params object[] args)
        {
            _logger.Error(message, args);
        }
        public void Error(Exception exception)
        {
            _logger.Error(exception);
        }
        public void Error(string message, Exception exception)
        {
            _logger.Error("{0}\n{1}", message, exception);
        }
        #endregion

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }
        public void Fatal(Exception exception)
        {
            _logger.Fatal(exception);
        }
        #endregion

        #region Private Members
        private NLog.Logger _logger;
        #endregion
    }
}
