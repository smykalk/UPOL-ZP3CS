using System;

namespace DomaciRozpocet {
	/// <summary>
	/// A record that stores information about incomes or spendings
	/// </summary>
	class Record {
		/// <summary>
		/// The person that made the expense or income
		/// </summary>
		public string Person { get; set; }
		/// <summary>
		/// The date of expense/income
		/// </summary>
		public DateTime Date { get; set; }
		/// <summary>
		/// The reason for expense/income
		/// </summary>
		public string Reason { get; set; }
		/// <summary>
		/// The monetary amount
		/// </summary>
		public decimal Amount { get; set; }

		public Record(string who, DateTime when, string reason, decimal amount) {
			Person = who;
			Date = when;
			Reason = reason;
			Amount = amount;
		}
	}
}
