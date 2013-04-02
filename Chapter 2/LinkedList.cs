using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace LinkedList
{
	//Singly linked-list in C#
	//Add front (use Head), Add back (use Tail)
	//Remove front

	public class Node<T> where T : struct
	{
		public Node<T> Min; //for chapter 3 only
		public Node (T _data) {
			Data = _data;
			Next = null;
		}
		public T Data { get; set; }
		public Node<T> Next { get; set; }
	}

	public class LinkedList<T> : IEnumerable<T> where T : struct  {

		IEnumerator IEnumerable.GetEnumerator () {
			return GetEnumerator ();
		}

		public IEnumerator<T> GetEnumerator() {
			var node = Head;
			while(node != null)	{
				yield return node.Data;
				node = node.Next;
			}
		}

		public int Length { get; set; }
		public Node<T> Head { get; set; }

		public LinkedList () {
			Head = null;
			Length = 0;
		}

		public LinkedList (T data) {
			Head = new Node<T> (data);
			Length = 1;
		}

		public void add(T data) { //add back
			if (Head == null) {
				Length++;
				Head = new Node<T> (data);
				return;
			}
			var node = Head;
			while (node.Next != null)
				node = node.Next;
			node.Next = new Node<T> (data);
			Length++;
		}

		public void add_head(T data){ //add front
			if (Head == null) {
				Length++;
				Head = new Node<T> (data);
				return;
			}
			var node = new Node<T> (data);
			node.Next = Head;
			Head = node;
			Length++;
		}

		public T remove_head(){

			if (Length == 1) {
				var val = Head.Data;
				Head = null;
				Length--;
				return val;
			}

			var node = Head;
			var data = node.Data;
			node.Data = node.Next.Data;
			node.Next = node.Next.Next;
			Head = node;
			Length--;
			return data;
		}


		public Node<T> GetNode(int data){
			var node = Head;
			while (node != null)
				if (node.Data.Equals (data))
					return node;
				else
					node = node.Next;
			return null;
		}

		public void remove(T data){
			var node = Head;

			if (node.Data.Equals(data)) {
				Head = node.Next; //removes head;
				Length--; //decrement length
				return;
			}

			while (node.Next != null) {
				if (node.Next.Data.Equals(data)){
					node.Next = node.Next.Next; //removes node that satisfies predicate
					Length--;
					return;
				}
				node = node.Next;
			} //no change in head
		}

		public override string ToString ()
		{
			var node = Head;
			var s = new StringBuilder ();
			int i = 0;
			s.AppendLine ("Linked List");
			while (node != null) {
				s.AppendLine(string.Format ("   {0}:" + node.Data, i));
				i++;
				node = node.Next;
			}
			return s.ToString ();
		}
	}
}

