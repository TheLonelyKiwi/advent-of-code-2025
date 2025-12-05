namespace advent_of_code_2025.solutions;

public class Day5(string[] input)
{
    public void Solve1()
    {
        int total = 0;
        
        int blank = Array.FindIndex(input, row => row == "");
        var ranges = input[..blank].Select(line =>
        {
            var parts = line.Split('-');
            return (long.Parse(parts[0]), long.Parse(parts[1]));
        }).ToList();
        var ingredients = input[(blank + 1)..];

        foreach (var ingredient in ingredients)
        {
            if (IsFresh(long.Parse(ingredient))) total++;
        }
        
        Console.WriteLine(total);

        bool IsFresh(long ingredient)
        {
            foreach(var (start, end) in ranges)
            {
                if (ingredient >= start && ingredient <= end) return true;
            }
            return false;
        }
    }
    
    public void Solve2()
    {
        long total = 0;
        
        int blank = Array.FindIndex(input, row => row == "");
        var ranges = input[..blank].Select(line =>
        {
            var parts = line.Split('-');
            return (long.Parse(parts[0]), long.Parse(parts[1]));
        }).OrderBy(r => r.Item1).ToList();
        long prevEnd = 0;

        foreach (var cur in ranges)
        {
            long start = Math.Max(prevEnd + 1, cur.Item1);

            total += Math.Max(0, cur.Item2 - start + 1);
            prevEnd = Math.Max(prevEnd, cur.Item2);
        }
        
        Console.WriteLine(total);
        
    }
}