namespace LeetCode
{
	public class Arrays
	{
		/* Single Number
		 * Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
		 * You must implement a solution with a linear runtime complexity and use only constant extra space.
		 */
		public int SingleNumber(int[] nums)
		{
			Dictionary<int, int> counter = new Dictionary<int, int>();

			foreach (int element in nums)
			{
				if (counter.ContainsKey(element))
				{
					counter[element] = 2;
				}
				else
				{
					counter.Add(element, 1);
				}
			}

			return counter.FirstOrDefault(p => p.Value == 1).Key;
		}

		/* Intersection of Two Arrays II
		 * Given two integer arrays nums1 and nums2, return an array of their intersection. 
		 * Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
		 */
		public int[] Intersect(int[] nums1, int[] nums2)
		{
			List<int> storeList = new List<int>();
			Dictionary<int, int> num1Count = new Dictionary<int, int>();
			Dictionary<int, int> num2Count = new Dictionary<int, int>();

			for (int index1 = 0; index1 < nums1.Length; index1++)
			{
				if (num1Count.ContainsKey(nums1[index1]))
				{
					num1Count[nums1[index1]] = (num1Count[nums1[index1]]) + 1;
				}
				else
				{
					num1Count.Add(nums1[index1], 1);
				}
			}

			for (int index2 = 0; index2 < nums2.Length; index2++)
			{
				if (num2Count.ContainsKey(nums2[index2]))
				{
					num2Count[nums2[index2]] = (num2Count[nums2[index2]]) + 1;
				}
				else
				{
					num2Count.Add(nums2[index2], 1);
				}
			}

			foreach (KeyValuePair<int, int> entry in num1Count)
			{
				if (num2Count.ContainsKey(entry.Key))
				{
					int lowest = entry.Value <= num2Count[entry.Key] ? entry.Value : num2Count[entry.Key];

					for (int index = 0; index < lowest; index++)
					{
						storeList.Add(entry.Key);
					}
				}
			}

			return storeList.ToArray();
		}

		/* Two Sum
		 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
		 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
         * You can return the answer in any order.
         */
		public int[] TwoSum(int[] nums, int target)
		{
			List<int> returnList = new List<int>();
			Dictionary<int, int> storage = new Dictionary<int, int>();

			for (int index = 0; index < nums.Length; index++)
			{
				if (storage.ContainsKey(target - nums[index]))
				{
					returnList.Add(storage[target - nums[index]]);
					returnList.Add(index);
					break;
				}
				else if (!storage.ContainsKey(nums[index]))
				{
					storage.Add(nums[index], index);
				}
			}

			return returnList.ToArray();
		}
	}
}
