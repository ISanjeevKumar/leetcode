/**
* Input: nums = [2,7,11,15], target = 9
* Output: [0,1]
* Output: Because nums[0] + nums[1] == 9, we return [0, 1].
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) { 
        
        int[] foundIndex = new int[2];
        
        for(int i =0; i< nums.Length ; i++){
            for(int j = i+1; j<nums.Length ; j++){
                if(nums[j]+nums[i] == target){
                    foundIndex[0]=i;
                    foundIndex[1]=j;
                    break;
                }
            }

        }
        return foundIndex;
    }
}