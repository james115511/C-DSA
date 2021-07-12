using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stack Implementation in C# Arrays

namespace Stack
{
    class MyStack
    {
        private int[] arr;
        private int top;
        private int capacity;

        //Creating my stack
        public MyStack(int size)
        {
            arr = new int[size];
            capacity = size;
            top = -1;
        }

        //adding elements to the stack
        public void push(int item)
        {
            if (top == capacity -1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                arr[++top] = item;
            }
        }

        //removing elements from stack
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                Console.WriteLine("{0} popped from stack", arr[top]);
                return arr[top--];
            }
        }

        //check if stack is empty
        public int peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                Console.WriteLine("{0} peeked", arr[0]);
                return arr[top];
            }
        }

        public bool isFull()
        {
            return top == capacity - 1;
        }

        //printing contents of the stack

        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine("{0} pushed into stack", arr[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stax = new MyStack(5);

            bool exit = false;

            do
            {          
            Console.WriteLine("Please choose an option \n" + 
                "1. Peek at top \n" + 
                "2. Push \n" + 
                "3. Pop \n" + 
                "4. Contents \n" +
                "5. Exit \n");
            
            string x = Console.ReadLine();
            
            switch (x)
                {
                case "1":
                    stax.peek();
                    break;
                case "2":
                    Console.WriteLine("Enter a number to add to the stack");
                        try
                        {
                            stax.push(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception )
                        {
                            Console.Write("That was not a number \n");
                        }                    
                    break;
                case "3":
                    stax.pop();
                    break;
                case "4":
                    stax.printStack();
                    break;
                case "5":
                    exit = true;
                    break;
                    default:
                    Console.WriteLine("Please Choose a number 1-5");
                    break;
                }
            } while (exit == false);
        }
    }
}
