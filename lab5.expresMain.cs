// Write a program which would find if a mathematical expression is correct from the point of view of the parentheses within it (hint - use stack to store parentheses).
// Read the expression from the file and print the result if the parentheses are put correct in this expression.
// Do same for a file with 3 expressionsin it and print in console information about all of them  if the parentheses in it are put correct.
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expresiile = File.ReadAllLines("three_expression.txt");
            
            int i = 0;
            foreach( var line in expresiile)
            {
                char[] expre = expresiile[i].ToCharArray();
                Console.WriteLine("{0}) {1} ",i+1 ,line);
                PrintRez(expre);
                i++;
            }
        }

        public static void PrintRez (char[] expression)
        {
            if (CheckExpression(expression) == true)
            {
                Console.WriteLine("   Expresia matematica este corecta cu rezultatul {0}\n", evaluate(expression));
            } else {
                Console.WriteLine("   Expresia matematica nu este corecta\n");
            }
        }

        public static bool perechile( char par1, char par2)
        {
            if (par1 == '(' && par2 == ')')
                return true;
            else if (par1 == '{' && par2 == '}')
                return true;
            else if (par1 == '[' && par2 == ']')
                return true;
            else
                return false;
        }

        public static Boolean CheckExpression(char[] exp)
        {
            //declaram un stack pustiu
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < exp.Length; i++)
            {
                //daca este paranteza de deschidere atunci o introducem in stack
                if (exp[i] == '(' || exp[i] == '{' || exp[i] == '[')
                    st.Push(exp[i]);
                //daca este paranteza de inchidere atunci stergem ultima paranteza introdusa
                if (exp[i] == ')' || exp[i] == '}' || exp[i] == ']') 
                {   
                    //daca stack-ul nu are elemente 
                    //atunci o paranteza nu are pereche
                    if (st.Count == 0)
                        return false;
                    
                    else if (!perechile(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }
            //daca stack-ul nu are elemente 
            //atunci toate parantezele au avut perechea lor
            if (st.Count == 0)
                return true;
            else
                return false;
        }
        
        public static int evaluate(char[] charExpression)
        {
            // Stack for numbers: 'values'
            Stack<int> values = new Stack<int>();
    
            // Stack for Operators: 'ops'
            Stack<char> ops = new Stack<char>();
    
            for (int i = 0; i < charExpression.Length; i++)
            {
                // Current token is a whitespace, skip it
                if (charExpression[i] == ' ')
                {
                    continue;
                }
    
                // daca simbolul este numar
                // il inseram in stack-ul pentru numere
                if (Char.IsDigit(charExpression[i]) )
                {
                    StringBuilder sbuf = new StringBuilder();
                    
                    // pentru numerele cu mai multe cifre
                    while (i < charExpression.Length && charExpression[i] >= '0' && charExpression[i] <= '9')
                    {
                        sbuf.Append(charExpression[i++]);
                    }
                    values.Push(int.Parse(sbuf.ToString()));
                
                    // Right now the i points to
                    // the character next to the digit,
                    // since the for loop also increases
                    // the i, we would skip one
                    //  token position; we need to
                    // decrease the value of i by 1 to
                    // correct the offset.
                    i--;
                }
    
                // Current token is an opening
                // brace, push it to 'ops'
                else if (charExpression[i] == '(')
                {
                    ops.Push(charExpression[i]);
                }
    
                // Closing brace encountered,
                // solve entire brace
                else if (charExpression[i] == ')')
                {
                    while (ops.Peek() != '(')
                    {
                    values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Pop();
                }
    
                // Current token is an operator.
                else if (charExpression[i] == '+' || charExpression[i] == '-' || charExpression[i] == '*' || charExpression[i] == '/')
                {  
                    // While top of 'ops' has same
                    // or greater precedence to current
                    // token, which is an operator.
                    // Apply operator on top of 'ops'
                    // to top two elements in values stack
                    while (ops.Count > 0 && hasPrecedence(charExpression[i], ops.Peek()))
                    {
                    values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
    
                    // Push current token to 'ops'.
                    ops.Push(charExpression[i]);
                }
            }
    
            // Entire expression has been
            // parsed at this point, apply remaining
            // ops to remaining values
            while (ops.Count > 0)
            {
                values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
            }
    
            // Top of 'values' contains
            // result, return it
            return values.Pop();
        }
 
        // Returns true if 'op2' has
        // higher or same precedence as 'op1',
        // otherwise returns false.
        public static bool hasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
 
        // A utility method to apply an
        // operator 'op' on operands 'a' 
        // and 'b'. Return the result.
        public static int applyOp(char op, int b, int a)
        {
            switch (op)
            {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/': 
                if (b == 0)
                {
                    throw new System.NotSupportedException("Cannot divide by zero");
                }
                return a / b;
            }
            return 0;
        }

    }
}
