using System;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Zack Dowd");
            Console.WriteLine(post1.ToString());


            ImagePost post2 = new ImagePost("Check out my new shoes", "Zack Dowd", 
                "https://images.com/shoes", true);
            Console.WriteLine(post2.ToString());


            VideoPost post3 = new VideoPost("Check out this cat flying", "Zack Dowd",
                "https://youtube.com/catvideo", 24, true);
            Console.WriteLine(post3.ToString());
            post3.Play();
            Console.WriteLine("Press any key to stop video");
            Console.ReadKey();
            post3.Stop();
            Console.ReadLine();
        }
    }
}
