using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15BinarySearchTree
{
    internal class UC3Search<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get; set;
        }
        public UC3Search<T> leftTree { get; set; }
        public UC3Search<T> rightTree { get; set; }

        public UC3Search(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;

        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0) // "A".CompareTo("a")
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new UC3Search<T>(item);
                }
                else
                    this.leftTree.Insert(item);

            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new UC3Search<T>(item);
                }
                else
                    this.rightTree.Insert(item);
            }
        }

        //method to display binary tree
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

        //method to find a number in the binary tree
        public bool IfExists(T element, UC3Search<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST {0} ", node.NodeData);
                result = true;
            }
            else
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                IfExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                IfExists(element, node.rightTree);
            return result;
        }
    }

}
