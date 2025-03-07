using System;

namespace employee_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hEmployee = new HourlyEmployee();
            hEmployee.SetName("John");
            hEmployee.SetIdNumber("123abd");
            hEmployee.SetPayRate(10);
            hEmployee.SetHoursWorked(35);

            SalaryEmployee sEmployee = new SalaryEmployee();
            sEmployee.SetName("Peter");
            sEmployee.SetIdNumber("456def");
            sEmployee.SetSalary(60000);

            DisplayEmployeeInfo(hEmployee);
            DisplayEmployeeInfo(sEmployee);
        }

        public static void DisplayEmployeeInfo(Employee employee)
        {
            float pay = employee.GetPay();
            Console.WriteLine($"{employee.GetName()}will be paid ${pay}.");
        }
    }
}