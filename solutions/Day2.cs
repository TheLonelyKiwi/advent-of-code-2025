namespace advent_of_code_2025.solutions;

public class Day2(string[] lines)
{
    public void Solve1()
    {
        Int64 total = 0;

        foreach (string pair in lines[0].Split(','))
        {
            var range = pair.Split('-');
            long first = long.Parse(range[0]);
            long last = long.Parse(range[1]);

            for (long i = first; i <= last; i++)
            {
                var numString = i.ToString();
                var length  = numString.Length;

                if (length >= 2)
                {
                    int midPoint =  length / 2;
                    if (numString.Substring(0, midPoint) == numString.Substring(midPoint))
                    {
                        Console.WriteLine("Value:" + numString);
                        total += long.Parse(numString);
                    }
                }
            }
        }
        
        Console.WriteLine(total);
    }
    
    public void Solve2()
    {
        Int64 total = 0;

        foreach (string pair in lines[0].Split(','))
        {
            var range = pair.Split('-');
            long first = long.Parse(range[0]);
            long last = long.Parse(range[1]);

            for (long i = first; i <= last; i++)
            {
                var numString = i.ToString();

                for (int j = 1; j <= numString.Length; j++)
                {
                    string chunk = numString.Substring(0,j);
                    string block = numString.Replace(chunk, "s");

                    if (block == "s")
                    {
                        total += i;
                        break;
                    }
                }
            }
        }
        
        Console.WriteLine(total);
    }
}
