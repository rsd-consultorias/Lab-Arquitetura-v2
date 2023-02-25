using System;
namespace Core.Types
{
	public record Money
	{
		public decimal Amount { get; set; }
		public string Currency { get; set; }

		public Money(decimal amount, string currency = "BRL")
		{
			Amount = amount;
			Currency = currency;
		}
	}
}

