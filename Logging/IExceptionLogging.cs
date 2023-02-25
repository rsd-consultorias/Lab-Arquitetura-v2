using System;
namespace Logging
{
    public interface IExceptionLogging
    {
        void LogException(string eventCode, string eventMessage, Exception exception);
    }
}
