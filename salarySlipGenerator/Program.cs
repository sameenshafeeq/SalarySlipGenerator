

namespace salarySlipGenerator
{
    class program
    {
        static void Main()
        {
            Company company = new Company("Al rehman group of comapnies");
            string output=company.getComp0anyName();
            Employee e1 = new Employee();
            Analyst a = new Analyst();
            Engineer e= new Engineer();
            Manager m= new Manager();
            double  Salary_accountant=a.clacluteGrossSalary();
            double Salary_engineer=e.clacluteGrossSalary();
            double Salary_manager = m.clacluteGrossSalary();

            //double Salry=e1.clacluteGrossSalary();
            //Console.WriteLine("Salary is :"+ Salry);
            Console.WriteLine( "Salary for accountant is :" + Salary_accountant); 
            Console.WriteLine("Salary for Engineer is :" + Salary_engineer);
            Console.WriteLine("Salary for Mnager is :" + Salary_manager);
        }
        //Console.WriteLine("Hello, World!");

    }

}