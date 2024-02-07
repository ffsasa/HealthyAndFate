using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    public class BmiCalculator
    {
        /// <summary>
        /// This method will return Bmi index in English or VietNamese base on weight and height.
        /// </summary>
        public static void GetBmi()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1. Get Bmi English.");
                Console.WriteLine("2. Get Bmi VietNamese.");
                Console.Write("Input 1 ... 2: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice != 1 && choice != 2)
                {
                    Console.WriteLine("Please input 1 or 2!!!");
                    Console.WriteLine();
                }
                double w, h;
                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            Console.Write("Input your weight(kg): ");
                            double.TryParse(Console.ReadLine(), out w);
                            Console.Write("Input your height(m): ");
                            double.TryParse(Console.ReadLine(), out h);
                            if (!CheckInput(w, h))
                                Console.WriteLine("Invalid input, please input again!");
                            else
                                break;
                            Console.WriteLine();
                        }                     
                        Console.WriteLine(EvaluateWeightStatusEn(GetBmi(w, h)));
                        Console.WriteLine("Note: BMI index is only correct for normal people!");
                        break;
                    case 2:
                        while (true)
                        {
                            Console.Write("Nhập cân nặng của bạn(kg): ");
                            double.TryParse(Console.ReadLine(), out w);
                            Console.Write("Nhập chiều cao của bạn(m): ");
                            double.TryParse(Console.ReadLine(), out h);
                            if (!CheckInput(w, h))
                                Console.WriteLine("Đầu vào không hợp lệ, vui lòng nhập lại!");
                            else
                                break;
                            Console.WriteLine();
                        }
                        Console.WriteLine(EvaluateWeightStatusVi(GetBmi(w, h)));
                        Console.WriteLine("Chú ý: Chỉ số Bmi chỉ đúng với người bình thường!");
                        break;
                }
            } while (choice != 1 && choice != 2);
        }

        /// <summary>
        /// This method will return Bmi index base one weight and height.
        /// </summary>
        /// <param name="weight">Weight is a double.</param>
        /// <param name="height">Height is a double.</param>
        /// <returns></returns>
        public static double GetBmi(double weight, double height) => weight / (height * height);

        /// <summary>
        /// This method will return body condition in English based on Bmi index.
        /// </summary>
        /// <param name="bmi">Bmi index.</param>
        /// <returns></returns>
        public static string EvaluateWeightStatusEn(double bmi)
        {
            if (bmi < 18.5)
                return "You're too thin!!!";
            if (bmi < 25)
                return "You are the perfect one in weight & shape.";
            if (bmi < 30)
                return "You are overweight!!!";
            return "You are obese!!!";
        }

        /// <summary>
        /// This method will return body condition in VietNamese based on Bmi index.
        /// </summary>
        /// <param name="bmi">Bmi index.</param>
        /// <returns></returns>
        public static string EvaluateWeightStatusVi(double bmi)
        {
            if (bmi < 18.5)
                return "Bạn đang quá ốm!!!";
            if (bmi < 25)
                return "Bạn là người hoàn hảo về cân nặng và hình dáng.";
            if (bmi < 30)
                return "Bạn đang thừa cân!!!";
            return "Bạn đang bị béo phì!!!";
        }

        /// <summary>
        /// This method will check value of weight and height.
        /// </summary>
        /// <param name="w">Weight is a double.</param>
        /// <param name="h">Height is a double.</param>
        /// <returns></returns>
        private static bool CheckInput(double w, double h)
        {
            if (w<=0||h<=0||h>=3||w>=600)
                return false;
            return true;
        }
    }
}
