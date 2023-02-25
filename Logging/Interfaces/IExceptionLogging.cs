using System;
namespace Logging.Interfaces
{
    public interface IExceptionLogging
    {
        void LogException(string eventCode, string eventMessage, Exception exception);
    }
}
