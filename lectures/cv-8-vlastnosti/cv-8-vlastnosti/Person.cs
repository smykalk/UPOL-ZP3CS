using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace cv_8_vlastnosti {
	class Person {
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string address { get; set; }
		public short age { get; set; }
		public Person(string fName, string lName, string add, short age) {
			firstName = fName;
			lastName = lName;
			address = add;
			this.age = age;
		}
		public override string ToString() {
			return String.Format("Jméno: {0}, Příjmení: {1}, Adresa: {2}, Věk: {3}", firstName, lastName, address, age);
		}
	}
}
