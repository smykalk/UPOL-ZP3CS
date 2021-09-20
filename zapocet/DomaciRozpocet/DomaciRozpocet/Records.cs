using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DomaciRozpocet {
	/// <summary>
	/// A list where all the records containing income and spendings get stored
	/// </summary>
	class Records : List<Record> {
		public decimal TotalAmount(Predicate<object> pred) {
			decimal total = 0;
			foreach (Record rec in this) {
				if (pred(rec))
					total += rec.Amount;
			}
			return total;
		}

		/// <summary>
		/// Saves List contents in a CSV format into a specified file
		/// </summary>
		/// <param name="pred">Predicate to export only filtered information</param>
		/// <param name="filename">The name of the exported file</param>
		/// <returns></returns>
		public bool SaveToCSV(Predicate<object> pred, string filename) {
			try {
				using (StreamWriter sw = new StreamWriter(filename)) {
					foreach (Record rec in this) {
						if (pred(rec)) {
							string[] values = { rec.Person, rec.Date.ToShortDateString(), rec.Reason, rec.Amount.ToString() };
							string line = String.Join(";", values);
							sw.WriteLine(line);
						}
					}
					return true;
				}
			}
			catch {
				return false;
			}
		}

		/// <summary>
		/// Saves all elements to a "SavedData.csv" file
		/// </summary>
		/// <returns></returns>
		public bool SaveToCSV() {
			try {
				using (StreamWriter sw = new StreamWriter("SavedData.csv")) {
					foreach (Record rec in this) {
						string[] values = { rec.Person, rec.Date.ToShortDateString(), rec.Reason, rec.Amount.ToString() };
						string line = String.Join(";", values);
						sw.WriteLine(line);
					}
					return true;
				}
			}
			catch {
				return false;
			}
		}

		/// <summary>
		/// Appends last element to a "SavedData.csv" file
		/// </summary>
		/// <returns></returns>
		public bool AppendLastToCSV() {
			Record rec = this.Last();
			try {
				using (StreamWriter sw = new StreamWriter("SavedData.csv", true)) {
					string[] values = { rec.Person, rec.Date.ToShortDateString(), rec.Reason, rec.Amount.ToString() };
					string line = String.Join(";", values);
					sw.WriteLine(line);
				}
				return true;
			}
			catch {
				return false;
			}

		}

		//unused for now, might be used for opening specified .csv files
		//
		//public void LoadFromCSV(string filename) {
		//	using (StreamReader sr = new StreamReader(filename)) {
		//		string s;
		//		while ((s = sr.ReadLine()) != null) {
		//			string[] values = s.Split(";");
		//			this.Add(new Record(values[0], DateTime.Parse(values[1]), values[2], Decimal.Parse(values[3])));
		//		}
		//	}
		//}

		/// <summary>
		/// Loads contents from SavedData.csv file
		/// </summary>
		/// <returns></returns>
		public bool LoadFromCSV() {
			try {
				using (StreamReader sr = new StreamReader("SavedData.csv")) {
					string s;
					while ((s = sr.ReadLine()) != null) {
						string[] values = s.Split(";");
						this.Add(new Record(values[0], DateTime.Parse(values[1]), values[2], Decimal.Parse(values[3])));
					}
				}
				return true;
			}
			catch {
				return false;
			}
		}
	}
}
