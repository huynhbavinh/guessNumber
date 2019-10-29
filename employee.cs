using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexercises
{
    class employee
    {
        private int id;
        private string FirstName;
        private string LastName;
        private int Salary;

        public employee(int id,string FirstName,string LastName,int salary)
        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = salary;
        }
        public int GetID()
        {
            return this.id;
        }
        public string GetFirstName()
        {
            return this.FirstName;
        }
        public string GetLastName()
        {
            return this.LastName;
        }
        public int GetSalary()
        {
            return this.Salary;
        }
        public void SetSalary(int NewSalary)
        {
            this.Salary = NewSalary;
        }
        public int AnnualSalary()
        {
           return this.Salary * 12;
        }
        public int RaiseSalary(int percent)
        {
            return (this.Salary * percent) / 100;
        }
        public override string ToString()
        {
            return String.Format("Employee[id={0},name={1} {2} ,salary={3}]",
                id,FirstName,LastName,Salary);
        }
    }
}
