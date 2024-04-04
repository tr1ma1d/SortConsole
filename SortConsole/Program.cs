using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortConsole
{
    class TypeSort
    {
        public TypeSort()
        {
            
        }
        // Сравнивает первые два элемента
        public int[] BubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    
                }
            }
            return arr;
        }
        // Выборочная сортировка.
        /*
         Выбирает минимальный индекс и потом последовательно 
         сравнивает друг с другом и ставит себя на место
         
         */
        public int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }
                // Обмен значениями
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
                
            }
            return arr;
        }
        /*
          В общем интересно понятно, просто смотри на код
          
         */
        public int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int sorted = i - 1;
                while(sorted > -1 && arr[sorted] > arr[sorted + 1])
                {
                    int temp = arr[sorted];
                    arr[sorted] = arr[sorted + 1];
                    arr[sorted + 1] = temp;
                    sorted--;
                }
            }
            return arr;
        }


        public int partOfSortHoara(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            while(left <= right)
            {
                while (arr[left] < pivot) left++;
                while (arr[right] > pivot) right--;
                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }

            return left;
        }
        private int[] quickSortHoara(int[] arr, int start, int end)
        {
            if(start >= end)
            {
                return arr;
            }
            int rightStart = partOfSortHoara(arr, start, end);
            quickSortHoara(arr, start, rightStart - 1);
            quickSortHoara(arr,rightStart, end);
        }
        private void quickSortHoara(int[] arr) {
            quickSortHoara(arr, 0, arr.Length - 1);

        }

    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int[] arr = { 1, 75,5, 6,2 ,34, 22, 56, 8 };

            TypeSort sort = new TypeSort();
            /* int[] newarr = sort.BubbleSort(arr);*/
            int[] newarr = sort.SelectionSort(arr);
            string answer = string.Join(" ", newarr);
            Console.WriteLine(answer);
        }
        
    }
}
