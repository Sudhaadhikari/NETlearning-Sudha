 using System;

 Console.WriteLine("Enter your Date of Birth as (YYYY/MM/DD):");
  DateTime DOB = DateTime.Parse(Console.ReadLine()); // Parse user input into Date2Time
 DateTime today = DateTime.Today;

 TimeSpan age = today - DOB; // Calculate age based on the difference between today and DOB

 int years = (int)(age.TotalDays / 365.25);  // Adjusting for leap years
 int months = (int)((age.TotalDays % 365.25) / 30.44);  // Approximate average number of days in a month
 int weeks = (int)(age.TotalDays / 7);
 int days = (int)(age.TotalDays);

//Print the greeting, DOB, and age information to the console
 Console.WriteLine($"Hello, Sudha Adhikari Ji!");
 Console.WriteLine($"Your DOB: {DOB.ToString("dddd, dd MMMM yyyy")}");
 Console.WriteLine($"Age as of now: {years} Years {months} Months {weeks} Weeks {days} Days");
