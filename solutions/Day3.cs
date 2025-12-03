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
                var second = nums[(i+ 1)..].Max();
                
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
        int total = 0;
        
        foreach (var line in input)
        {
            List<int> nums = line.ToCharArray().Select(c => int.Parse(c.ToString())).ToList();

            int topBank = 0;

            List<int> digits = new List<int>();
            int startRange = 0;
            int maxRange = nums.Count() - digits.Count();
            while (digits.Count < 12)
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    int topNum = nums.Where((n, idx) => idx >= startRange && idx < maxRange + 1).Max();
                    int topIdx = nums.FindIndex(idx => idx >= startRange && idx < maxRange + 1 && nums[idx] == topNum);
                    digits.Add(nums[topIdx]);

                    startRange = topIdx + 1;
                    maxRange++;

                    Console.WriteLine(nums);
                }

            }
            
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    int first = nums[i];
            //    var second = nums[(i+ 1)..].Max();
            //    
            //    int bank = int.Parse(first.ToString() + second); 
            //    
            //    if (bank > topBank)
            //    {
            //        topBank = bank;
            //    }
            //}
            
            total += topBank;
        }
        
        Console.WriteLine(total);
    }
}