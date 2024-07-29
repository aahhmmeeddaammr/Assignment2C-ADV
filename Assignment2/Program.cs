using Assignment2.FixedList;
using System.Collections;
using System.Collections.Generic;

namespace Assignment2
{
    internal class Program
    {
        public static void ReverseArray(ref ArrayList array)
        {
            if (array == null) throw new ArgumentNullException("array");

            for(int i =0; i < array.Count/2; i++)
            {
                object Temp = array[i] ?? 0;
                array[i] = array[array.Count - i - 1];
                array[ array.Count  - i - 1] = Temp;
            }
        }

        public static List<int> GetAllEven(List<int> list)
        {
            if (list == null) throw new ArgumentNullException("list");
            List<int> result = new List<int>();
            foreach (int item in list)
            {
                if(item % 2 == 0) result.Add(item);
            }
            return result;
        }
        public static int GetNonRepetedChar(string s)
        {
            if (s == null)  throw new ArgumentNullException("s");
            Dictionary<char , int> frq = new Dictionary<char , int>();  
            foreach (char c in s)
            {
                if (frq.ContainsKey(c))
                    frq[c]++;
                else 
                    frq.Add(c, 1);
            }
            foreach(var x in frq)
            {
                if(x.Value == 1)
                {
                    return s.IndexOf(x.Key);
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            #region Implemented Examples Of Collections

            #region ArrayList

            //ArrayList arrayList = new ArrayList();

            //string x = "";

            //while (true) // I Dont Know The Size Of Array
            //{
            //    x = Console.ReadLine();
            //    if (x == "11")
            //    {
            //        break;
            //    }
            //    arrayList.Add(x);
            //}

            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3); // Multi Data Types 

            #endregion

            #region List
            //List<string> List = new List<string>();

            //string x = "";

            //while (true) // I Dont Know The Size Of Array
            //{
            //    x = Console.ReadLine();
            //    if (x == "11")
            //    {
            //        break;
            //    }
            //    List.Add(x);
            //}
            //List.Add(1); // error 
            #endregion

            #region Stack
            //Stack<int> s = new Stack<int>();
            //s.Push(1);
            //s.Push(2);
            //s.Push(3);
            //while (s.Count > 0)
            //{
            //    Console.WriteLine(s.Pop()); // print in Reverse Order
            //}
            #endregion

            #region Queue
            //Queue<int> q = new Queue<int>();    

            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //while (q.Count > 0) {
            //    Console.WriteLine(q.Dequeue()); // print in order 
            //} 
            #endregion

            #region Dictionary
            //Dictionary<string, int> salary = new Dictionary<string, int>();
            //salary.Add("Ahmed", int.MaxValue);
            //salary.Add("Omar", int.MinValue);  
            #endregion

            #region HashSet
            //HashSet<int> IDs = new HashSet<int>();
            //IDs.Add(1);
            //IDs.Add(1);
            //IDs.Add(1);
            //IDs.Add(1);
            //IDs.Add(1);
            //IDs.Add(1);
            //Console.WriteLine(IDs.Count);// will give me 1 because id must be unique  
            #endregion

            #endregion

            #region Reverse ArrayList
            //ArrayList array = new ArrayList() { 1};
            //ReverseArray(ref array);
            //foreach(int i in array)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Find Evens
            //List<int> list = new List<int>() { 1,2,3,4,5,6};
            //List<int> r =GetAllEven(list);
            //foreach (int item in r)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region  first non-repeated character 
            //string s = "ahahmmed";
            //Console.WriteLine(GetNonRepetedChar(s)); 
            #endregion

            #region FixedSizeList
            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(3);
            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(3); // error
            //Console.WriteLine(fixedSizeList.Find(-1)); // error 
            #endregion
        }
    }
}
