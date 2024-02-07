namespace Bmi //~ package bên Java, thự mục/ngăn tủ chứa các class theo một tiêu chí phân loại
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double bmi = BmiCalculator.GetBmi(48, 1.6);
            Console.WriteLine("1.You BMI is: " + bmi); //in chuỗi/ghép chuỗi truyền thống dùng toán tử "+"
            Console.WriteLine("2.You BMI is: {0}", bmi);//Place-holder chừa chỗ sẵn trong chuỗi, fill value từ biến vào sau, nếu có nhiều biến thì chừa chỗ đếm từ 0, 1, 2

            Console.WriteLine("3.You BMI is: {0} | {1}", bmi, 2024);
            Console.WriteLine($"4.You BMI is: {bmi}");//INTERPOLATION - Nội suy, cố gắng tìm trong chuỗi có biến hay không, nếu có thì tự thay value vào
            Console.WriteLine("5.You BMI is: {0}", BmiCalculator.GetBmi(48, 1.6));
            Console.WriteLine($"6.You BMI is: {BmiCalculator.GetBmi(48, 1.6)}");

            string weightStatus = BmiCalculator.EvaluateWeightStatusEn(bmi);
            Console.WriteLine($"Your BMI is {bmi} based on weight 48kg & height = 1.6m \nand your weight status is {weightStatus}");

            Console.WriteLine(@$"Your BMI is {bmi}

based on weight 48kg & height = 1.6m 

and your weight status is {weightStatus}");

            //Console.WriteLine("Press any key to exit...");
            //Console.ReadLine();

            //BmiCalculator.GetBmi(48, 1.6);
        }
        //Các hàm năm trong class

        //Hàm có 1 dòng lệnh duy nhất là hàm đặc biệt có thể rút gọn. Kĩ thuật BODY EXPRESSION, đặt body sau =>. Không được nhầm lẫn với biểu thức LAMBDA
        //Ctrl K C là comment
        //Ctrl K U là hủy comment
        //Ctrl K D là format lại
    }
    //class khác được quyền khai báo ở đây
    //1 không gian tên - 1 căn phòng - 1 package chứa nhiều class có liên quan
    //Kĩ thuật tổ chức lưu trũ các class mà thôi
}
