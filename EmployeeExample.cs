using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        protected string _firstName;
        protected string _lastName;
        protected double _salary;

        public Employee(string first, string last, double sal)
        {
            _firstName = first;
            _lastName = last;
            if(_salary < 0)
            {
                _salary = 0.0;
            }
            _salary = sal;
        }
        public string FirstName {
            get {
                return _firstName;
            } set {
                _firstName = value;
            }
        }
        public string LastName {
            get {
                return _lastName;
            } set {
                _lastName = value;
            }
        }
        public double Salary {
            get {
                return _salary;
            }
            set {
                if (value < 0)
                {
                    _salary = 0.0;
                }
                _salary = value;
            }
        }
        public virtual void giveRaise(double raise)
        {
            this._salary = _salary + (_salary * (raise/100));
        }
        public virtual void giveRaise()
        {
            this._salary = _salary + (_salary * (5 / 100));
        }
        public override string ToString()
        {
            return $"\nFirstname = {FirstName }\nLastName = {LastName}\nMonthly Salary = {Salary}";
        }


    }

    public class PermanentEmployee : Employee
    {
        private double _HRA;
        private double _DA;
        private double _PF;
        private double _gsal;
        private DateTime _joinDate;
        private DateTime _retirementDate;
        public PermanentEmployee(string first, string last, double sal, double hra, double da, double pf,DateTime join, DateTime retire) : base(first, last, sal)
        {
            _HRA = hra;
            _DA = da;
            _PF = pf;
            _joinDate = join;
            _retirementDate = retire;
        }
        public DateTime JoinDate
        {
            get { return _joinDate; }
            set { _joinDate = value; }
        }
        public DateTime RetirementDate
        {
            get { return _retirementDate;}
            set { _retirementDate = value; }
        }
        public double HRA
        {
            get { return Salary * (_HRA/100); }
        }
        public double DA
        {
            get { return Salary * (_DA / 100); }
        }
        public double PF
        {
            get { return Salary * (_PF / 100); }
        }
        
        public double calculateGrossSal()
        {
            _gsal = (Salary*12) + HRA + DA + PF;
            return _gsal;
        }
        public override void giveRaise(double raise)
        {
            base.giveRaise(raise);
            _gsal = (Salary*12) + HRA + DA + PF;
        }
        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return $"HRA = {HRA }\nDA = {DA}\nPF = {PF}\njoin Date = {_joinDate.ToShortDateString()}\nRetirement Date = {_retirementDate.ToShortDateString()}";
        }
    }

    internal class EmployeeExample 
    {
        
        public static void Main()
        {
            Console.WriteLine($"Name: Jumana Jambughoda Time: {DateTime.Now}");
            Employee e1 = new Employee("abc", "xyz", 20000);
            Console.WriteLine(e1.ToString());
            Console.WriteLine($"Yearly Salary Of employee {e1.FirstName} {e1.LastName} is {e1.Salary * 12}");
            e1.giveRaise(10);
            Console.WriteLine($"After Giving 10% raise to  {e1.FirstName} {e1.LastName} Salary is {e1.Salary * 12}");
            Employee e2 = new Employee("abcd", "xyzz", 25000);
            Console.WriteLine(e2.ToString());
            Console.WriteLine($"Yearly Salary Of employee {e2.FirstName} {e2.LastName} is {e2.Salary * 12}");          
            e2.giveRaise(10);
            Console.WriteLine($"After Giving 10% raise to  {e2.FirstName} {e2.LastName} Salary is {e2.Salary * 12}");
            PermanentEmployee e = new PermanentEmployee("abc", "xyz", 20000, 15, 10, 5, DateTime.Now, DateTime.Now.AddYears(20));
            Console.WriteLine(e.ToString());
            e.giveRaise(10);
            Console.WriteLine($"After giving 10% raise to {e.FirstName} {e.LastName} Salary is {e.Salary * 12}");
            Console.WriteLine($"Gross Salary is {e.calculateGrossSal()}");
        }
    }
}
