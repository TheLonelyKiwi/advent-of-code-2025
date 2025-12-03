
using advent_of_code_2025.solutions;

string[] input = File.ReadAllLines("../../../input.txt");

Day1 day1 = new Day1(input);
Day2 day2 = new Day2(input);
Day3 day3 = new Day3(input);

var startTime = DateTime.Now;
day3.Solve2();
var endTime = DateTime.Now;
Console.WriteLine("Execution Time: " + (endTime - startTime).TotalMilliseconds + " ms");