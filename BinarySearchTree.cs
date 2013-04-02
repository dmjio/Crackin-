using System;

namespace ReplaceString
{
	public class BinarySearchTree<T> where T : struct
	{

		public BSTNode<T> Root;
		public int Key;
		public BinarySearchTree (T data, int key) {
			Root = new BSTNode<T> (data);
			Key = key;
		}


		public void InOrderTraversal(){
			InOrderTraversal (Root);
		}
		private void InOrderTraversal (BSTNode<T> root){
			if (root == null)
				return;
			InOrderTraversal (root.Left);
			Console.WriteLine (root.Data);
			InOrderTraversal (root.Right);
		}

		public void PreOrderTraversal(){
			PreOrderTraversal (Root);
		}
		private void PreOrderTraversal (BSTNode<T> root){
			if (root == null)
				return;
			Console.WriteLine (root.Data);
			PreOrderTraversal (root.Left);
			PreOrderTraversal (root.Right);
		}

		public void InOrder(){
			InOrder (Root);
		}
		public void InOrder (BSTNode<T> root){
			if (root == null)
				return;
			Console.WriteLine (root.Data);
			InOrder (root.Left);
			InOrder (root.Right);
		}

//      Generics are killing me here
//		public BSTNode<T> Search (T data){
//			return Search (data, Root);
//		}

//		private BSTNode<T> Search (T data, BSTNode<T> root){
//			if (root.Data.Equals(data) || root == null) 
//				return root;
//			if (root.Data < data)
//				return Search (data, root.Left);
//			return Search(data, root.Right);
//		} 
//
//		public T Max(){
//			var node = Root;
//			while (node != null)
//				node = node.Right;
//			return node;
//		}
//
//		public T Min(){
//			var node = Root;
//			while (node != null)
//				node = node.Left;
//			return node;
//		}

		public void Insert(T data){
			var node = Root;
			Insert (data, node);
		}
		private void Insert(T data, BSTNode<T> node){

		}
	}

	public class BSTNode<T> where T : struct {
		public T Data;
		public BSTNode (T data){
			Data = data;
		}
		public BSTNode<T> Left;
		public BSTNode<T> Right;

	}
		
}

