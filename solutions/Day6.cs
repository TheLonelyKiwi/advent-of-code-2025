using System.Text.RegularExpressions;

namespace advent_of_code_2025.solutions;

public class Day6(string[] input)
{
    public void Solve1()
    {
        var refinedInput = input.Select(line => line.Split(" ", StringSplitOptions.RemoveEmptyEntries));
        long total = 0;

        for (int i = 0; i < refinedInput.First().Length; i++)
        {
            var line = refinedInput.Select(line => line.Skip(i).First());
            total += CalculateSum(line);
        }
        
        Console.WriteLine(total);

        long CalculateSum(IEnumerable<string> line)
        {
            string op = line.Last();
            long sum = op == "*" ? 1 : 0;

            foreach (string num in line)
            {
                if (int.TryParse(num, out int n))
                {
                    if (op == "*")
                    {
                        sum *= n;
                    }
                    else
                    {
                        sum += n;
                    }
                }
            }
            return sum;
        }
    }
    
    public void Solve2()
    {
        List<string> listInput = input.ToList();
        var lines = listInput.Take(Math.Max(0, listInput.Count - 1)).ToList();
        var tokens = Regex.Split(listInput.Last().Trim(), "\\s+").Where(t => !string.IsNullOrEmpty(t)).ToList();
        var ops = tokens.Select(t => t[0]).ToList();

        long total = 0;
        
        Console.WriteLine(lines[0]);
        
        
        var problems = new List<List<long>>();
        var cur = new List<long>();

        int maxLen = lines.Any() ? lines.Max(s => s.Length) : 0;
        
        for (int col = maxLen - 1; col >= 0; col--)
        {
            var cols = lines.Where(s => col < s.Length).Select(s => s[col]).ToList();
            Console.WriteLine($"{col}:  {string.Join(" ", cols)}");
            if (cols.All(c => c == ' '))
            {
                if (cur.Count > 0)
                {
                    problems.Add(new List<long>(cur));
                    cur.Clear();
                }
            }
            else
            {
                var numStr = string.Concat(cols.Where(char.IsDigit));
                if (string.IsNullOrEmpty(numStr))
                    throw new InvalidOperationException("Expected digits in column but found none.");

                cur.Add(long.Parse(numStr));
            }
        }
        
        problems.Add(new List<long>(cur));
        
        Console.WriteLine(problems.Count);
        


    }
}