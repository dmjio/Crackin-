using System;
using System.Text;

namespace BinaryTree
{
	public class BinaryTree<T> where T : struct
	{
		public BinaryTreeNode<T> Root;
		public BinaryTree (T data) { 
			Root = new BinaryTreeNode<T>(data); 
		}
		public BinaryTree () { 
			Root = null;
		}

		public void Clear(){
			Root = null;
		}
	}

	public class BinaryTreeNode<T> where T : struct {

		public T Data;
		public BinaryTreeNode<T> Left;
		public BinaryTreeNode<T> Right;

		public BinaryTreeNode (T data)
		{
			Data = data;
			Left = null;
			Right = null;
		}
	}
}



