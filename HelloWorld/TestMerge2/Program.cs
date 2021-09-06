using System;

namespace TestMerge2
{
    class MainClass
    {
        public static void merge(ref int[] nums1, int m, int[] nums2)
        {
            int[] res = new int[nums1.Length];
            int i = 0;
            int j = 0;
            int c = 0;
            while (i < m && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    res[c++] = nums1[i++];
                } else
                {
                    res[c++] = nums2[j++];
                }
            }
            while (i < m)
            {
                res[c++] = nums1[i++];
            }
            while (j < nums2.Length)
            {
                res[c++] = nums2[j++];
            }

            //  Array.Resize<byte>(ref array1, 20);
         //   Array.Resize<int>(ref nums1, res.Length);
            Array.Copy(res, 0, nums1, 0, res.Length);
        }
        
        public static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0};
            int[] nums2 = new int[] { 2, 5, 6 };
            merge(ref nums1, 3, nums2);
            foreach (int num in nums1)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Hello World Merge!");
        }
    }
}
