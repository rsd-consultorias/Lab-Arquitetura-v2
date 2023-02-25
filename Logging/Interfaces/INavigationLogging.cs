using System;
namespace Logging.Interfaces
{
	public interface INavigationLogging
    {
		void LogNavigation(string controller, string action, string userLogin);
	}
}

