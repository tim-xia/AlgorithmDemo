using System;

namespace AlgorithmDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 12, 32, 11, 2, 5, 8, 88, 122, 100, 3 };
            //Console.WriteLine("Bublle Sort(冒泡排序)：");
            //new SortClass().BubbleSort(list);
            //Console.WriteLine("Selection Sort(选择排序)：");
            //new SortClass().SelectionSort(list);
            //Console.WriteLine("Insertion Sort(插入排序)：");
            //new SortClass().InsertionSort(list);
            //Console.WriteLine("Shell Sort(希尔排序)：");
            //new SortClass().ShellSort(list);
            //Console.WriteLine("Quick Sort(快速排序)：");
            //new SortClass().QuickSort(list, 0, list.Length-1);
            Console.WriteLine("Heap Sort(堆排序)：");
            new SortClass().HeapSort(list);
        }
    }
}
