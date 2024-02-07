using Bmi;
using Zodiac;

namespace NewYearStory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice = 0;
            do
            {
                Console.WriteLine("1. Compute bmi index.");
                Console.WriteLine("2. Get the zodiac sign.");
                Console.WriteLine("3. Quit.");
                Console.Write("Input 1 ... 3: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        BmiCalculator.GetBmi();
                        break;
                    case 2:
                        Console.WriteLine();
                        ZodiacCalcilator.GetZodiac();
                        break;
                }
                if (choice != 1 && choice != 2 && choice != 3)
                    Console.WriteLine("Please enter 1 to 3!!!");
                Console.WriteLine();
            } while (choice != 3);            
            
            
            //var: là kĩ thuật khai báo biến nhưng không thèm chỉ ra datatype.
            // Datatype sẽ được suy luận ngầm từ lúc bạn gán giá trị cho biến đó,
            // Nghĩa là đến khi biên dịch app sang MSIL thì trình biên dịch sẽ từ giá datatype cho biến dựa trên value được gán
            // Vì value gán có datatype. Kĩ thuật này được gọi là TYPE INFRENCE - SUY LUẬN KIỂU
        }
    }
}
