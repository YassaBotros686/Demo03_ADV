using Demo03_ADV.HashSet;
using Demo03_ADV.HashTable;
using Demo03_ADV.Sorted_Set;
using Demo03_ADV.SortedDictienare;
using System.Collections;
using System.Collections.Generic;

namespace Demo03_ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashTable
            //Hashtable setPhon = new Hashtable(new StringEqualityCompere()) {
            ////{"yassa" ,123 },{"botros" ,456 },{"william" ,789 }
            //["yassa"] = 123,
            //["botros"] = 456,
            //["william"] = 789
            //};

            ////setPhon.Add("yassa", 123);
            ////setPhon.Add("botros", 456);
            ////setPhon.Add("william", 789);

            ////foreach (object i in setPhon)
            ////{
            ////    Console.WriteLine(i);
            ////}

            ////indexer
            ////Use indexer to Get Value
            //Console.WriteLine(setPhon["yassa"]);
            ////Use indexer to Set Value
            //setPhon["yassa"] = 321;
            ////Use indexer to Add Value
            //setPhon["ahmed"] = 111;

            //if(setPhon.Contains("Yassa"))
            //    setPhon.Add("Yassa", 321); // will throw exception
            //else
            //    Console.WriteLine("key already Existed!");


            //foreach (DictionaryEntry item in setPhon)
            //{
            //    Console.WriteLine($"Key : {item.Key} , Value : {item.Value}");
            //}
            #endregion

            #region Dictionary01
            //Dictionary<string , int> dict = new Dictionary<string , int>()
            //{
            //    {"yassa" ,111 },
            //    {"botros" ,222 },
            //    {"william" ,333 }
            //};

            ////Get
            //Console.WriteLine(dict["yassa"]);
            ////Set
            //dict["yassa"] = 444;
            ////Add
            //dict["ahmed"] = 444;

            //foreach (KeyValuePair<string, int> item in dict)
            //    Console.WriteLine($"Name :{item.Key} ,Num :{item.Value}");


            //KeyValuePair<String, int>[] arr = {
            //    new ("yassa" ,123),
            //    new ("botros" ,456)
            //};

            //dict = new Dictionary<string , int>(arr ,new StringEqualityCompere());
            //dict.Add("Botros", 456); 
            #endregion

            #region Dictionary02
            //Employee E1 = new Employee(1, "yassa", 1000);
            //Employee E2 = new Employee(2, "botros", 2000);
            //Employee E3 = new Employee(3, "william", 3000);
            //Employee E4 = new Employee(4, "ahmed", 4000);
            //Dictionary<Employee ,String> dictEmp = new Dictionary<Employee, String>()
            //{
            //    [E1]="1st",
            //    [E2]="2cd",
            //    [E3]="3ed",
            //    [E4]="4er"
            //};
            //Employee E5 = new Employee(1, "yassa", 1000);
            //dictEmp.Add(E5 ,"5if");

            //foreach(var item in dictEmp)
            //    Console.WriteLine(item); 
            #endregion

            #region Sorted Dictionary Ex01
            //    SortedDictionary<String , int> PhonNot = new SortedDictionary<String, int>(new StringCompere()) {
            //        ["yassa"] = 111,
            //        ["botros"] = 222,
            //        ["william"] = 333,
            //        ["mkary"] = 444,
            //        ["ahmed"] = 555
            //};

            //    foreach (var item in PhonNot)
            //        Console.WriteLine(item); 
            #endregion

            #region Sorted Dictionary Ex02
            //Employee E1 = new Employee(1, "yassa", 1000);
            //Employee E2 = new Employee(2, "botros", 2000);
            //Employee E3 = new Employee(3, "william", 3000);
            //Employee E4 = new Employee(4, "ahmed", 4000);
            //SortedDictionary<Employee, String> sortedDict = new SortedDictionary<Employee, String>()
            //      {
            //          [E1] = "1st",
            //          [E2] = "2cd",
            //          [E3] = "3ed",
            //          [E4] = "4er"
            //      };

            //foreach (var item in sortedDict)
            //    Console.WriteLine(item); 
            #endregion

            #region SortedList
            //SortedList<String ,int> sortedDict = new SortedList<String, int>()
            //{
            //    ["yassa"] = 111,
            //    ["botros"] = 222,
            //    ["william"] = 333,
            //    ["mkary"] = 444
            //};

            //Console.WriteLine(sortedDict.GetValueAtIndex(0));
            //Console.WriteLine(sortedDict.GetValueAtIndex(2));

            //foreach (var item in sortedDict)
            //    Console.WriteLine(item); 
            #endregion

            #region HashSet Ex01
            //HashSet<int> set = new HashSet<int>();

            //set.Add(1);
            //set.Add(2);
            //set.Add(3);
            //set.Add(1);

            //foreach (var item in set)
            //    Console.WriteLine(item); 
            #endregion

            #region HashSet Ex02
            //HashSet<Serios> serios = new HashSet<Serios>()
            //{
            //    new Serios(1 ,"Game of Throne" ,5000),
            //    new Serios(1 ,"Game of Throne" ,5000),
            //    new Serios(2 ,"Breaking Bad" ,6000),
            //    new Serios(3 ,"Dark" ,7000)
            //};

            //foreach (var item in serios)
            //    Console.WriteLine(item);

            #endregion

            #region HashSet Method
            //HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////setB.ExceptWith(setA); // setB = setB - setA
            ////setB.IntersectWith(setA); // setB = setB ∩ setA
            ////setB.SymmetricExceptWith(setA);
            ////Console.WriteLine(setA.IsSubsetOf(setB));


            //foreach (var item in setB)
            //    Console.WriteLine(item); 
            #endregion

            #region Sorted Set 
            //SortedSet<int> sortedSet = new SortedSet<int>(new IntCompere()) { 5, 4, 3, 2, 1 };

            //    Console.WriteLine(sortedSet.Min());
            //    Console.WriteLine(sortedSet.Max());

            //    foreach (var item in sortedSet)
            //        Console.WriteLine(item);
        }
        #endregion
    }
}
