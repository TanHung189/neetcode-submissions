public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;
        Stack<char> stack = new Stack<char>(); 
        foreach(char c in s){
            if(c == '{'){
                stack.Push('}');
            }else if(c == '('){
                stack.Push(')');
            }else if(c == '['){
                stack.Push(']');
            }else{
                if(stack.Count == 0 || c != stack.Pop()){
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
