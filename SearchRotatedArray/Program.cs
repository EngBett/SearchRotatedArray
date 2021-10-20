using System;

namespace SearchRotatedArray
{
    public class Solution {
        public static int Search(int[] nums, int target) {
            int l = 0;
            int r = nums.Length-1;
        
            //Get the pivot
            while(l<r){
                int mid = l+(r-l)/2;
                if(nums[mid]>nums[r]){
                    l=mid+1;
                }else{
                    r=mid;
                }
            }
        
        
            int start = 0;
            int end = nums.Length-1;
        
            if(target >= nums[l] && target <= nums[end]){
                start = l;
            }else{
                end = l-1;
            }
        
            //search
        
            while(start<=end){
                int mid = start + (end-start)/2;
            
                if(nums[mid]==target) return mid;
            
                if(nums[mid]>target){
                    end = mid-1;
                }else{
                    start = mid+1;
                }
            }
        
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] {3,4,5,6,1,2};
            Console.WriteLine(Solution.Search(nums,2));
        }
    }
}