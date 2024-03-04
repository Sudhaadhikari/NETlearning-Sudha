using System;
//1.Print the value of  full name to console

Console.WriteLine("Enter Your Full Name");

// Define a variable fullName and assign a name


  string fullName = "Sudha Adhikari";
 Console.WriteLine(fullName);
 Console.ReadLine();

  //2 define another variable cFullName and initilize it with fullName in uppercase letters

 string fullName = "Sudha Adhikari";
 string cFullName = fullName.ToUpper();
 Console.WriteLine( $"Hello, {cFullName} Ji!");

// // 3 instead of initilizing fullname, get it from user

  Console.WriteLine("Enter your Full Name:");
 string fullName = Console.ReadLine();
 Console.WriteLine($"Hello, {fullName}");

 //4. to enter date of birth

Console.WriteLine("Enter your full name:");
 string fullName = Console.ReadLine();
string cFullName = fullName.ToUpper();

 Console.WriteLine("Enter your Date of Birth as (YYYY/MM/DD):");
 DateTime DOB = DateTime.Parse(Console.ReadLine()); 
 DateTime today = DateTime.Today;
Console.WriteLine($"Hello, {cFullName} Ji!");
Console.WriteLine($"Your DOB: {DOB.ToString("dddd, dd MMMM yyyy")}");

//5 to calculate accurate age as possible.

Console.WriteLine("Enter your Date of Birth as (YYYY/MM/DD):");
DateTime DOB = DateTime.Parse(Console.ReadLine()); // Parse user input into Date2Time
DateTime today = DateTime.Today;

TimeSpan age = today - DOB; // Calculate age based on the difference between today and DOB

int years = (int)(age.TotalDays / 365.25);  // Adjusting for leap years
int months = (int)((age.TotalDays % 365.25) / 30.44);  // Approximate average number of days in a month
int weeks = (int)(age.TotalDays / 7);
int days = (int)(age.TotalDays);

//  //Print the greeting, DOB, and age information to the console
Console.WriteLine($"Hello, Sudha Adhikari Ji!");
Console.WriteLine($"Your DOB: {DOB.ToString("dddd, dd MMMM yyyy")}");
Console.WriteLine($"Age as of now: {years} Years {months} Months {weeks} Weeks {days} Days");
