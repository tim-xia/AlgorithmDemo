using System;
namespace AlgorithmDemo
{
    public class SortClass
    {

        #region 冒泡排序
        /// <summary>
        /// Bubbles the sort. 冒泡排序
        /// </summary>
        /// <param name="arr">Arr.</param>
        public void BubbleSort(int[] arr)
        {
            //数组为空的处理
            if (arr == null)
            {
                return;
            }
            /* 第一层循环：从0到n
             * 第二层循环：从0到n-i-1
             * 判断大小并互换
            */
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = 0;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                Display(arr);
            }
        }
        #endregion

        #region 选择排序
        /// <summary>
        /// Selections the sort. 选择排序
        /// </summary>
        /// <param name="arr">Arr.</param>
        public void SelectionSort(int[] arr)
        {
            if(arr==null)
            {
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                var min = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                int temp = 0;
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
                Display(arr);
            }
        }
        #endregion

        #region 插入排序
        /// <summary>
        /// Insertions the sort. 插入排序
        /// </summary>
        /// <param name="arr">Arr.</param>
        public void InsertionSort(int[] arr)
        {
            if(arr==null)
            {
                return;
            }
            for (int i = 1; i < arr.Length; i++)
            {
                var preIndex = i - 1;
                var current = arr[i];
                while (preIndex >= 0 && current < arr[preIndex])
                {
                    arr[preIndex + 1] = arr[preIndex];
                    preIndex--;
                }
                arr[preIndex+1] = current;
                Display(arr);
            }
        }
        #endregion
        #region 希尔排序

        public void ShellSort(int[] arr)
        {
            if(arr==null)
            {
                return;
            }
            int d = arr.Length;
            for (d = d / 2; d > 0; d = d / 2)
            {
                if (d % 2 == 0)
                {
                    d++;
                }
                for (int i = 0; i < d; i++)
                {
                    for (int j = i + d; j < arr.Length; j += d)
                    {
                        var preIndex = j - d;
                        var current = arr[j];
                        while (preIndex >= 0 && current < arr[preIndex])
                        {
                            arr[preIndex + d] = arr[preIndex];
                            preIndex -= d;
                        }
                        arr[preIndex + d] = current;
                        Display(arr);
                    }
                }
            }
        }
        #endregion

        #region 快速排序

        /// <summary>
        /// Quicks the sort. 快速排序
        /// </summary>
        /// <param name="arr">Arr.</param>
        /// <param name="low">Low.</param>
        /// <param name="high">High.</param>
        public void QuickSort(int[] arr, int low, int high)
        {
            if (low > high)
            {
                return;
            }
            int index = QuickSortUnit(arr, low, high);
            Display(arr);
            QuickSort(arr, low, index - 1);  //左边单元排序
            QuickSort(arr, index + 1, high); //右边单元排序
        }

        /// <summary>
        /// Quicks the sort unit. 快速单元排序
        /// </summary>
        /// <param name="arr">Arr.</param>
        /// <param name="low">Low.</param>
        /// <param name="high">High.</param>
        private int QuickSortUnit(int[] arr,int low,int high)
        {
            int key = arr[low];
            while (low < high)
            {
                while (arr[high] >= key && high > low)
                    --high;
                arr[low] = arr[high];
                while (arr[low] <= key && high > low)
                    ++low;
                arr[high] = arr[low];
            }
            arr[low] = key;
            return high;
        }
        #endregion

        #region 堆排序
        public void HeapSort(int[] arr)
        {
            //构建大顶堆
            for (int i = arr.Length / 2 - 1; i > 0; i--)
            {
                //从第一个非叶子结点从下至上，从右至左调整结构
                AdjustHeap(arr, i, arr.Length);
            }
            //调整堆结构+交换堆顶元素与末尾元素
            for (int j = arr.Length - 1; j > 0; j--)
            {
                int temp = 0;
                temp = arr[j];
                arr[j] = arr[0];
                arr[0] = temp;
                AdjustHeap(arr, 0, j);
            }

        }

        /// <summary>
        /// Adjusts the heap.调整大顶堆（大顶堆已经建立）
        /// </summary>
        /// <param name="arr">Arr.</param>
        /// <param name="i">The index.</param>
        /// <param name="length">Length.</param>
        private void AdjustHeap(int[] arr, int i, int length)
        {
            int temp = arr[i]; //存堆顶值
            for (int k = 2 * i + 1; k < arr.Length; k = 2 * k + 1)
            {
                if (k + 1 < arr.Length && arr[k] < arr[k + 1])
                {//确保arr[k]是左右结点中大的那个
                    ++k;
                }
                if (arr[k] > temp)
                {//右结点大于父结点
                    arr[i] = arr[k];
                    i = k;
                }
                else
                {
                    break;
                }
            }
            arr[i] = temp; 
            Display(arr);
        }

        #endregion

        /// <summary>
        /// Display the specified arr. 输出数组
        /// </summary>
        /// <returns>The display.</returns>
        /// <param name="arr">Arr.</param>
        private void Display(int[] arr)
        {
            if(arr==null)
            {
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}—> ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
