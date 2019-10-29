using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class tree //Class Tree
    {
        public Node root;

        public tree() //Default Constructor
        {
            root = null;
        }

        public int Insert(ref Node root, Node newnode) //Tree Insertion Function
        {
            if (root == null)
            {
                root = newnode;
                return 1;
            }            
            else if (newnode.id > root.id)
            {
                return Insert(ref root.Right, newnode);
            }
            else if (newnode.id < root.id)
            {
                return Insert(ref root.Left, newnode);
            }
            else
            {
                return -1;
            }
        }

        public Node Search(ref Node root, int data) //Searching Function
        {
            if (root == null)
            {
                return root;
            }
            else if (root.id == data)
            {               
                return root;
            }
            else if (data > root.id)
            {
               return Search(ref root.Right, data);
            }
            else
            {
               return Search(ref root.Left, data);
            }
        }

        public Node Find_min(ref Node root) //Finds Minimum Value
        {
            if (root == null)
            {
                return root;
            }
            else if (root.Left == null)
            {
                return root;
            }
            else
            {
                return Find_min(ref root.Left);
            }
        }

        public int Delete_data(ref Node root, int data) //Delete Function
        {
            if (root == null)
            {
                return -1;
            }
            else if (data < root.id)
            {
               return Delete_data(ref root.Left, data);
            }
            else if (data > root.id)
            {
               return Delete_data(ref root.Right, data);
            }
            else
            {
                if (root.Left == null && root.Right == null)
                {
                    //delete root;
                    root = null;
                    return 1;
                }
                else if (root.Left == null)
                {
                    Node temp = new Node();
                    temp = root;
                    root = root.Right;
                    //delete temp;
                    return 1;
                }
                else if (root.Right == null)
                {
                    Node temp = new Node();
                    temp = root;
                    root = root.Left;
                    //delete temp;
                    return 1;
                }
                else
                {
                    Node temp = new Node();
                    temp = Find_min(ref root.Right);
                    root.id = temp.id;
                    return Delete_data(ref root.Right, temp.id);
                }
            }
        }
    }
}
