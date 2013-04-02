using System;
using LinkedList;

namespace ReplaceString
{
	public struct KeyValue<K,V> 
	{
		public K Key { get; set; }
		public V Value { get; set; }
	}

	//this implementation is fixed width
	public class HashTable<K, V>
	{
		public LinkedList<KeyValue<K,V>>[] Items;
		private int size;

		public HashTable (int size) {
			this.size = size;
			Items = new LinkedList<KeyValue<K, V>>[size];
		}

		public void Add(K key, V value) {
			var list = GetLinkedList (key);
			var kv = new KeyValue<K,V> { Key = key, Value = value };
			list.add (kv);
		}

		public V Find(K key){ 
			var list = GetLinkedList(key);

			foreach (KeyValue<K,V> item in list)
				if (item.Key.Equals(key))
				    return item.Value;

			return default(V);
		}

		public void Remove(K key){
			var list = GetLinkedList (key);
			KeyValue<K,V> kv = default(KeyValue<K, V>);
			bool found = false;
			foreach (KeyValue<K,V> item in list) {
				if (item.Key.Equals (key)) {
					kv = item;
					found = true;
				}
			}
			if (found) 
				list.remove (kv);
		}

		private int getPosition(K key) {
			int index = key.GetHashCode () % size;
			return Math.Abs (index);
		}

		public LinkedList<KeyValue<K,V>> GetLinkedList(K key){
			var index = getPosition (key);
			if (Items [index] == null) 
				Items [index] = new LinkedList<KeyValue<K,V>>();
			return Items [index];
		}
	}
}

