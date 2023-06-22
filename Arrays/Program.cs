using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names; // can reference any array of strings
            names = new string[4];

            // Storing items at index positions
            names[0] = "Jakes";
            names[1] = "Yvettes";
            names[2] = "Pitshou";
            names[3] = "Ida";

            // looping through the names
            for (int i = 0; i < names.Length; i++)
            {
                // output the item at index position i
                Console.WriteLine(names[i]);
            }
        }
    }
}
