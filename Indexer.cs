using System;

namespace Indexers
{
    class Indexers_Example
    {
        private string[] sub_name = new string[5];

        public string this[int index]
        {
            get { return sub_name[index]; }
            set { sub_name[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Indexers_Example ie = new Indexers_Example();

            ie[0] = "dotnet";
            ie[1] = "Java";
            ie[2] = "SE";
            ie[3] = "Project-I";
            ie[4] = "Computer Networks";

            Console.WriteLine("Subjects of 6th C.E.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject-{0}: {1}", i + 1, ie[i]);
            }

            Console.ReadKey();
        }
    }
}
