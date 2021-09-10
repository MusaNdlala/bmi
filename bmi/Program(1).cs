using System;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("underweight if bmi is 18.5 and under");
            Console.WriteLine("normal if bmi is 18.5 and/or under 24.9");
            Console.WriteLine("overweight if bmi is 25 and/or under 30");
            Console.WriteLine("obese 30 and above");

            Console.WriteLine("Please enter your weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height in meters ie 1.84");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(bmiVerdict(weight,height));
            Console.ReadLine();
        }
        static string bmiVerdict(double kil, double m){
            double value = bmiCal(kil,m);
            string Bmi;
            if (value < 18.5 && value >= 0)
                Bmi = "Underweight";
            else if (value >= 18.5 && value <= 24.9)
                Bmi = "Normal";
            else if (value >= 25 && value <= 29.9)
                Bmi = "overweight";
            else if (value >= 30)
                Bmi = "obese";
            else
                Bmi = "invalid data";
            return Bmi;
        }
        static double bmiCal(double kilos, double meters)
        {            
            double answer = kilos / (meters * meters);
            Console.WriteLine(answer);
            return answer;
        }
    }
}
