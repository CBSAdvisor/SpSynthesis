using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSynthesis.Core.Infrastructure
{
    public interface ILogger
    {
        void Trace(string message);

        void Debug(string message);
        void Debug(string message, params object[] args);

        void Info(string message, params object[] args);
        void Info(string message);

        void Warn(string message);

        void Error(string message);
        void Error(string message, params object[] args);
        void Error(Exception exception);
        void Error(string message, Exception exception);

        void Fatal(string message);
        void Fatal(Exception exception);
    }
}
