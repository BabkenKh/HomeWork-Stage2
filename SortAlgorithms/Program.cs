using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {
        //Cheking Equals Arrays
        static bool CheckEqual(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length != secondArray.Length)
                return false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                    return false;
            }

            return true;
        }

        // Algorithms Sorting
        static void SelectionSort(int[] arr, int size)
        {


            for (int i = 0; i < size; ++i)
            {
                int min_ind = i;
                for (int j = i + 1; j < size; ++j)
                {
                    if (arr[min_ind] > arr[j])
                    {
                        min_ind = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min_ind];
                arr[min_ind] = temp;
            }

        }
        //////////////////////////////////////////////
        static void BubleSort(int[] arr, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                for (int j = 1; j < size - i; ++j)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        //////////////////////////////////////////////
        static void InsertionSort(int[] arr, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                for (int j = i + 1; j > 0 && j < size; --j)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }
        //////////////////////////////////////////////
        static void CountingSort(int[] arr, int size)
        {
            int max_value = arr[0];
            int min_value = arr[0];
            for (int i = 0; i < size; ++i)
            {
                if (max_value < arr[i])
                {
                    max_value = arr[i];
                }
                if (min_value > arr[i])
                {
                    min_value = arr[i];
                }
            }

            int[] bucket = new int[max_value - min_value + 1];
            for (int i = 0; i < size; ++i)
            {
                ++bucket[arr[i] - min_value];
            }
            Array.Clear(arr, 0, size);
            int temp = 0;
            for (int i = 0; i < bucket.Length; ++i)
            {
                int count = bucket[i];

                for (int j = 0; j < count; ++j)
                {
                    arr[temp] = i + min_value;
                    ++temp;
                }
            }
        }
        //////////////////////////////////////////////
        static int[] Merge(int[] left, int[] right)
        {
            int[] merge = new int[left.Length + right.Length];
            int left_ind = 0;
            int right_ind = 0;
            int count = 0;
            while (left_ind < left.Length && right_ind < right.Length)
            {
                if (left[left_ind] <= right[right_ind])
                {
                    merge[count] = left[left_ind++];
                    ++count;
                }
                else
                {
                    merge[count] = right[right_ind];
                    ++count;
                }
            }
            while (left_ind < left.Length)
            {
                merge[count] = left[left_ind++];
                ++count;
            }
            while (right_ind < right.Length)
            {
                merge[count] = right[right_ind++];
                ++count;
            }

            return merge;
        } // Proccess merging. Helping method
        static void MergeSort(int[] arr, int size)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            int[] left = new int[size / 2];
            int[] right = new int[size / 2];

            for (int i = 0; i < size / 2; ++i)
            {
                left[i] = arr[i];
            }
            for (int i = size / 2; i < size; ++i)
            {
                right[i - size / 2] = arr[i];
            }
            MergeSort(left, left.Length);
            MergeSort(right, right.Length);

            arr = Merge(left, right);


        }
        //////////////////////////////////////////////
        static int Partition(int[] arr, int i, int j)
        {
            int pivot = i;
            int s1_index = i;
            int s2_index = i;

            for (int k = i+1; k < j; ++k)
            {
                if (arr[k] >= arr[pivot])
                {
                    ++s2_index;
                }
                else
                {
                    ++s1_index;
                    int temp = arr[s1_index];
                    arr[s1_index] = arr[k];
                    arr[k] = temp;
                    ++s2_index;
                }
            }
            int tempo = arr[pivot];
            arr[pivot] = arr[s1_index];
            arr[s1_index] = tempo;

            pivot = s1_index;
            return pivot;

        }
        static void QuickSort(int[] arr, int i, int size)
        {
            if (i == size)
            {
                return;
            }
            int pivot = Partition(arr, i, size);
            QuickSort(arr, i, pivot);
            QuickSort(arr, pivot + 1, size);

        }

        static void Main(string[] args)
        {
            int size = 10;
            int[] arr = new int[size];
            int[] copy_arr = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; ++i)
            {

                arr[i] = rnd.Next(100);
                copy_arr[i] = arr[i];
            }

            Array.Sort(copy_arr);

            //SelectionSort(arr, arr.Length); O(n^2)
            //BubleSort(arr, arr.Length); O(n^2)
            //InsertionSort(arr, arr.Length); O(n^2)
            //CountingSort(arr, arr.Length);  O(n+m)
            //MergeSort(arr, arr.Length); O(nlog(n))
            //QuickSort(arr, 0, arr.Length); O(nlog(n))





            Console.WriteLine(CheckEqual(arr, copy_arr));

            Console.ReadKey();
        }
    }
}
