using System.Globalization;

namespace task02._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("eded tekdirmi: "+ number.IsOdd());

            //Console.WriteLine("eded cutdurmu: "+ number.IsEven());

            //string Text=Console.ReadLine();
            //Console.WriteLine("textin icinde ede varmidir: "+Text.IsContainsDigit());

            //string text = Console.ReadLine();
            //Console.WriteLine("texti capitalize et: "+ text.ToCapitalize());

            //int[] result = "banana".GetValueIndexes('a');
            //Console.WriteLine(string.Join(", ", result));

            //string text=Console.ReadLine();
            //Console.WriteLine(text.GetFirstSentence());

            //string text=Console.ReadLine();
            //Console.WriteLine(text.GetSecondWord());

            //string text=Console.ReadLine();
            //string word_=Console.ReadLine();
            //Console.WriteLine(text.MatchCount(word_));


            //int number=int.Parse(Console.ReadLine());
            //Console.WriteLine(number.IsPalindrome());

            //Console.WriteLine(Student.CheckGroupNo("401"));



            Student s1 = new ProgrammingStudent("sevgi", "p401");
            Student s2 = new DesignStudent("gunel", "p401");
            s1.DoHomework();
            s2.DoHomework();

        }

       
    }
    
}
