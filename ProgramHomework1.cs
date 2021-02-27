using System;

namespace HomeWorkNumOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int RememberNum = 0;
            bool t = false;
            Console.WriteLine("Введите первое число последовательности больше нуля");
            int NumOne = Int32.Parse(Console.ReadLine());
            if (NumOne < 0)
            {
                Console.WriteLine("Ваше число меньше или равно нулю,введите другое");
                NumOne = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите второе число");
            int NumTwo = Int32.Parse(Console.ReadLine());
            int min = NumOne + NumTwo;
            while(t!= true)
            {
                //Console.WriteLine("Введите следующее число последовательности");
                int Num_1 = Int32.Parse(Console.ReadLine());

                if (Num_1 < 0)
                {
                    t = true;
                    break;
                }
                int Num_2 = Int32.Parse(Console.ReadLine());
                
                if (Num_2 < 0)
                {
                    t = true;
                    break;
                }
                RememberNum = Num_1 + Num_2;
                if (min > RememberNum) 
                {
                    min = RememberNum;
                }
            }
            Console.Write("Минимальная сумма   ");
            Console.WriteLine(min);
        }
    }
}
