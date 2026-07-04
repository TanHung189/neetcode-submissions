public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        foreach(int i in nums){
            if(!hash.Add(i)){
                return true;
            }
        }
        return false;
    }
}