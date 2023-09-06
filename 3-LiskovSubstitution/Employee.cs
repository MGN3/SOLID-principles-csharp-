namespace Liskov
{
    public abstract class Employee
    {
        protected string Fullname { get; set; }
        protected int HoursWorked { get; set; }


        public  Employee(string fullname, int hoursWorked)
        {
            this.Fullname = fullname;
            this.HoursWorked = hoursWorked;
        }
		public string GetFullname() {
			return this.Fullname;
		}

		///  La palabra clave virtual se utiliza para declarar un método en una clase base que puede ser anulado (override) por las clases derivadas
		public abstract decimal CalculateSalary();

    }
}