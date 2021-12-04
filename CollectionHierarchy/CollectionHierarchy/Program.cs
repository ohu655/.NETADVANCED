using System;

namespace CollectionHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            IAddable addCollection = new AddCollection();
            IAddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            IMyList myList = new MyList();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{addCollection.AddToCollection(input[i])} ");
            }

            Console.WriteLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{addRemoveCollection.AddToCollection(input[i])} ");
            }

            Console.WriteLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{myList.AddToCollection(input[i])} ");
            }

            Console.WriteLine();

            int removeOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < removeOperations; i++)
            {
                Console.Write($"{addRemoveCollection.RemoveFromCollection()} ");
            }

            Console.WriteLine();

            for (int i = 0; i < removeOperations; i++)
            {
                Console.Write($"{myList.RemoveFromCollection()} ");

            }
        }
    }
}
