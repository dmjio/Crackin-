using System;
using System.Linq;
using System.Collections.Generic;

namespace InsertionSort
{
	public static class Sorting
	{
		public static void insertion_sort(int[] list){
			for (int j = 1; j < list.Length; j++) {
				int key = list[j];
				int i = j-1;
				while (i >= 0 && key > list[i]){
					list[i+1] = list[i];
					i--;
				}
				list[i+1] = key;
			}
		}
	}
}

