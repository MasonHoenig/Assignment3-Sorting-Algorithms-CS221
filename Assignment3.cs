using System;

public static class Assignment3 {
	private static void SelectionSort(int[] array, bool isAscending) {
		for(int i = 0; i < array.Length - 1; i++)
		{
			int MinIndex = i;
			for(int j = i + 1;  j < array.Length; j++)
			{
				if (isAscending)
				{
					if (array[j] < array[MinIndex]) { MinIndex = j; }
				}
				else
				{
                    if (array[j] > array[MinIndex]) { MinIndex = j; }
                }
			}
			if (MinIndex != i)
			{
                (array[MinIndex], array[i]) = (array[i], array[MinIndex]);
            }
		}
	}

	private static void GnomeSort(int[] array) {
		int i = 0;
		while(i < array.Length)
		{
			if (i == 0 || array[i]  >= array[i-1]) { i++; }
			else 
			{
				(array[i], array[i - 1]) = (array[i - 1], array[i]);
				i--;
			}
		}
	}
	private static int RangeUnsorted(int[] array) {
		int MinIndex = array[0];
		int MaxIndex = array[0];
		for(int i = 1; i < array.Length; i++)
		{
			if (array[i] < MinIndex) { MinIndex = array[i]; }
            if (array[i] > MaxIndex) { MaxIndex = array[i]; }
        }
		return MaxIndex - MinIndex ;
	}

	private static int RangeSorted(int[] array) {
		return array[array.Length - 1] - array[0];
	}

	private static bool IsSorted(int[] array) {
        for (int i = 1; i < array.Length - 1; i++)
        {
			if(array[i] > array[i - 1]) { return false; }
        }
        return true;
    }

	#region DO NOT MODIFY
	private static void Task1(int[] a) {
		int[] a1 = new int[a.Length];
		a.CopyTo(a1, 0);
		Console.WriteLine($"Sorting array [{string.Join(", ", a1)}] in ascending order...");
		SelectionSort(a1, true);
		Console.WriteLine($"Result: [{string.Join(", ", a1)}]");

		int[] a2 = new int[a.Length];
		a.CopyTo(a2, 0);
		Console.WriteLine($"Sorting array [{string.Join(", ", a2)}] in descending order...");
		SelectionSort(a2, false);
		Console.WriteLine($"Result: [{string.Join(", ", a2)}]");
	}

	private static void Task2(int[] a) {
		int[] a1 = new int[a.Length];
		a.CopyTo(a1, 0);
		Console.WriteLine($"Sorting array [{string.Join(", ", a1)}]...");
		GnomeSort(a1);
		Console.WriteLine($"Result: [{string.Join(", ", a1)}]");
	}

	private static void Task3() {
		int[] a1 = [-10, -6, 10, 6, 19, 0, -9, -10, 1, -13, 7, 18, 14, 8, 19];
		Console.WriteLine($"Range of array [{string.Join(", ", a1)}] is {RangeUnsorted(a1)}");

		int[] a2 = [2];
		Console.WriteLine($"Range of array [{string.Join(", ", a2)}] is {RangeUnsorted(a2)}");

		int[] a3 = [3, 3, 3];
		Console.WriteLine($"Range of array [{string.Join(", ", a3)}] is {RangeUnsorted(a3)}");
	}

	private static void Task4() {
		int[] a1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		Console.WriteLine($"Range of array [{string.Join(", ", a1)}] is {RangeSorted(a1)}");

		int[] a2 = [2, 4, 6, 7, 9, 11];
		Console.WriteLine($"Range of array [{string.Join(", ", a2)}] is {RangeSorted(a2)}");

		int[] a3 = [1, 2, 3, 4, 5];
		Console.WriteLine($"Range of array [{string.Join(", ", a3)}] is {RangeSorted(a3)}");

		int[] a4 = [3];
		Console.WriteLine($"Range of array [{string.Join(", ", a4)}] is {RangeSorted(a4)}");

		int[] a5 = [4, 4, 4, 4];
		Console.WriteLine($"Range of array [{string.Join(", ", a5)}] is {RangeSorted(a5)}");
	}

	private static void Task5() {
		int[] a1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		Console.WriteLine($"Is array [{string.Join(", ", a1)}] sorted? {IsSorted(a1)}");

		int[] a2 = [2, 4, 6, 7, 9, 11];
		Console.WriteLine($"Is array [{string.Join(", ", a2)}] sorted? {IsSorted(a2)}");

		int[] a3 = [3];
		Console.WriteLine($"Is array [{string.Join(", ", a3)}] sorted? {IsSorted(a3)}");

		int[] a4 = [4, 4, 4, 4];
		Console.WriteLine($"Is array [{string.Join(", ", a4)}] sorted? {IsSorted(a4)}");

		int[] a5 = [5, 4, 3, 2, 1];
		Console.WriteLine($"Is array [{string.Join(", ", a5)}] sorted? {IsSorted(a5)}");

		int[] a6 = [1, 2, 3, 4, 5, 4];
		Console.WriteLine($"Is array [{string.Join(", ", a6)}] sorted? {IsSorted(a6)}");

		int[] a7 = [10, 8, 6, 4, 2, 0, -2, -4, -6, -8];
		Console.WriteLine($"Is array [{string.Join(", ", a7)}] sorted? {IsSorted(a7)}");

		int[] a8 = [-10, -8, -6, -4, -2, 0, 2, 4, 6, 8];
		Console.WriteLine($"Is array [{string.Join(", ", a8)}] sorted? {IsSorted(a8)}");
	}

	private static void Main() {
		int[] source = [-10, -6, 10, 6, 19, 0, -9, -10, 1, -13, 7, 18, 14, 8, 19];
		Console.WriteLine("---TASK 1/5---");
		Task1(source);

		Console.WriteLine("\n---TASK 2/5---");
		Task2(source);

		Console.WriteLine("\n---TASK 3/5---");
		Task3();

		Console.WriteLine("\n---TASK 4/5---");
		Task4();

		Console.WriteLine("\n---TASK 5/5---");
		Task5();
	}
	#endregion
}