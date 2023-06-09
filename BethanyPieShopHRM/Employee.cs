using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public class Employee
    {
        public string firstName = string.Empty;
        public string lastName = string.Empty;
        public string email = string.Empty;
        public int numberOfhoursWorked;
        public double wage;
        public double hourlyRate=5;
        const int minimalHoursWorkedHoursUnit = 1;
        public DateTime birthDay;
        public Employee(string firstName, string lastName, string email, DateTime birthDay) 
        {
        
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDay = birthDay;

        }


        public void PerformWork()
        {
            //numberOfhoursWorked++;
            PerformWork(minimalHoursWorkedHoursUnit);
         //   Console.WriteLine($"{firstName} {lastName} has worked {numberOfhoursWorked}");
        }
        public void PerformWork(int numOfHours)
        {
            numberOfhoursWorked += numOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked {numOfHours}");
        }
        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfhoursWorked * hourlyRate;
            Console.WriteLine($"{firstName} {lastName} receive {wage} for {numberOfhoursWorked} hours worked");
            if( resetHours ) { numberOfhoursWorked = 0; }

            return wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name {firstName}\nLastName {lastName}\nEmail {email}\nBirthday {birthDay.ToShortDateString}\n");
        }



    }
}
