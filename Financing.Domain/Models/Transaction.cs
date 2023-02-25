using System;
namespace Financing.Domain.Models
{
	public class Transaction
	{
		public DateTime Date { get; set; }
		public string TransactionCode { get; set; }
		public string Description { get; set; }
		public IEnumerable<TransactionEvent> Events { get; set; }

		public Transaction()
		{
		}
	}
}

