using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp1
{
    class Developer
    {
        public int Id { get; set; }
        public string DeveloperName { get; set; }
        public DateTime JoingDate { get; set; }
        public string Project_Assigned { get; set; }
        public decimal NetSalary { get; set; }

        public Developer(int id, string name, DateTime joiningDate, string project)
        {
            
            Id = id;
            DeveloperName = name;
            JoingDate = joiningDate;
            Project_Assigned = project;
        }

        public virtual decimal CalculateSalary()
        {
            return 0m;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {DeveloperName}\nJoining Date: {JoingDate}\nProject Assigned: {Project_Assigned}\nNet Salary: {NetSalary}";
        }
    }

    class OnContract : Developer
    {
        public int Duration { get; set; }
        public decimal Charges_Per_Day { get; set; }

        public OnContract(int id, string name, DateTime joiningDate, string project, int duration, decimal charges)
            : base(id, name, joiningDate, project)
        {
            Duration = duration;
            Charges_Per_Day = charges;
        }

        public override decimal CalculateSalary()
        {
            NetSalary = Duration * Charges_Per_Day;
            return NetSalary;
        }

        public override string ToString()
        {
            return $"On Contract\n{base.ToString()}\nDuration: {Duration}\nCharges per Day: {Charges_Per_Day}\n";
        }
    }

    class OnPayroll : Developer
    {
        public string Dept { get; set; }
        public string Manager { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal DA { get; set; }
        public decimal HRA { get; set; }
        public decimal LTA { get; set; }
        public decimal PF { get; set; }
        public int Exp { get; set; }

        //public OnPayroll() { }

        public OnPayroll(int id, string name, DateTime joiningDate, string project, string dept, string manager, decimal basicSalary, int exp)
            : base(id, name, joiningDate, project)
        {
            Dept = dept;
            Manager = manager;
            BasicSalary = basicSalary;
            Exp = exp;
        }

        public override decimal CalculateSalary()
        {
            DA = BasicSalary * 0.3m;
            HRA = BasicSalary * 0.2m;
            LTA = BasicSalary * 0.1m;
            PF = BasicSalary * 0.12m;
            NetSalary = BasicSalary + DA + HRA + LTA - PF;
            return NetSalary;
        }

        public override string ToString()
        {
            return $"On Payroll\n{base.ToString()}\nDepartment: {Dept}\nManager: {Manager}\nBasic Salary: {BasicSalary}\nExperience: {Exp}\n";
        }
    }
}