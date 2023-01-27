using System;
using System.Linq;

namespace _27._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //50 ededinin 2 reqemli ve musbet eded olub olmadigini tapan proqram

            var N = 50;
            if (N > 9 && N < 100)
            {
                Console.WriteLine("N ededi musbet ve 2 reqemli ededdir");
            }
            else
            {
                Console.WriteLine("N ededi musbet ve 2 reqemli deyil");
            }




            //50 ededinin cut ve ya musbet eded olub olmadigini tapan proqram

            var N = 50;
            if (N > 0 && N % 2 == 0)
            {
                Console.WriteLine("N ededi musbet ve cut ededdir");
            }
            else
            {
                Console.WriteLine("N ededi musbet ve cut deyil");
            }




            //Verilmis 3 ededden cut olanlarin sayini tapan proqram

            var num1 = 19;
            var num2 = 33;
            var num3 = 44;

            var count = 0;
            if(num1%2 == 0)
            {
                count++;
            }
            if (num2 % 2 == 0)
            {
                count++;
            }
            if (num3 % 2 == 0)
            {
                count++;
            }
            Console.WriteLine(count);




            //5den 10a qeder ededlerin cemini tapan proqram

            var num1 = 5;
            var sum = 0;
            while (num1 < 10) 
            {
                sum += num1;
                num1++;
            }
            Console.WriteLine(sum);




            //1den 130a qeder 5e bolunen ededlerin sayini tap

            var num = 130;
            var x = 1;

            var count = 0;
            while(x<num)
            {
                if(x%5 == 0) 
                {
                    count++;
                }
                x++;    
            }
            Console.WriteLine(count);




            //A ededinden B ededinedek 3e bolunenlerin cemini tapan alqoritm

            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (A < B)
            {
                if (A % 3 == 0)
                {
                    sum += A;
                }
                A++;
            }
            Console.WriteLine(sum);




            //M ededinden N ededinedek olan ededlerin cemi

            var M = Convert.ToInt32(Console.ReadLine());
            var N = Convert.ToInt32(Console.ReadLine());

            var sum = 0;
            while (M < N)
            {
                sum += M;
                M++;
            }
            Console.WriteLine(sum);




            //1den N ededinedek 15e bolunen ededler var ya yox
           
            var N = Convert.ToInt32(Console.ReadLine());

            var count = 0;
            for(int i = 1; i < N;i++) 
            {
                if (i % 15 == 0) 
                {
                    count++;
                    break;
                }
            }
            if(count>0) 
            {
                Console.WriteLine("var");
            }
            else
            {
                Console.WriteLine("yoxdu");
            }




            //Verilmis ededler siyahisinda olan elementlerin cemini tap

            int[] nums = { 5, 10, 15, -5 };

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);




            //Verilmis eded sade yoxsa murekkebdi

            int num = 121;

            bool isPrime = true;
            for (var i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = true;
                    break;
                }
            }
            if (isPrime == true)
                Console.WriteLine("sadedir");
            else
                Console.WriteLine("murekkebdir");




            //Istediyimiz 2 ededin cemi

            Console.WriteLine("1ci ededi daxil et:");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            Console.WriteLine("2ci ededi daxil et:");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            string output = "Netice=" + (number1 + number2);
            output = $"{number1}+{number2}={number1 + number2}";

            Console.WriteLine(output);




            //Reqeme uygun heftenin gununu tap

            Console.WriteLine("Heftenin gununu daxil et:");
            var dayStr = Console.ReadLine();
            var day = Convert.ToInt32(dayStr);

            if (day == 1)
            {
                Console.WriteLine("Bazar ertesi");
            }
            else if (day == 2)
            {
                Console.WriteLine("Cersenbe axsami");
            }
            else if (day == 3)
            {
                Console.WriteLine("Cersenbe");
            }
            else if (day == 4)
            {
                Console.WriteLine("Cume axsami");
            }
            else if (day == 5)
            {
                Console.WriteLine("Cume");
            }
            else if (day == 6)
            {
                Console.WriteLine("Senbe");
            }
            else if (day == 7)
            {
                Console.WriteLine("Bazar");
            }




            //Verilmis ededler sirasinda menfi edede qeder olan ededlerin cemini tap

            int[] numbers = new int[] { 5, 8, 17, -4, 9 };
            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    break;
                }
                sum += numbers[i];
            }
            Console.WriteLine(sum);




            // 3 ededden en boyuyunu tap

            int a, b, c;
            Console.WriteLine("1ci ededi daxil et:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("2ci ededi daxil et:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("2ci ededi daxil et:");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a + "En boyukdu");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + "En boyukdu");
            }
            else if (c > b && c > a)
            {
                Console.WriteLine(c + "En boyukdu");
            }
            else
            {
                Console.WriteLine("Hamsi beraberdi");
            }
            Console.WriteLine();




            //Verilmiş ədələr siyahısında mənfi ədəd olub olmadığını tapan proqram

            int[] nums = new int[] { 5, -3, 15, -5 };
            int Negative_count = 0; Negative_count++;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    Negative_count++;
                    Console.WriteLine("Menfi eded var");
                }
                else
                {
                    Console.WriteLine("Menfi eded yoxdur");
                }
            }



            //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan proqram

            int[] nums = new int[] { 1, 4, 8, 17 };
            int maxNum = nums.Max(z => z);
            Console.WriteLine(+maxNum);







        }
    }
}