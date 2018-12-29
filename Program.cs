using System;

class Program
{
    static System.Collections.Generic.IEnumerable<int> Range(int from, int to) 
    {
        for (int i = from; i <= to; i++) 
        {
            yield return i;
        }
        yield break;
    }

    static void Main(string[] args)
    {
        foreach (int i in Range(1,100)) 
        {
            string response = "";

            if(i % 3 == 0)
            {
                response += "Fizz";
            }

            if(i % 5 == 0)
            {
                response += "Buzz";
            }

            if(response == "")
            {
                response = i.ToString();
            }

            Console.WriteLine(response);
        }
    }
}
