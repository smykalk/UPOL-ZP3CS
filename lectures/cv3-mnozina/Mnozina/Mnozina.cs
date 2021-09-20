using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnozina {
	class Set {
		List<int> elements { get; set; }
		public Set() {
			this.elements = new List<int>();
		}
		public Set(int[] elements) {
			this.elements = new List<int>();
			foreach (int n in elements) {
				this.elements.Add(n);
			}
		}
		public static int operator +(Set set) {
			return set.elements.Count();
		}
		public static Set operator +(Set l, Set r) {
			Set result = new Set();
			result.elements.AddRange(l.elements);
			result.elements.AddRange(r.elements);
			return result;
		}
		public static Set operator -(Set l, Set r) {
			Set result = l;
			foreach (int n in r.elements)
				result.elements.Remove(n);
			return result;
		}
		public static Set operator <<(Set set, int add) {
			set.elements.Add(add);
			return set;
		}
		public static Set operator >>(Set set, int remove) {
			set.elements.Remove(remove);
			return set;
		}
		public override string ToString() {
			string result = "";
			foreach (int n in elements)
				result += String.Format("{0}, ", n);
			return result;
		}
	}
}
