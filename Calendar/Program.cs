using System;
using Calendar;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Calculate if a year is a leap year.");
    Console.WriteLine("Enter a year.");
    string yearString = Console.ReadLine();
    int yearInt = int.Parse(yearString);
    bool isLeapYear = LeapYear.IsLeapYear(yearInt);
    if (isLeapYear)
    {
      Console.WriteLine(yearInt + " is a leap year!");
    }
    else
    {
      Console.WriteLine(yearInt + " is not a leap year.");
    }
  }
}
