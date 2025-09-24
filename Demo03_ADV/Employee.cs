using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_ADV
{
    internal class Employee : IEquatable<Employee>
    {

        public int Id { get; set; }
        public String? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id :{Id} ,Name :{Name} ,Salary :{Salary}";
        }

        public override bool Equals(object? obj)
        {
            Employee? emp = obj as Employee;
            if (emp is null) return false;
            return Id == emp.Id && Name == emp.Name && Salary == emp.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id ,Name ,Salary);
        }

        public int Equals(Employee? other)
        {
            if (other is null) return 1;
            return this.Id.CompareTo(other.Id);   
        }

        bool IEquatable<Employee>.Equals(Employee? other)
        {
            throw new NotImplementedException();
        }
    }
}
