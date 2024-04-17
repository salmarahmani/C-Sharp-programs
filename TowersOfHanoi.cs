// This C# program demonstrates the classic Towers of Hanoi problem solution using recursion.
// It prompts the user to enter the number of disks and then recursively moves the disks
// from one peg to another according to the rules of the puzzle, printing each move.
// The TowerOfHanoi method implements the recursive algorithm to solve the problem.
 using System;

class TowersOfHanoi
{
    static void Main()
    {
        Console.Write("Enter the number of disks: ");
        int n = int.Parse(Console.ReadLine());

        TowerOfHanoi(n, 'A', 'C', 'B');
    }

    static void TowerOfHanoi(int n, char source, char destination, char auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from peg {source} to peg {destination}");
            return;
        }

        TowerOfHanoi(n - 1, source, auxiliary, destination);
        Console.WriteLine($"Move disk {n} from peg {source} to peg {destination}");
        TowerOfHanoi(n - 1, auxiliary, destination, source);
    }
}