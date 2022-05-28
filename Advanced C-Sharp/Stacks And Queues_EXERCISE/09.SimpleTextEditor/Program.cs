using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            Stack<string> operationMemory = new Stack<string>();

            int n = int.Parse(Console.ReadLine());

            //1 someString - appends someString to the end of the text
            //2 count - erases the last count elements from the text
            //3 index - returns the element at position index from the text
            //4 - undoes the last not undone command of type 1 / 2 
                //and returns the text to the state before that operation

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int commandNumber = int.Parse(input.Substring(0, 1));
                
                if (commandNumber == 1)
                {
                    string commandExecution = input.Substring(2);
                    operationMemory.Push(text.ToString());
                    text.Append(commandExecution);
                }
                else if (commandNumber == 2)
                {
                    string commandExecution = input.Substring(2);
                    int z = int.Parse(commandExecution);
                    operationMemory.Push(text.ToString());
                    text.Remove(text.Length - z, z);
                }
                else if (commandNumber == 3)
                {
                    string commandExecution = input.Substring(2);
                    int z = int.Parse(commandExecution);
                    string textToDisplay = text.ToString().Substring(z - 1,1);
                    Console.WriteLine(textToDisplay);

                }
                else if (commandNumber == 4)
                {
                    text.Clear();
                    text.Append(operationMemory.Pop());
                }
            }
        }
    }
}
