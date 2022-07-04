using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarySlipGenerator
{
    internal class Employee
    {
        private string EmployeeName;
        private int Employee_id;
        protected double Base_salary;
        protected double Medical_allowence;
        protected double Travel_allowence;
        protected double Salary = 0;

        public Employee()
        {
            Base_salary = 1500;
            Medical_allowence = 0;
            Travel_allowence = 0;
            Salary = 0;
        }
        public void setEmployeeName(string name)
        {
            EmployeeName = name;
        }
        public string getEmployeeName()
        {
            return EmployeeName;
        }
        public void setBase_salary(double bsalary)
        {
            Base_salary = bsalary;

        }
        public double getBase_salary()
        {
            return Base_salary;

        }
        public void setMedical_allowence(double medicalallowence)
        {
            Medical_allowence = medicalallowence;

        }
        public double getMedical_allowence()
        {
            return Medical_allowence;

        }
        public void setGross_salary(double grosSalary)
        {
            Salary = grosSalary;
        }
        public double gettGross_salary()
        {
            return Salary;
        }
        public void setTravel_allowence(double travel)
        {
            Travel_allowence = travel;
        }
        public double getTravel_allowence()
        {
            return Travel_allowence;
        }
        public double clacluteGrossSalary()
        {
            return Travel_allowence + Base_salary + Medical_allowence;
        }
    }
        class Engineer:Employee
        {
           public Engineer()
            {
                Medical_allowence = 100;
                Travel_allowence = 500;
            }
        }
        class Analyst:Employee
        {
            public Analyst()
            {
                Medical_allowence = 150;
                Travel_allowence = 800;
            }

        }
        class Manager :Employee
        {
            public Manager()
            {
                Medical_allowence = 250;
                Travel_allowence = 1000;

            }
        }

  }
