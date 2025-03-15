using System;
namespace HWNS
{
    enum securityLvl
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    enum Gender
    {
        M,
        F
    }

    class Employee
    {
        public int ID { get; }
        public string Name { get; }
        public securityLvl Security { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; }
        public Gender Gender { get; }

        public Employee(int id, string name, securityLvl security, decimal salary, DateTime hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {Security}, {String.Format($"Salary: {Salary}:C")}, Hire Date: {String.Format($"Day-Month-Year: {HireDate:dd-MM-yyyy}")}";
        }
    }


    class HelloWorld
    {
        public static void Main()
        {
            Employee emp1 = new Employee(1, "Basem", securityLvl.DBA, 9.50m, new DateTime(2025, 6, 7), Gender.M);
            Employee emp2 = new Employee(2, "Elb3dishy", securityLvl.Guest, 3m, new DateTime(2015, 11, 9), Gender.M);

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
        }
        
    }
}
