using System;

namespace MidTest
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i < 7; i++)
            {
                string buffer = "";
                for(int j = 0; j < 5; j++)
                {
                    if(j < i)
                    {
                        buffer += "*";
                    }
                    else
                    {
                        buffer += "-";
                    }
                }
            }
            Console.WriteLine(buffer);
        }
    }
}
