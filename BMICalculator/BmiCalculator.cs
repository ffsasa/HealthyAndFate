using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    public class BmiCalculator
    {
        public static double GetBmi(double weight, double height) => weight / (height * height);

        public static string EvaluateWeightStatus(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight - Ốm quá!!!";
            if (bmi < 25)
                return "You are the perfect one in weight & shape";
            if (bmi < 30)
                return "Overweight - Quá kí";
            return "Obese - Béo phì";
        }
    }
}
