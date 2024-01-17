using Bmi;

namespace Math
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //CheckReadOnlyParam(10);   
            //Print100FirstIntegers();
            int sumE = 0;
            int sumA = SumIntegerList(out sumE);

            Console.WriteLine("Sum All: {0} | Sum Evens: {1}", sumA, sumE);
        }

        //Tính tổng các số từ 1..100
        public static int SumIntegerList(out int sumEven)
        {
            int sumAll = 0, sumE = 0;
            for (int i = 0; i < 100; i++)
            {
                sumAll += i;
                if (i % 2 == 0)
                    sumE += i;
            }
            sumEven = sumE; //Tính xong bên trong đổ ra bên ngoài
            return sumAll;
        }

        //Tôi cần in ra 100 số tự nhiên liên tiếp bắt đầu từ 1
        static void Print100FirstIntegers()
        {
            Console.WriteLine("100 first integers");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + " ");
            }
        }

        static void CheckReadOnlyParam(in int n)
        {
            Console.WriteLine($"n before changing its value: {n}");
            //n = 2024; //change the value of n

            int m = n;
            //từ khóa in đứng kế bên biến local ở tham số biến n kế bên thành readonly = final
            //có nghĩa là không thể thay đổi giá trị n trong hàm
            //=> biến final/readonly ở mức local - mức hàm
            Console.WriteLine($"n after update its value: {n}");
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");

        //    double bmi = BmiCalculator.GetBmi(48, 1.6);

        //    Console.WriteLine($"Your weight status: {BmiCalculator.EvaluateWeightStatus(bmi)}");
        //}
    }
}
