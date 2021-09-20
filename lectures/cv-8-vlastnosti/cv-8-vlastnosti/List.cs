using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace cv_8_vlastnosti {
	class PersonList {
		ArrayList list;
		public PersonList() {
			list = new ArrayList();
		}
		public void AddPerson(Person p) {
			list.Add(p);
		}
		public override string ToString() {
			string s = "";
			foreach (Person p in list) {
				s += p.ToString() + "\n";
			}
			return s;
		}
		public Person this[string name] {
			get {
				foreach (Person p in list)
					if ((p.firstName + " " + p.lastName) == name)
						return p;
				return null;
			}
		}
		public Person this[int index] {
			get {
				foreach (Person p in list)
					if (list.IndexOf(p) == index)
						return p;
				return null;
			}
		}
	}
}
