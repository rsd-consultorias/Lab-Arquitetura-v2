using System;
namespace HR.Domain.Types
{
	public record ApplicationResponse
	{
		public bool Success { get; private set; }
		public string Message { get; private set; }

		public ApplicationResponse(bool success, string? message = null)
		{
			Success = success;
			Message = message!;
		}
	}
}

