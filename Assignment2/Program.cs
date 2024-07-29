using Assignment2.FixedList;
using System.Collections;

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
