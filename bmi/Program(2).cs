using System;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(bmiVerdict(100,1.84));
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
