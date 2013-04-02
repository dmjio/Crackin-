using System;
using LinkedList;

namespace Queue
{
	public class Queue<T> where T : class
	{
		public LinkedList<T> List {get; set;}
		public Queue ()	{ List = new LinkedList<T> (); }
		public int Length { get { return List.Length; } }
		public Queue (T data)
		{
			List = new LinkedList<T> ();
			List.add (data);
		}

		public T Dequeue(){ //dequeue from head
			if (List.Length == 0)
				throw new Exception("Cannot dequeue from an empty queue");
			return List.remove_head();
		}

		public void Enqueue(T data){ //add to back
			List.add (data);
		}

		public T Peek(){ //add to back
			return List.Head.Data;
		}

		public bool IsEmpty(){ 
			return List.Length == 0;
		}


		public override string ToString ()
		{
			return string.Format ("[Queue: List={0}]", List.ToString());
		}

		
	}
}

