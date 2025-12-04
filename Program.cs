
using advent_of_code_2025.solutions;

string[] input = File.ReadAllLines("../../../input.txt");

Day4 day4 = new Day4(input);

var startTime = DateTime.Now;
day4.Solve2();
var endTime = DateTime.Now;
Console.WriteLine("Execution Time: " + (endTime - startTime).TotalMilliseconds + " ms");