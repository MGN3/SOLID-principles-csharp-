using OpenClose;

void ShowSalaryMonthly(List<Employee> employees) {
	foreach (var employee in employees) {
		Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly()} ");
	}
}


ShowSalaryMonthly(new List<Employee>() {
	new EmployeeFullTime("Pepito Pérez", 160),
	new EmployeePartTime("Manuel Lopera", 180)
});

List<Employee> employees = new List<Employee>();

employees.Add(new EmployeeContractor("pepito", 160));

foreach (var item in employees) {
	Console.WriteLine(item.CalculateSalaryMonthly());

}