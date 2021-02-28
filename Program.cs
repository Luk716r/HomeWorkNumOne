using System;

namespace HomeWorkNumTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool t = false;
            int CounterNum = 0;
            int EvenNumber = 0;
            while(t != true)
            {
                int NaturalNumber = Int32.Parse(Console.ReadLine());
                CounterNum++;
                if(NaturalNumber<1)
                {
                    t = true;
                    break;
                }
                if(NaturalNumber % 2 ==0)
                {
                    EvenNumber++;
                }
               
            }
            Console.WriteLine(CounterNum);
            Console.WriteLine(EvenNumber);

        }
    }
}
