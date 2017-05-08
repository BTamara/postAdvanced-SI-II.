using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class MergeSort
    {

        public static void Merge(int[] arr, int left, int middle, int right)
        {
            int[] temp = new int[arr.Length+1];
            int i, leftIndex, num_elements, temporary;

            leftIndex = (middle - 1);
            temporary = left;
            num_elements = (right - left + 1);

            while ((left <= leftIndex) && (middle <= right))
            {
                if (arr[left] <= arr[middle])
                    temp[temporary++] = arr[left++];
                else
                    temp[temporary++] = arr[middle++];
            }

            while (left <= leftIndex)
                temp[temporary++] = arr[left++];

            while (middle <= right)
                temp[temporary++] = arr[middle++];

            for (i = 0; i < num_elements; i++)
            {
                arr[right] = temp[right];
                right--;
            }

        }

        public static void Sorting( int[] arr, int left, int right)
        {
            int middle = (right + left) / 2;

            if (right > left)
            {
                Sorting(arr, left, middle);
                Sorting(arr, middle + 1, right);

                Merge(arr, left, middle + 1, right);
            }
        }


        
    }

    class BubbleSort
    {
        public static void Bubbling(int[] arr)
        {
            int length = arr.Length;

            int temp = arr[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];

                        arr[i] = arr[j];

                        arr[j] = temp;
                    }
                }
            }
        }

    }

    class QuickSort
    {
        public static void QuickSorting(int[] arr, int left, int right) {

            if (left < right)
            {
                int pivot = QuickPart(arr, left, right);
                QuickSorting(arr, left, pivot - 1);
                QuickSorting(arr, pivot + 1, right);
            }
        }

        public static int QuickPart(int[] arr, int left, int right)
        {
            int temp;
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp;
            return i + 1;
        }
    }

    class Menu
    {
        public static void Main(string[] args)
        {

            int[] arr1 = { 2, 4, 3, 6, 10, 100, 234, 1 };
            int[] arr2 = { 3,4,0,2,6,8,643,21,5432,23, 45, 1};
            int[] arr3 = {2,3,65,4,1234,87654,12, 34,587,5,4,1 };

            MergeSort.Sorting(arr1, 0, arr1.Length - 1);
            BubbleSort.Bubbling(arr2);
            QuickSort.QuickSorting(arr3, 0, arr3.Length - 1);
            Console.WriteLine("mergeSorting:");
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nbubbleSorting:");
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nquickSorting:");
            foreach (int i in arr3)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }

   
}
