using System;
/// <summary>
/// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
/// массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме; 
/// б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
/// </summary>

namespace Homework2
{
    public partial class Homework2
    {
        public static void Task5()
        {
            Console.WriteLine("Please enter your weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height:");
            double height = Convert.ToDouble(Console.ReadLine()) / 100;

            //TODO: Перенести в метод
            // Норма ИМТ: нижний порог: 18,5. Верхний порог - 25
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine($"Your BMI is {bmi:F2}");
            if (bmi < 18.5) {
                double goodweight = 18.5 * height;
                double difference = goodweight - weight;
                Console.WriteLine($"Your BMI are low. You have to gain {difference:F2} kilograms to gain {goodweight:F2} kg");
            }
            if (bmi > 25)
            {
                double goodweight = 25 * height;
                double difference = weight - goodweight;
                Console.WriteLine($"Your BMI are low. You have to drop {difference:F2} kilograms to reach {goodweight:F2} kg");
            }
            else
            {
                Console.WriteLine("Your readings are normal.");
            }

        }

    }
}
