namespace Zodiac
{
    //Đây là đoạn ghi chú bình thường trong code, không theo chuẩn quy ước mà MS đề nghị
    //MS đề nghị 1 chuẩn biết document hướng dẫn sử dụng hàm
    //Tương tự như Swagger-UI là chuẩn document hướng dẫn sử dụng API

    /// <summary>
    /// This class will return the zodiac sign base on the day and month of birth, both in English and Vietnamese
    /// </summary>
    public class ZodiacCalcilator
    {

        //Hàm trả về cung hoàng đạo của bạn dựa trên tháng và ngày sinh
        /// <summary>
        /// This method will return the Zodiac sign in English/Vietnamese base on day and month of birth.
        /// </summary>
        public static void GetZodiac()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1. Get Zodiac English.");
                Console.WriteLine("2. Get Zodiac VietNamese.");
                Console.Write("Input 1 ... 2: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice != 1 && choice != 2)
                {
                    Console.WriteLine("Please input 1 or 2!!!");
                    Console.WriteLine();
                }                  
                int d, m;
                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            Console.Write("Input your birthday day: ");
                            int.TryParse(Console.ReadLine(), out d);
                            Console.Write("Input your birthday month: ");
                            int.TryParse(Console.ReadLine(), out m);
                            if (!CheckDate(d, m))
                                Console.WriteLine("Invalid date, please input again!");                               
                            else
                                break;
                            Console.WriteLine();
                        }
                        string enZodiac = GetZodiacEnglish(d, m);
                        Console.WriteLine($"Your zodiac sign is {enZodiac}.");
                        break;
                    case 2:
                        while (true)
                        {
                            Console.Write("Nhập ngày sinh của bạn: ");
                            int.TryParse(Console.ReadLine(), out d);
                            Console.Write("Nhập tháng sinh của bạn: ");
                            int.TryParse(Console.ReadLine(), out m);
                            if (!CheckDate(d, m))
                                Console.WriteLine("Ngày không hợp lệ, vui lòng nhập lại!");       
                            else
                                break;
                            Console.WriteLine();
                        }
                        string viZodiac = GetZodiacVietnamese(GetZodiacEnglish(d, m));
                        Console.WriteLine($"Cung hoàng đạo của bạn là {viZodiac}.");
                        break;
                }
            } while (choice != 1 && choice != 2);
        }

        /// <summary>
        /// This method will return the zodiac sign in English based on day and month of birth.
        /// </summary>
        /// <param name="day">Day must be between 1...31</param>
        /// <param name="month">Month must be between 1..12</param>
        /// <returns></returns>
        private static string GetZodiacEnglish(int day, int month)
        {
            switch (month)
            {
                case 1:
                    if (day <= 19)
                        return "Capricorn"; //Ma Kết
                    return "Aquarius"; //Bảo Bình
                case 2:
                    if (day <= 18)
                        return "Aquarius";
                    return "Pisces"; //Song Ngư
                case 3:
                    if (day <= 20)
                        return "Pisces";
                    return "Aries"; //Bạch Dương
                case 4:
                    if (day <= 19)
                        return "Aries";
                    return "Taurus"; //Kim Ngưu
                case 5:
                    if (day <= 20)
                        return "Taurus";
                    return "Gemini"; //Song Tử
                case 6:
                    if (day <= 20)
                        return "Gemini";
                    return "Cancer"; //Cự Giải
                case 7:
                    if (day <= 22)
                        return "Cancer";
                    return "Leo"; //Sư Tử
                case 8:
                    if (day <= 22)
                        return "Leo";
                    return "Virgo"; //Xử Nữ
                case 9:
                    if (day <= 22)
                        return "Virgo";
                    return "Libra"; //Thiên Bình
                case 10:
                    if (day <= 22)
                        return "Libra";
                    return "Scorpio"; //Bọ Cạp
                case 11:
                    if (day <= 21)
                        return "Scorpio";
                    return "Sagittarius"; //Nhân Mã
                case 12:
                    if (day <= 21)
                        return "Sagittarius";
                    return "Capricorn";
                default:
                    return "Wrong month!";
            }
        }

        /// <summary>
        /// This method converts/translates English zodiac sign to Vietnamese zodiac sign. 
        /// </summary>
        /// <param name="zodiacEnglish">zodiac sign in English.</param>
        /// <returns>The zodiac sign in Vietnamese.</returns>
        private static string GetZodiacVietnamese(string zodiacEnglish)
        {
            switch (zodiacEnglish)
            {
                case "Capricorn":
                    return "Ma Kết";
                case "Aquarius":
                    return "Bảo Bình";
                case "Pisces":
                    return "Song Ngư";
                case "Aries":
                    return "Bạch Dương";
                case "Taurus":
                    return "Kim Ngưu";
                case "Gemini":
                    return "Song Tử";
                case "Cancer":
                    return "Cự Giải";
                case "Leo":
                    return "Sư Tử";
                case "Virgo":
                    return "Xử Nữ";
                case "Libra":
                    return "Thiên Bình";
                case "Scorpio":
                    return "Bọ Cạp";
                case "Sagittarius":
                    return "Nhân Mã";
                default:
                    return "Tháng không hợp lệ!";  //one of my dream girls
            }
        }
        /// <summary>
        /// This method will check whether the value of day and month is valid or not.
        /// </summary>
        /// <param name="d">d is an integer.</param>
        /// <param name="m">m is an integer.</param>
        /// <returns>Returns True if the date is valid and otherwise.</returns>
        private static bool CheckDate(int d, int m)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if(d<=31) 
                        return true;
                    return false;
           
                case 4:
                case 6:
                case 9:
                case 11:
                    if(d<=30)
                        return true;
                    return false;
                case 2:
                    if (d <= 29)
                        return true;
                    return false;
                default: 
                    return false;
            }
        }
    }
}
