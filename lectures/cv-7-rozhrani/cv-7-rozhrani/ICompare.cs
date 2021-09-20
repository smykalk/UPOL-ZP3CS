using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_7_rozhrani {
	interface ICompare {
		bool GreaterCircumference(IShape shape);
		bool GreaterArea(IShape shape);
	}
}
