namespace advent_of_code_2025.solutions;

public class Day3(string[] input)
{
    public void Solve1()
    {
        int total = 0;
        
        foreach (var line in input)
        {
            int[] nums = line.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

            int topBank = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int first = nums[i];
                int second = nums[(i+ 1)..].Max();
                
                int bank = int.Parse(first.ToString() + second); 
                
                if (bank > topBank)
                {
                    topBank = bank;
                }
            }
            
            total += topBank;
        }
        
        Console.WriteLine(total);
    }
    
    public void Solve2()
    {
        long total = 0;
        
        foreach (var line in input)
        {
            List<int> nums = line.ToCharArray().Select(c => int.Parse(c.ToString())).ToList();
            
            string answer = "";
            int startIndex = 0;
            int bankSize = 2;
            for (int answerPos = 0; answerPos < bankSize; answerPos++)
            {
                int maxValue = 0;
                for (int i = startIndex; i <= nums.Count - (bankSize - answerPos); i++)
                {
                    if (nums[i] > maxValue)
                    {
                        maxValue = nums[i];
                        startIndex = i + 1;
                    }
                }
                answer += maxValue;
            }

            total += long.Parse(answer);
        }
        
        Console.WriteLine(total);
    }
}