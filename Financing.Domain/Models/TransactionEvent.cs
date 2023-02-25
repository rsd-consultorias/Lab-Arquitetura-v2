using System;
using Core.Types;

namespace Financing.Domain.Models
{
	public class TransactionEvent
	{
		public string EventCode { get; set; }
		public Money Amount { get; set; }
		// Type: whether it is debit or credit
		public string Type { get; set; }

		public TransactionEvent()
		{
		}
	}
}

