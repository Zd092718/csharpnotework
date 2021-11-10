namespace IEnumerableDemo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> numList = new List<int>() { 1, 2, 3 };

            int[] numArray = new int[] { 4, 5, 6, 7 };

            Console.WriteLine(" ");
            CollectionSum(numArray);
                       
            Console.WriteLine(" ");
            CollectionSum(numList);


        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            //sum variable to store sum of numbers in anyCollection
            int sum = 0;

            //for each number in the collection passed to this method
            foreach (int num in anyCollection)
            {
                sum += num;
            }

            Console.WriteLine($"Sum is {sum}");
        }
    }
}