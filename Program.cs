
using advent_of_code_2025.solutions;

var input = File.ReadAllLines("../../../input.txt");

string[] testInput =
[
    "123 328  51 64",
    "45 64  387 23",
    "6 98  215 314",
    "*   +   *   + ",
];

Day6 day6 = new Day6(testInput);

var startTime = DateTime.Now;
day6.Solve2();
var endTime = DateTime.Now;
Console.WriteLine("Execution Time: " + (endTime - startTime).TotalMilliseconds + " ms");