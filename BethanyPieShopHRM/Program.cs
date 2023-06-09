// See https://aka.ms/new-console-template for more information

using BethanyPieShopHRM;
using static BethanyPieShopHRM.Employee;

Console.WriteLine("Creating an employee");

Employee betany = new Employee("Bethany","Smith","bethany@snowball.be", new DateTime (1979,1,16));


betany.DisplayEmployeeDetails();
betany.PerformWork();
betany.PerformWork();
betany.PerformWork();
betany.PerformWork();
betany.PerformWork();

betany.PerformWork(5);
double receiveWageBethany = betany.ReceiveWage(true);
Console.WriteLine($"We paide to Bethany{ receiveWageBethany} Euros");
Console.ReadKey();