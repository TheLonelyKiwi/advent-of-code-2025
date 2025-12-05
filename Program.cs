
using advent_of_code_2025.solutions;

string[] input = File.ReadAllLines("../../../input.txt");

Day5 day5 = new Day5(input);

var startTime = DateTime.Now;
day5.Solve2();
var endTime = DateTime.Now;
Console.WriteLine("Execution Time: " + (endTime - startTime).TotalMilliseconds + " ms");