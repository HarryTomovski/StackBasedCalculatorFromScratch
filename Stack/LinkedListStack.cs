using Stack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsinLinkedList
{
   public class LinkedListStack
    {
        private Node topNode;

        public LinkedListStack()
        {
            topNode = null;
        }
        public double push(double value)
        {
            Node node = new Node(value);
            if (topNode == null)
            {
                node.Next = null;

            }
            else
            {
                node.Next = topNode;
            }
            topNode = node;
            Console.WriteLine("Item added to stack :" + value);
            return topNode.Data;
        }
        public double pop()
        {
            double data=0;
            if (topNode == null)
            {
                Console.WriteLine("There is nothing to pop!");
                
            }
            else
            {
                Console.WriteLine("The value of the poped element is: " + topNode.Data);
                data = topNode.Data;
                topNode = topNode.Next;
                

            }
            return data;


        }
        public void peek()
        {
            if (topNode == null)
            {
                Console.WriteLine("The stack is empty");
                return;

            }
            Console.WriteLine("The value of the top element is: " + topNode.Data);
           
        }
        public bool checkIfPossible()
        {
            if (topNode.Next == null)
            {
                return false;
            }
            else
                return true;
        }
        public void performOperation(string operation)
        {
            if (checkIfPossible() == true)
            {
                if (operation == "add")
                {
                    double double1 = this.pop();
                    double double2 = this.pop();
                    double1 = double1 + double2;
                    push(double1);
                    peek();
                }
                else if (operation == "subtract")
                {
                    double double1 = this.pop();
                    double double2 = this.pop();
                    double1 = double1 - double2;
                    push(double1);
                    peek();

                }
                else if (operation == "multiply")
                {
                    double double1 = this.pop();
                    double double2 = this.pop();
                    double1 = double1 * double2;
                    push(double1);
                    peek();

                }
                else if (operation == "divide")
                {
                    double double1 = this.pop();
                    double double2 = this.pop();
                    double1 = double1 / double2;
                    push(double1);
                    peek();

                }
            }
        }

    }

}
