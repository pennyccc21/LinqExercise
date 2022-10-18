using LinqExercise;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
//Static array of integers
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

/*
* 
* Complete every task using Method OR Query syntax. 
* You may find that Method syntax is easier to use since it is most like C#
* Every one of these can be completed using Linq and then printing with a foreach loop.
* Push to your github when completed!
* 
*/

//TODO: Print the Sum of numbers
var Sum = numbers.Sum();
var Avg  = numbers.Average();
Console.WriteLine($"Average: {Avg}");
Console.WriteLine($"Sum: {Sum}");




//TODO: Order numbers in ascending order and print to the console
var asc = numbers.OrderBy(num => num);
Console.WriteLine("-------");
Console.WriteLine("asc");

//TODO: Order numbers in decsending order and print to the console
var desc = numbers.OrderByDescending(num => num);
Console.WriteLine("-------");
Console.WriteLine("Desc");


//TODO: Print to the console only the numbers greater than 6
var greaterThanSix = numbers.Where(num => num > 6 );

foreach (var number in greaterThanSix)
{
    Console.WriteLine(number);
}

//TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
var FirstFour = asc.Take(4);
Console.WriteLine("First 4 Asc");

foreach (var num in asc.Take(4)) 
{
    Console.WriteLine(num);
}

//TODO: Change the value at index 4 to your age, then print the numbers in decsending order
numbers[4] = 22;
Console.WriteLine("my age");

foreach (var item in numbers.OrderByDescending(num => num) )
{
    Console.WriteLine("item");
}



// List of employees ****Do not remove this****
var employees = CreateEmployees();

//TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

var Filtered = employees.Where(person => person.FirstName.StartsWith("c") && person.FirstName.StartsWith("s"))
.OrderBy(person => person.FirstName);

Console.WriteLine("FistName starts with C, or S,");

//TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

var overTwentySix = employees.Where(emp => emp.Age >26)
.OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName)
.ThenBy(emp => emp.YearsOfExperience);

Console.WriteLine("over 26");
foreach (var person in overTwentySix)
{

    Console.WriteLine($"Fullname: {person.FullName} Age: {person.Age}   YOE: {person.YearsOfExperience}");
}



//TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

var yoeEmployees = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

var sumOfYOE = yoeEmployees.Sum(emp => emp.YearsOfExperience);
var avgOfYOE = yoeEmployees.Average(emp => emp.YearsOfExperience);

Console.WriteLine($"Sum {sumOfYOE} Avg {avgOfYOE}");

//TODO: Add an employee to the end of the list without using employees.Add()
employees = employees.Append(new Employee("first", "lastname", 100, 1)).ToList();

foreach (var emp in employees)
{
    Console.WriteLine($"{emp.FirstName} {emp.Age}");
}


Console.WriteLine();

Console.ReadLine();

#region CreateEmployeesMethod
List<Employee> CreateEmployees()
{
    List<Employee> employees = new List<Employee>();
    employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
    employees.Add(new Employee("Steven", "Bustamento", 56, 5));
    employees.Add(new Employee("Micheal", "Doyle", 36, 8));
    employees.Add(new Employee("Daniel", "Walsh", 72, 22));
    employees.Add(new Employee("Jill", "Valentine", 32, 43));
    employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
    employees.Add(new Employee("Big", "Boss", 23, 14));
    employees.Add(new Employee("Solid", "Snake", 18, 3));
    employees.Add(new Employee("Chris", "Redfield", 44, 7));
    employees.Add(new Employee("Faye", "Valentine", 32, 10));

    return employees;
}
