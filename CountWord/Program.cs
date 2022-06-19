using System;
class CountingWord{         
    static void Main(string[] args)
    {

         char space = ' ';
         Console.WriteLine("Please enter a string");
         string str1=Convert.ToString(Console.ReadLine());

         int counting = str1.Count(f => (f == ' '));
         Console.WriteLine(counting+1);
         
    }
}