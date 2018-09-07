using System;
using System.Collections.Generic;

namespace Exercise2._2 {

    class Company {
        List<Employee> employs = new List<Employee> ();
        public double MonthSalaryTotal
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < employs.Count; i++)
                    sum = employs[i].GetMonthSalary() + sum;
                    return sum;
            }
        }

        public void employNewEmployee(Employee employee)
        {
            employs.Add(employee);
        }
    }

    public abstract class Employee {
        string name;
        public abstract double GetMonthSalary ();
        public Employee (string name) => this.name = name;
    }

    public class PartTimeEmployee : Employee {
        double hourlyWage;
        int hoursPerMonth;
        public PartTimeEmployee (string name, double hourlyWage, int hoursPerMonth) : base (name) {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
        }
        public override double GetMonthSalary () {
            return hourlyWage * hoursPerMonth;
        }

    }

    public class FullTimeEmployee : Employee {
        double monthlySalary;
        public FullTimeEmployee (string name, double monthlySalary) : base (name) {
            this.monthlySalary = monthlySalary;
        }
        public override double GetMonthSalary () {
            return monthlySalary;
        }
    }
    class Program {
        static void Main (string[] args) {
            FullTimeEmployee employee1 = new FullTimeEmployee("Boi", 4000.00);
            PartTimeEmployee employee2 = new PartTimeEmployee("Grill", 30, 100);
            Company company = new Company();
            company.employNewEmployee(employee1);
            company.employNewEmployee(employee2);
            System.Console.WriteLine(company.MonthSalaryTotal);
        }
    }
}