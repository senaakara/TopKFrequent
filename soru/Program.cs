using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace soru
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            int [] num =  {1,1,1,2,2,3};
            TopKFrequent(num, 2);
            void TopKFrequent(int[] nums, int k)
            {
                
                Dictionary<string, int> dict = new Dictionary<string, int>();
                ArrayList result = new ArrayList();
                for (int i = 0; i < nums.Length; i++)
                {
                    string num_str = nums[i].ToString();
                    if (dict.ContainsKey(num_str))
                    {
                        dict[num_str] += 1;
                    }
                    else
                    {
                        dict[num_str] = 1;
                    }
                    
                }
                
                for (int i = 0; i < k; i++)
                {
                    var maxEntry = dict.Aggregate((x, y) => x.Value > y.Value ? x : y);
                    result.Add(int.Parse(maxEntry.Key));
                    dict.Remove(maxEntry.Key);
                }

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                

            }
        }
    }
}