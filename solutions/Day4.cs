namespace advent_of_code_2025.solutions;

public class Day4(string[] input)
{
    int GetCount(char[][] grid, int y, int x)
    {
        int count = 0;
        for (int dy = -1; dy <= 1; dy++)
        {
            for (int dx = -1; dx <= 1; dx++)
            {
                if (dy == 0 && dx == 0) continue;

                int newX = x + dx;
                int newY = y + dy;

                if (newY >= 0 && newY < grid.Length &&
                    newX >= 0 && grid[newY] != null && newX < grid[newY].Length)
                {
                    if (grid[newY][newX] == '@') count++;
                }
            }
        }
        return count;
    }
    
    public void Solve1()
    {
        
        int total = 0;
        char[][] grid = input.Select(line => line.ToCharArray()).ToArray();

        for (int y = 0; y < grid.Length; y++)
        {
            for (int x = 0; x < grid[y].Length; x++)
            {
                if (grid[y][x] != '@') continue;
                
                int count = GetCount(grid, y, x);
                if (count < 4)
                {
                    total++;
                }
            }
        }
        
        Console.WriteLine(total);
    }
    
    public void Solve2()
    {
        int total = 0;
        int rollsRemoved = 1;
        char[][] grid = input.Select(line => line.ToCharArray()).ToArray();

        while (rollsRemoved > 0)
        {
            rollsRemoved = 0;
            for (int y = 0; y < grid.Length; y++)
            {
                for (int x = 0; x < grid[y].Length; x++)
                {
                    if (grid[y][x] != '@') continue;
                
                    int count = GetCount(grid, y, x);
                    if (count < 4)
                    {
                        grid[y][x] = '.';
                        rollsRemoved++;
                        total++;
                    }
                }
            }
        }
        
        
        Console.WriteLine(total);
    }
}