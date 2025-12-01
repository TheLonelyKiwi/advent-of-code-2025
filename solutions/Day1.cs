namespace advent_of_code_2025.solutions;

public class Day1(string[] input)
{
    
    int FloorDiv(int x, int d)
    {
        return (int)Math.Floor(x / (double)d);
    }
    
    public void Solve1()
    {
        int pos = 50;
        int count = 0;
        
        foreach (string line in input)
        {
            char dir = line.ToCharArray()[0];
            if (!int.TryParse(line[1..], out var dist)) throw new Exception("No nummer");
            
            pos += dir == 'L' ? -dist : dist;
            while (pos > 99 || pos < 0)
            {
                if (pos < 0) pos += 100;
                if (pos > 99) pos -= 100;
            }
            
            if (pos == 0) count++;
        }
        
        Console.WriteLine(count);
    }
    
    public void Solve2()
    {
        var pos = 50;
        var count = 0;
        const int maxD = 100;
        foreach (var line in input)
        {
            var dir = line[0] == 'R' ? 1 : -1;
            if (!int.TryParse(line[1..], out var length)) throw new Exception("No nummer");
            var distToZero = dir == 1 ? maxD - pos : pos;
            if (distToZero > 0 && length >= distToZero) count++;
            count += (length - distToZero) / maxD;
            
            pos += (dir * length);
            pos %= maxD;
            if (pos < 0) pos += maxD;
        }
        
        Console.WriteLine(count);
    }
}