using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Arrays

{
    class Program
    {
        static void Main(string[] args)
        {

            //declare jaggedArray
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[5];
            //jaggedArray[1] = new int[3];
            //jaggedArray[2] = new int[2];

            //jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            //jaggedArray[1] = new int[] { 1, 2, 3 };
            //jaggedArray[2] = new int[] { 13, 21 };

            ////alternate way:
            //int[][] jaggedArray2 = new int[][]
            //{
            //    new int[]{ 2, 3, 5, 7, 11 },
            //    new int[] { 1, 2, 3 },
            //    new int[] { 13, 21 }
            //};

            //for (var i = 0 ; i < jaggedArray2.Length; i++)
            //{

            //    Console.WriteLine("Elements of array {0}", i);
            //    for (int j = 0; j < jaggedArray2[i].Length; j++)
            //    Console.WriteLine("{0} ", jaggedArray2[i][j]);


            //}

            //string[][] friendsAndFamily = new string[][]
            //{
            //    new string [] {"Gary","Nyoka"},
            //    new string [] {"Rhett","Debbie"},
            //    new string [] {"Pat", "Cris"}
            //};

            //Console.WriteLine("Hello I'm {0} and you are {1} pleased to meet you", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            //Console.WriteLine("Hello I'm {0} and you are {1} pleased to meet you", friendsAndFamily[1][0], friendsAndFamily[2][0]);
            //Console.WriteLine("Hello I'm {0} and you are {1} pleased to meet you", friendsAndFamily[0][1], friendsAndFamily[2][1]);



            //declare a 2D Array
            //    string[,] matrix;

            //    //3D array
            //    int[,,] threeD;

            //    int[,] array2D = new int[,]
            //    {
            //        {1,2,3 }, //row 0   
            //        {4,5,6 }, //row 1 
            //        {7,8,9 }  //row 2 
            //    };
            //    Console.WriteLine("Central value is {0}", array2D[1, 1]);
            //    Console.WriteLine("Access 7 value is {0}", array2D[2, 0]);

            //    string[,,] array3D = new string[,,]
            //    {
            //        {
            //            {"000","001" },
            //            {"010","011" },
            //            {"Hi there", "What's up" }
            //        },
            //        {
            //            {"100", "101"},
            //            {"110", "111"},
            //            {"Another one", "Last entry" }
            //        }
            //    };

            //    string[,] array2DString = new string[3, 2]
            //    {
            //            {"one" ,"two" },
            //            {"three","four" },
            //            {"five","six" }
            //        };
            //    array2DString[1, 1] = "chicken";

            //    int dimensions = array2DString.Rank;

            //    int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            //    Console.WriteLine("The value is {0}", dimensions);
            //    Console.ReadKey();



            //string[] friends = new string[5] { "Jeremy", "Rhett", "Alan", "Manuel", "Don" };

            //int[] nums = new int[10];

            //for(int i =0; i < 10; i++)
            //{
            //    nums[i] = i + 10;
            //}

            //for(int j =0; j < nums.Length; j++)
            //{
            //    Console.WriteLine("Element {0} = {1}", j, nums[j]);
            //}
            //int counter = 0;
            //foreach(int k in nums)
            //{
            //    Console.WriteLine("Element {0} = {1}", counter, k); counter ++;
            //}
            //int fcounter = 0;
            //foreach(string l in friends)
            //{
            //    Console.WriteLine("Hello {0} my number {1} friend",l, fcounter); fcounter++;
            //}


            //int[] grades = new int[5];

            //grades[0] =20;
            //grades[1]= 15;
            //grades[2]= 12;
            //grades[3]= 9;
            //grades[4]= 7;

            //Console.WriteLine("grades at index 0 : {0}", grades[0]);

            //string input=Console.ReadLine();
            //grades[0] = int.Parse(input);
            //Console.WriteLine("grades at index 0 : {0}", grades[0]);
            //Console.ReadKey();

            //int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            //Console.WriteLine("Length of gradesOfMathStudentsA {0}",  gradesOfMathStudentsA.Length);
            //Console.WriteLine("Length of gradesOfMathStudentsB {0}", gradesOfMathStudentsB.Length);

            //int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            //double averageResult = GetAverage(studentsGrades);

            //foreach(int grade in studentsGrades)
            //{
            //    Console.WriteLine(" {0} ", grade);
            //}

            ////Console.WriteLine("The average is: {0}", averageResult);
            //int[] happiness = { 2, 3, 4, 5, 6, };
            //SunIsShining(happiness);

            //foreach(int y in happiness)
            //{
            //    Console.WriteLine(y);
            //}
            //Console.Read();

            //declared with undefined amount of objects
            //ArrayList myArrayList= new ArrayList();
            //declared with defined amount of objects
            //ArrayList myArrayList2 = new ArrayList(100);

            //myArrayList.Add(25);
            //myArrayList.Add("Hello");
            //myArrayList.Add(13.37);
            //myArrayList.Add(13);
            //myArrayList.Add(128);
            //myArrayList.Add(25.3);
            //myArrayList.Add(13);

            // delete element with specific value 
            //myArrayList.Remove(13);
            //myArrayList.Remove(13);
            //myArrayList.Remove(13);

            //delet element at specific index 
            //myArrayList.RemoveAt(0);

            //Console.WriteLine(myArrayList.Count);

            //double sum = 0;

            //foreach(object obj in myArrayList)
            //{
            //    if(obj is int)
            //    {
            //        sum += Convert.ToDouble(obj);
            //    }else if(obj is double)
            //    {

            //        sum += (double)obj;
            //    }
            //    else if(obj is string)
            //    {
            //        Console.WriteLine(obj);
            //    }
            //}
            //Console.WriteLine(sum);

            //imutable-limited to one type
            int[] scores = new int[] { 99, 96, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4 };

            list.Add(0);
            list.Add(32);
            list.Sort();
            list.RemoveRange(2, 2);


            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Contains(4));

            int index = list.FindIndex(x => x == 4);
            Console.WriteLine(list[index]);

            list.RemoveAt(index);

            list.ForEach(i => Console.WriteLine(i));

            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 4 });


            foreach(object o in arrayList){

                Console.WriteLine(o);
            }

            Console.ReadKey();


        }


        //static void SunIsShining (int[] x)
        //{
        //    for (int i = 0; i < x.Length; i++)
        //        x[i] += 2;
            
        //}
       
        
        //static double GetAverage(int[] gradesArray)
        //{
        //    int size = gradesArray.Length;
        //    double average;
        //    int sum = 0;

        //    for(int i =0; i< size; i++)
        //    {
        //        sum += gradesArray[i];
        //    }
        //    average = (double)sum / size;
        //    return average;
        //}
            
    }

    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}
