using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarySlipGenerator
{
    class Company
    {
        private string CompanyName;
        private List<Employee> emloyees = new List<Employee>();

        public Company(string Company)
        {

            CompanyName= Company;
        }
        public void setCompanyName(string name)
        {
            CompanyName = name;
        }
        public string getComp0anyName()
        {
            return CompanyName;

        }

    }
}
