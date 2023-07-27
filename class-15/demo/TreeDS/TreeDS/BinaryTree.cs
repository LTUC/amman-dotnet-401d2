using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDS
{
    public class BinaryTree<T>
    {
        public Node<T> Root;

        public BinaryTree()
        {
            Root = null;
        }

        public List<T> PreOrderTravarsel()
        {
            List<T> result = new List<T>();
            PreOrderTravarsel(Root, result);

            return result;
        }

        public void PreOrderTravarsel(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                result.Add(node.Value);

                PreOrderTravarsel(node.Left, result);

                PreOrderTravarsel(node.Right, result);
            }

        }

        // In-order Traversal
        public List<T> InorderTraversal()
        {
            List<T> result = new List<T>();
            InorderTraversal(Root, result);
            return result;
        }

        private void InorderTraversal(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                InorderTraversal(node.Left, result);
                result.Add(node.Value);
                InorderTraversal(node.Right, result);
            }
        }

        // Post-order Traversal
        public List<T> PostorderTraversal()
        {
            List<T> result = new List<T>();
            PostorderTraversal(Root, result);
            return result;
        }

        private void PostorderTraversal(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                PostorderTraversal(node.Left, result);
                PostorderTraversal(node.Right, result);
                result.Add(node.Value);
            }
        }

    }


}
