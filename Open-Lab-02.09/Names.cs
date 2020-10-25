using System;

namespace Open_Lab_02._09
{
    public class Names
    {
        public string ConcatName(string firstName, string lastName)
        {
            string firstName = Peter;
            string lastName = Marcin;           
            string Name = String.Concat(lastName + " " + firstName);
            Console.WriteLine(Name);
            Console.ReadLine();

        }
    }
}
