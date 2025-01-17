using System.Collections;

namespace AdvC_2_Demo
{
    internal class Program
    {
        //public static int SumArrayList ( ArrayList arrayList)
        //{
        //    int Sum = 0;
        //    if (arrayList is not null )
        //    {
        //        for(int i=0; i<arrayList.Count; i++)
        //        {
        //            Sum += (int)arrayList[i]; //Casting from object to int "Unsafe"
        //        }
        //    }
        //    return Sum;
        //}
        static void Main(string[] args)
        {

            #region Non - Generic Collections
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine($"Count of arraylist {arrayList.Count}");
            // Count => Actuall Number of elements in arrayList
            //Console.WriteLine($"Capacity of arrayList {arrayList.Capacity}");
            // Capacity => Number of elements that arrayList can hold
            //arrayList.Add(1);
            //Upon adding the first element to the list thr capacity
            //will increased to _defaultCapacity 4
            // New array created at the heap with size 4
            //Console.WriteLine($"After adding first element");
            //Console.WriteLine($"Count of arrayList {arrayList.Count}"); //1
            //Console.WriteLine($"Capacity of arrayList {arrayList.Capacity}"); //4
            //arrayList.Add(2);
            //arrayList.AddRange(new int[] { 3, 4 });
            //Console.WriteLine($"Count of arrayList {arrayList.Count}");
            //Console.WriteLine($"Capacity of arrayList {arrayList.Capacity}");
            //arrayList.Add(5);
            // Create a new array at heap with double the size = 8
            // Take old elements and adding new elements => to the new array
            //Console.WriteLine($"Count of arrayList {arrayList.Count}"); //5
            //Console.WriteLine($"Capacity of arrayList {arrayList.Capacity}"); //8

            //ArrayList arrayList02 = new ArrayList() { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count of arrayList {arrayList02.Count}");
            //Console.WriteLine($"Capacity of arrayList {arrayList02.Capacity}");
            //arrayList02.Add(6);
            //Console.WriteLine($"Count of arrayList {arrayList02.Count}");
            //Console.WriteLine($"Capacity of arrayList {arrayList02.Capacity}");
            //---------------------------------------
            // 4 int => 4*4 = 16 byte [ Unused Bytes ]
            // Freses || Delete || Deallocate unused bytes
            //arrayList02.TrimToSize();
            //Console.WriteLine($"Count of arrayList {arrayList02.Count}");//6
            //Console.WriteLine($"Capacity of arrayList {arrayList02.Capacity}");//6
            // Create a new array at heap with size = count of elemets
            // Take old elements + new elements in new array
            // old array now is unreachable
            //---------------------------------------
            //arrayList02.Add(7); //Castong from value type to reference type
            //arrayList02.Add(8);
            //arrayList02.Add("Abdelrahman");
            // arrayList => Hetrogenous List
            // Compiler can't enforce type safty at compilation

            //foreach ( int Number in arrayList02 )
            //{
            //    Console.WriteLine(Number);
            //}
            //int SumResult = SumArrayList(arrayList02);
            //Console.WriteLine($"The result is {SumResult}"); 
            #endregion

            #region Generic Collections [List]
            ////List<int> Numbers = new List<int>();
            ////Console.WriteLine($"Count of arrayList {Numbers.Count}");
            ////Console.WriteLine($"Capacity of arrayList {Numbers.Capacity}");
            ////Numbers.Add(1);
            //////Upon adding the first element to the list thr capacity
            //////will increased to _defaultCapacity,
            ////// New array created at the heap with size 4
            ////Console.WriteLine($"Count of arrayList {Numbers.Count}");//1
            ////Console.WriteLine($"Capacity of arrayList {Numbers.Capacity}");

            ////Numbers.AddRange(new int[] { 2, 4, 6 });
            ////Console.WriteLine($"Count of arrayList {Numbers.Count}");//4
            ////Console.WriteLine($"Capacity of arrayList {Numbers.Capacity}");//4
            ////Numbers.Add(5);
            ////Console.WriteLine($"Count of arrayList {Numbers.Count}");
            ////Console.WriteLine($"Capacity of arrayList {Numbers.Capacity}");
            ////Numbers.TrimExcess();
            //////Create new array size = count of elements
            //////New array size = 5
            //////Old array unreachabl
            ////Console.WriteLine($"Count of arrayList {Numbers.Count}");
            ////Console.WriteLine($"Capacity of arrayList {Numbers.Capacity}");


            //Console.WriteLine($"Count of arrayList {Numbers.Count}");
            //Console.WriteLine($"Capacity of arrayList {Numbers.Capacity}");
            //Numbers.Add(6);
            //Console.WriteLine($"Count of arrayList {Numbers.Count}");
            //Console.WriteLine($"Capacity of arrayList {Numbers.Capacity}");
            //Numbers[0] = 12345; //Using indexer as Setter
            //Numbers[9] = 1000;  //Invalid
            //// Can't use indexer for adding
            //for (int i = 0; i < Numbers.Count; i++)
            //{
            //    Console.WriteLine(Numbers[i]); //Using indexer as Getter
            //}
            ////foreach (int Number in Numbers)
            ////{
            ////    Console.WriteLine(Number);
            ////}

            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine(Helper.SumList(Numbers));
            //Numbers.Add("Abdelrahman");
            #endregion

            #region List Methods
            List<int> Numbers02 = new List<int>();
            //Numbers02.Add(1); // Add one element
            //Numbers02.AddRange(new int[] { 2, 3 }); //Add range of element
            //Numbers02.Insert(3, 4); //Insert element into specific index
            //Numbers02.InsertRange(4, new int[] { 5, 6 });
            //Numbers02.Clear(); //Remove all elements
            //Console.WriteLine(Numbers02.BinarySearch(2));
            //Console.WriteLine(Numbers02.Contains(4));
            //Console.WriteLine(Numbers02.Capacity);
            //Console.WriteLine(Numbers02.EnsureCapacity(8));
            //Console.WriteLine(Numbers02.IndexOf(1));
            //Console.WriteLine(Numbers02.LastIndexOf(1));
            //foreach (int i in Numbers02)
            //{
            //    Console.WriteLine(i);
            //}













            #endregion

        }
    }
}
