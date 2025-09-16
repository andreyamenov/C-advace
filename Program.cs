using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Read the input sequence of parentheses
        string input = Console.ReadLine();

        // Stack to keep track of opening brackets
        Stack<char> stack = new Stack<char>();

        // Flag to track if the sequence is balanced
        bool isBalanced = true;

        foreach (char ch in input)
        {
            // If it's an opening bracket, push it to the stack
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            // If it's a closing bracket, check for a matching opening bracket
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                // If stack is empty, there's no matching opening bracket
                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                char top = stack.Pop();

                // Check if the popped bracket matches the current closing bracket
                if ((ch == ')' && top != '(') ||
                    (ch == '}' && top != '{') ||
                    (ch == ']' && top != '['))
                {
                    isBalanced = false;
                    break;
                }
            }
        }

        // If stack is not empty, there are unmatched opening brackets
        if (stack.Count != 0)
        {
            isBalanced = false;
        }

        // Output the result
        Console.WriteLine(isBalanced ? "YES" : "NO");
    }
}