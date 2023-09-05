namespace OpenClose {
	public class EmployeeFullTime: Employee {
		public EmployeeFullTime(string fullname, int hoursWorked) {
			Fullname = fullname;
			//this.Fullname = fullname; and  Fullname = fullname; both achieve the same function.
			HoursWorked = hoursWorked;
		}

		public override decimal CalculateSalaryMonthly() {
			decimal hourValue = 30000M;
			decimal salary = hourValue * HoursWorked;
			return salary;
		}
	}
}