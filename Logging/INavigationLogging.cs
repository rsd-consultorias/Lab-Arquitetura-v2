using System;
namespace Logging
{
	public interface INavigationLogging
    {
		void LogNavigation(string controller, string action, string userLogin);
	}
}

