using System;
using System.Reflection;

namespace uinheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Post post1 = new Post("Thanks for the blessings", true, "G M");

            //Console.WriteLine(post1.ToString());

            //ImagePost imagePost1 = new ImagePost("Check out my new kicks", "G M", "https://images.com/shoes", true);

            //VideoPost videoPost1 = new VideoPost("Check out my still mation", "G M", "https//video.com/project", 10, true);

            //Console.WriteLine(imagePost1.ToString());

            //Console.WriteLine(videoPost1);

            //videoPost1.Play();
            //Console.WriteLine("Press any key to stop the video");
            //Console.ReadKey();
            //videoPost1.Stop();

            Employee michael = new Employee("Miller", "Michael", 40000);

            michael.Work();
            michael.Pause();

            Boss chuckNorris = new Boss("Norris", "Chuck", 900000000,"Ferrari") ;

            chuckNorris.Lead();

            Trainees bob = new Trainees(32, 8, "Smith", "Bob", 10000);

            bob.Learn();
            bob.Work();

            Console.Read();
        }
    }
}
