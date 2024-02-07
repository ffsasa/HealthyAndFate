using Bmi;
//using System.Text;
//using Zodiac;

namespace Math
{
    internal class Program
    {

        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.WriteLine("Nhập ngày sinh của bạn: ");
        //    int.TryParse(Console.ReadLine(), out int day);
        //    Console.WriteLine("Nhập tháng sinh của bạn: ");
        //    int.TryParse(Console.ReadLine(), out int month);
        //    Console.WriteLine($"Your zodiac sign is {ZodiacCalcilator.GetZodiacSign(day, month)}");
        //}

        static void Main(string[] args)
        {
            int sumA, sumO = 0;

            sumA = SumOddList(ref sumO);
            Console.WriteLine("sum all: {0} | sum odd: {1}", sumA, sumO);

        }

        public static int SumOddList(ref int sumO)
        {
            int sumAll = 0, sumOdd = 0;
            for (int i = 0; i < 100; i++)
            {
                sumAll += i;
                if (i % 2 != 0)
                    sumOdd += i;
            }
            sumO = sumOdd;
            //REF lỏng lẻ hơn OUT vì khi ta không gán giá trị cho biến out thì không bị lỗi, thích thì gán để trả ra ngoài, không thì thôi
            //Muốn sử dụng ref thì biến lúc truyền vảo phải có giá trị từ trước, còn với out thì không cần.
            //Ref và Out đều là Pass by reference
            return sumAll;
        }










        //static void Main(string[] args)
        //{
        //    //CheckReadOnlyParam(10);   
        //    //Print100FirstIntegers();
        //    int sumE = 0;
        //    int sumA = SumIntegerList(out sumE);


        //    Console.WriteLine("Sum All: {0} | Sum Evens: {1}", sumA, sumE);
        //    //Có 2 cách xài chữ "OUT". Cách 1 ở trên.
        //    //Cách 2: Vừa khai báo vừa truyền vào hàm out. Tức là không cần tạo biến đó trước
        //    SumIntegerList(out int sum2);
        //    Console.WriteLine($"Sum Evens: {sum2}");
        //}

        //Tính tổng các số từ 1..100
        //Tính giùm luôn tổng số chẵn từ 1..100
        //Trong hàm thay đổi bên ngoài bị ảnh hưởng luôn
        //Đây là kĩ thuật truyền giá trị theo style tham chiếu: Pass by reference
        //Đưa cho function 1 biết ở ngoài hàm, trong hàm thay đổi value, ngoài hàm cũng bị luôn
        //Hàm nhận vào poiter

        //Khác truyền thống: Pass by value, chỉ lấy value đưa vào, còn lại không quan tâm

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
