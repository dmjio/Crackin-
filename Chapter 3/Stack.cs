using System;
using LinkedList;

namespace Stack
{
	public class Stack<T> where T : struct
	{
		public LinkedList<T> List { get; set; }

		public int Length { get { return List.Length; } }

		public Stack () { List = new LinkedList.LinkedList<T> (); }

		public Stack (T data) {
			List = new LinkedList<T> (data);
		}

		public virtual void push(T data){
			List.add_head (data); //O(1)
		}

		public virtual T pop () {
			if (List.Length == 0) 
				throw new Exception("Can't pop an item off an empty list");
			return List.remove_head (); //O(1)
		}

		public override string ToString () {
			return string.Format ("[Stack: List={0}]", List.ToString());
		}

		public T peek(){
			if (List.Head != null)
				return List.Head.Data;
			throw new Exception("Cannot peek on an empty stack");
		}
	}
}

