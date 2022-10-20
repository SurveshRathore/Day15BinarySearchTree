using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15BinarySearchTree
{
    internal class UC1BST<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get; set;
        }
        public UC1BST<T> leftTree { get; set; }
        public UC1BST<T> rightTree { get; set; }

        public UC1BST(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;
        }
        int leftCount = 0, rightCount = 0;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0) // "A".CompareTo("a")
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new UC1BST<T>(item);
                }
                else
                    this.leftTree.Insert(item);

            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new UC1BST<T>(item);
                }
                else
                    this.rightTree.Insert(item);
            }
        }


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

    }
}
