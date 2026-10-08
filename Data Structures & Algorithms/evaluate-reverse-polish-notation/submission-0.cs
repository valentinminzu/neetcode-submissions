public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<string> stack = new Stack<string>();
        foreach (string c in tokens)
        {
            if (c == "+")
            {
                stack.Push(Convert.ToString(Convert.ToInt32(stack.Pop()) + Convert.ToInt32(stack.Pop())));
            }
            else if (c == "-")
            {
                string a = stack.Pop();
                string b = stack.Pop();
                stack.Push(Convert.ToString(Convert.ToInt32(b) - Convert.ToInt32(a)));
            }
            else if (c == "*")
            {
                stack.Push(Convert.ToString(Convert.ToInt32(stack.Pop()) * Convert.ToInt32(stack.Pop())));
            }
            else if (c == "/")
            {
                string a = stack.Pop();
                string b = stack.Pop();
                stack.Push(Convert.ToString(Convert.ToInt32(b) / Convert.ToInt32(a)));
            }
            else
            {
                stack.Push(c);
            }
        }
        return Convert.ToInt32(stack.Pop());
    }
}
