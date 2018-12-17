using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BinarySearchTree
    {

        
        class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int value)
            {
                data = value;
                left = null;
                right = null;
            }

        }

        
        Node root;

        BinarySearchTree()
        {
            root = null;
        }


        
        void insert(int key)
        {
            root = insertRec(root, key);
        }

        
        Node insertRec(Node root, int key)
        {

            
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            
            if (key < root.data)
                root.left = insertRec(root.left, key);
            else if (key > root.data)
                root.right = insertRec(root.right, key)
                
            return root;
        }

        
        void printPostorder(Node node)           
        {
            if (node == null)
                return;
            
            printPostorder(node.left);
            printPostorder(node.right);
            Console.Write(node.data + " ");
        }

        void printInorder(Node node)            
        {
            if (node == null)
                return;

            
            printInorder(node.left); 
            Console.Write(node.data + " ");
            printInorder(node.right);
        }

        void printPreorder(Node node)           
        {
            if (node == null)
                return;

           
            Console.Write(node.data + " ");
            printPreorder(node.left);
            printPreorder(node.right);
        }

     
        void printPostorder()
        {
            printPostorder(root);
        }
       
        void printInorder()
        {
            printInorder(root);
        }
        
        void printPreorder()
        {
            printPreorder(root);
        }


        int FindMin(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("bu agac bostur");
                return -1;
            }
            while (root.left != null)
            {
                root = root.left;
            }


            return root.data;

        }

        int FindMax(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("bu agac bostur");
                return -1;
            }
            while (root.right != null)
            {
                root = root.right;
            }


            return root.data;

        }

        int Max()
        {

            return FindMax(root);
        }

        int Min()
        {

            return FindMin(root);
        }

        static void Main(string[] args)
        {

            BinarySearchTree tree = new BinarySearchTree();
            Random rnd = new Random();

            int[] item = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                tree.insert(item[i] = rnd.Next(0, 9));
            }



            Console.WriteLine("\nPreorder traversal " +
                               );
            tree.printPreorder();

            Console.WriteLine("\nInorder traversal " +
                                        );
            tree.printInorder();

            Console.WriteLine("\nPostorder traversal " +
                                  );
            tree.printPostorder();

            Console.WriteLine("\n");

            int minimum = tree.Min();
            int maksimum = tree.Max();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("minimum degeri = " + minimum);
            Console.WriteLine("maksimum degeri = " + maksimum);

           
            Console.ReadLine();

        }

    }
}
