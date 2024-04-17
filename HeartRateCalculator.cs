/** 
 * This program calculates the maximum heart rate and target heart rate range for a person based on their age. 
 * It prompts the user to input their first name, last name, birth year, and current year. 
 * Then, it calculates the person's age, maximum heart rate, and target heart rate range using the formulae:
 * - Age = Current Year - Birth Year
 * - Maximum Heart Rate = 220 - Age
 * - Target Heart Rate Range = 50% - 85% of Maximum Heart Rate
 * Finally, it displays the person's full name, birth year, age, maximum heart rate, and target heart rate range.
 */

using System;

class HeartRates
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public int CurrentYear { get; set; }

    public int Age => CurrentYear - BirthYear;
    public int MaxHeartRate => 220 - Age;
    public string TargetHeartRateRange => $"{(int)(0.5 * MaxHeartRate)} - {(int)(0.85 * MaxHeartRate)}";
}

class Program
{
    static void Main()
    {
        Console.Write(" What is your First Name: ");
        string first = Console.ReadLine();
        Console.Write("What is your Last Name: ");
        string last = Console.ReadLine();
        Console.Write(" What is your Birth Year: ");
        int birth = int.Parse(Console.ReadLine());
        Console.Write(" What is Current Year: ");
        int current = int.Parse(Console.ReadLine());

        HeartRates person = new HeartRates
        {
            FirstName = first,
            LastName = last,
            BirthYear = birth,
            CurrentYear = current
        };
        Console.WriteLine($"Full Name: {person.FirstName} {person.LastName}\nYear of Birth: {person.BirthYear}\nPerson's Age: {person.Age} years\nMaximum Heart Rate: {person.MaxHeartRate} bpm\nTarget Heart Rate Range: {person.TargetHeartRateRange} bpm");

    }
}
