using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task02._11
{
    public static class ExtentionMethods
    {
        //public static bool IsOdd(this int number)
        //{
        //    if (number % 2 != 0)
        //        return true;
        //    return false;
        //}
        //public static bool IsEven(this int number)
        //{
        //    if (number % 2 == 0)
        //        return true;
        //    return false;
        //}
        //public static bool IsContainsDigit(this string Text)
        //{
        //    foreach(char c in Text)
        //    {
        //        if(char.IsDigit(c))
        //            return true;
        //    }
        //    return false;

        //}


        //public static string ToCapitalize(this string text)
        //{
        //    string newtext = char.ToUpper(text[0]).ToString();
        //    for(int i=1; i<text.Length; i++)
        //    {
        //        newtext = newtext + char.ToLower(text[i]);
        //    }
        //    return newtext;
        //}


        //public static int[] GetValueIndexes(this string text,char element)
        //{
        //    int count = 0;
           
        //    for(int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i]==element)
        //        {
        //            count++;
        //        }
        //    }
        //    int[] array = new int[count];
        //    int index = 0;
        //    for(int i=0; i<text.Length; i++)
        //    {
        //        if (text[i] == element)
        //        {
        //            array[index] = i;
        //            index++;
        //        }
        //    }
        //    return array;
        //}



        //public static string GetFirstSentence(this string text)
        //{
        //    int k = 0;
        //    foreach (char c in text)
        //    {
                
        //        if(c=='.' || c=='?' || c=='!' || c==';' || c==':')
        //        {
        //            k=text.IndexOf(c);
        //        }

        //    }
        //    return text.Substring(0, k);
        //}
        


        //public static string GetSecondWord(this string text)
        //{
        //    text = text.Trim();
        //    int start_index = text.IndexOf(' ');
        //    int end_index= text.IndexOf(" ", start_index+1);
        //    return text.Substring(start_index+1, end_index-start_index-1);           
        //}


        //public static int MatchCount(this string text,string word_)
        //{
        //    if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(word_))
        //        return 0;

        //    text = text.Trim();
        //    string[] words=text.Split(' ');
        //    int count=0;
        //    foreach (string word in words)
        //    {
        //        if(word.Equals(word_, StringComparison.OrdinalIgnoreCase))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}



        //public static bool IsPalindrome(this int number)
        //{
        //    string numStr = number.ToString();
        //    int l = numStr.Length;
        //    string first_part = numStr.Substring(0, l / 2);
        //    string last_part;
        //    if (l % 2 == 0) 
        //    {
        //        last_part = numStr.Substring(l / 2, l / 2);
        //    }
        //    else 
        //    {
        //        last_part = numStr.Substring(l / 2 + 1, l / 2);
        //    }
        //    last_part = new string(last_part.Reverse().ToArray());
        //    return first_part.Equals(last_part);

        //}



    }
    //public class Student
    //{
    //    public string FullName { get; set; }
    //    public string GroupNo { get; set; }
    //    public int Age { get;set; }

    //    public Student(string fullname, string groupNo, int age)
    //    {
    //        FullName = fullname;
    //        GroupNo = groupNo;
    //        Age = age;
    //    }
    //    public static bool CheckGroupNo(string groupNo)
    //    {
    //        if (string.IsNullOrEmpty(groupNo))
    //            return false;
    //        if (groupNo.Length != 4)
    //            return false;
    //        char firstChar = groupNo[0];
    //        if (!char.IsUpper(firstChar))
    //            return false;
    //        for (int i = 1; i < 4; i++)
    //        {
    //            if (!char.IsDigit(groupNo[i]))
    //                return false;
    //        }
    //        return true;
    //    }

    //    public static bool CheckFullname(string fullname)
    //    {
    //        if (string.IsNullOrEmpty(fullname))
    //            return false;
    //        string[] parts = fullname.Split(' ');
    //        if (parts.Length != 2) 
    //            return false;
    //        if (string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]))
    //            return false;
    //        return true;
    //    }
    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"Fullname: {FullName}, GroupNo: {GroupNo}, Age: {Age}");
    //    }

    //}


    //public class Student
    //{
    //    public string Fullname { get; set; }
    //    public string GroupNo { get; set; }
    //    public Student(string fullname, string groupNo)
    //    {
    //        Fullname = fullname;
    //        GroupNo = groupNo;
    //    }
    //    public virtual void DoHomework()
    //    {
    //        Console.WriteLine($"{Fullname} is doing general homework.");
    //    }
    //}
    //public class ProgrammingStudent : Student
    //{
    //    public ProgrammingStudent(string fullname, string groupNo) : base(fullname, groupNo) { }

    //    public override void DoHomework()
    //    {
    //        Console.WriteLine($"{Fullname} is writing code for homework.");
    //    }
    //}
    //public class DesignStudent : Student
    //{
    //    public DesignStudent(string fullname, string groupNo) : base(fullname, groupNo) { }

    //    public override void DoHomework()
    //    {
    //        Console.WriteLine($"{Fullname} is creating design homework.");
    //    }
    //}




}
