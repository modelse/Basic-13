using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void PrintAll()
        {
            for (int i = 0; i < 256; i ++){
                //No Need to reference System after importing the namespace "System"
                //System.Console.WriteLine(i);
                Console.WriteLine(i)
            }
        }
        public static void PrintOdds()
        {
            for (int i = 0; i < 256; i ++){
                if(i % 2==1){
                System.Console.WriteLine(i);}
            }
        }
        public static void PrintSum()
        {
            int sum=0;
            for (int i = 0; i < 256; i++){
                sum+=i;
                System.Console.WriteLine("Number:{0}, Sum:{1}", i, sum);
            }
        }
        public static void Iterate(int[] arr)
        {
            foreach (int item in arr){
                System.Console.WriteLine(item);
            }
        }
        public static int FindMax(int[] arr)
        {
            int max=arr[0];
            foreach (int item in arr){
                if(item > max){
                    max = item;
                }
            }
            System.Console.WriteLine(max);
            return max;
        }
        public static int FindAverage(int[] arr)
        {
            //For count we can use the build in arr.Length to access it
            int all=0;
            //int count=0;
            foreach(int item in arr){
                all+=item;
                count++;
            }
            //int avg= all/ count;
            int avg = all / arr.Length;
             System.Console.WriteLine(avg);
            return avg;
        }
        public static void oddArray()
        {
            //This is fine to be an int array rather than double
            double[] start = new double[256/2];
            int num = 0;
            for (int i = 1; i <= 255; i+=2){
                start[num] = i;
                num++;
            }
            for (int i = 0; 1 < start.Length; i++){
                System.Console.WriteLine("position {0} is {1}", i, start[i]);
            }
        }
        public static void Greater(double[] arr, int y)
        {
            int count=0;
            for(int i = 0; i<arr.Length; i++){
                if(arr[i]> y){
                    count++;
                }
            }
            System.Console.WriteLine("The number of items greater than y:{0}, is:{1}", y, count);
        }
        public static void Square(int[] arr)
        {
            for(int i=0; i<arr.Length; i++){
                arr[i]=arr[i]*arr[i];
            }
            
            for(int i=0; i<arr.Length; i++){
            System.Console.WriteLine("Position {0} is now {1}", i, arr[i]);
            }
        }
        public static void NoNegatives(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++){
                if (arr[i] < 0){
                    arr[i] = 0;
                }
            }
            for (int i = 0; i < arr.Length; i++){
                System.Console.WriteLine("position {0} is {1}", i, arr[i]);
            }
        }
         public static void MinMaxAvg(double[] arr)
        {
            double min = arr[0];
            double max = arr[0];
            double sum = 0;
            // if this is only used once, just invoke it where needed, no need for creating a new variable
            double length = arr.Length;
            for (int i = 0; i < arr.Length; i++){
                if (min > arr[i]){
                    min = arr[i];
                }
                if (max < arr[i]){
                    max = arr[i];
                }
                sum += arr[i];
            }
            double avg = sum / arr.length;
            System.Console.WriteLine($"min is {min}");
            System.Console.WriteLine($"max is {max}");
            System.Console.WriteLine($"avg is {avg}");
        }   
        public static void Shift(double[]arr)
        {
            for (int i = 0; i < arr.Length; i++){
                if (i == arr.Length-1){
                    arr[i] = 0;
                } else {
                    arr[i] = arr[i+1];
                }
            }
            for (int i = 0; i < arr.Length; i++){
                System.Console.WriteLine($"Position {i} is {arr[i]}");
            }
        }
        
        //This method requires to return the new string
        //public static void NumToString(double[]arr)
        public static object[] NumToString(double[] arr)
        {
            List<object> result = new List<object>();
            for (int i = 0; i < arr.Length; i++){
                if (arr[i] < 0){
                    result.Add("Dojo");
                } else {
                    result.Add(arr[i]);
                }
            }
            for (int i = 0; i < arr.Length; i++){   
                System.Console.WriteLine($"Position {i} is {result[i]}");
            }
            return result.ToArry();
        } 
        public static void Main(string[] args)
        {
            // PrintAll();
            // PrintOdds();
            // PrintSum();
            // Iterate(new int[] { 1, 3, 5, 7, 9, 10, 13 });
            // FindMax(new int[] { 1, -3, 5, 7, 9, 10, -13 });
            // FindAverage(new int[] { 2,10,3 });
            // oddArray();
            // Greater( new double[] {1,3,5,7,9}, 4);
            // Square(new int[] { 1, 3, 5, 7, 9, 10, 13 });
            // NoNegatives(new double[] { 1, -3, 5, 7, 9, 10, -13 });
            // MinMaxAvg(new double[] { 1, 3, 5, 7, 9, 10, 13 });
            // Shift(new double[] { 1, 3, 5, 7, 9, 10, 13 });
            NumToString(new double[] { 1, -3, 5, 7, 9, 10, -13 });

        }
    }
}
