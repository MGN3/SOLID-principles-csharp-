using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose {
	public abstract class Employee {

		public string Fullname { get; set; }
		public int HoursWorked { get; set; }

		public abstract decimal CalculateSalaryMonthly();

		/*
		 * Abstract Class vs Interface: you can implement a function that will be inherited and override it if needed in other classes
		 * public decimal CalculateSalaryMonthly2() {
			return 1.5m;
		}
		*/
	}

}