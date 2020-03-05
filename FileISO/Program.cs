using System;
using System.IO;

namespace FileISO                 //Name: Sean Epley
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nums = File.ReadAllLines("Numbers.txt"); //make a list of lines in numbers.txt
            int [] ints = new int[nums.Length];
            StreamWriter odd = new StreamWriter("Odd.txt");
            StreamWriter even = new StreamWriter("Even.txt");
            for (int i = 0; i < nums.Length; i++)
            {
                ints[i]=(int.Parse(nums[i])); //parse the string lines into ints and store them in an int array
            }
            for (int i=0;i<ints.Length;i++)
            {
                if (ints[i] % 2 == 0) //if even
                {
                    even.WriteLine(ints[i]); //write to even file
                }else
                {
                    odd.WriteLine(ints[i]); //write to odd file
                }
            }
            odd.Close();
            even.Close();
        }
    }
}
