using System;
using TechTalk.SpecFlow;
using CalculatorExample;
using TechTalk.SpecFlow.Assist;

namespace MyProjectSpecFlow
{
    [Binding]
    public class EmployerFormSteps
    {
        [Given(@"I have loaded new employee page")]
        public void GivenIHaveLoadedNewEmployeePage()
        {
            Console.WriteLine("link to load page action");
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            var employeeDetails = table.CreateSet<EmployeeDetails>();
            foreach (var employee in employeeDetails)
            {
                Console.WriteLine("Details of employee {0}", employee.Name);
                Console.WriteLine("************************");
                Console.WriteLine(employee.Age);
                Console.WriteLine(employee.Email);
                Console.WriteLine(employee.Phone);
            }
        }

    /*    [When(@"I fill all the mandatory details in form using Dynamics")]
        public void WhenIFillAllTheMandatoryDetailsInFormUsingDynamics(Table table)
        {
            var details = table.CreateDynamicSet();

            foreach (var employee in details)
            {
                Console.WriteLine(employee.Name);
                Console.WriteLine(employee.Age);
                Console.WriteLine(employee.Email);
                Console.WriteLine(employee.Phone);
            }
        }*/


    }
}
