using System;

namespace Arrays

{
    class Program
    {
        static void Main(string[] args)
        {   //declare a 2D Array
            string[,] matrix;

            //3D array
            int[,,] threeD;

            int[,] array2D = new int[,]
            {
                {1,2,3 }, //row 0   
                {4,5,6 }, //row 1 
                {7,8,9 }  //row 2 
            };
            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.WriteLine("Access 7 value is {0}", array2D[2, 0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001" },
                    {"010","011" },
                    {"Hi there", "What's up" }
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Another one", "Last entry" }
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                    {"one" ,"two" },
                    {"three","four" },
                    {"five","six" }
                };
            array2DString[1, 1] = "chicken";

            int dimensions = array2DString.Rank;
           
            
            
            Console.WriteLine("The value is {0}", dimensions);
            Console.ReadKey();

        

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


        }
    }
}
