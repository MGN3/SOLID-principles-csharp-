using Liskov;


void CalculateSalaryMonthly(List<Employee> employees) 
{
    foreach (var item in employees)
    {
        decimal salary = item.CalculateSalary();
        Console.WriteLine($"The {item.GetFullname()}'s salary is {salary}");
        
    }
}


CalculateSalaryMonthly(new List<Employee>() {
	new EmployeeFullTime("Pepito Pérez", 160, 10),
	new EmployeeContractor("Manuel Lopera", 180)
});


EmployeeFullTime prueba = new EmployeeFullTime("pablo", 12, 1);
prueba.CalculateSalary();

